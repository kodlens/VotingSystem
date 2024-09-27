using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VotingSystem
{
    public partial class AccountAdd : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        AccountMainform _frm;

        public int id;
        string tempUser;


        public AccountAdd(AccountMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }


        void getData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_userinfo where userInfoID=?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    this.txtuser.Text = Convert.ToString(dt.Rows[0]["username"]);
                    tempUser = Convert.ToString(dt.Rows[0]["username"]);
                    this.txtlname.Text = Convert.ToString(dt.Rows[0]["lname"]);
                    this.txtfname.Text = Convert.ToString(dt.Rows[0]["fname"]);
                    this.txtmname.Text = Convert.ToString(dt.Rows[0]["mname"]);
                    this.cmbPosition.Text = Convert.ToString(dt.Rows[0]["position"]);
                 
                    //this.cmbPos.Text = Convert.ToString(dt.Rows[0]["position"]);
                }
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }



        private void AccountAdd_Load(object sender, EventArgs e)
        {
            try
            {

  
                con = Connection.con();
                con.Open();
                Helper.LoadCmbPerCon(con, "SELECT position FROM nposition", cmbPosition);
                con.Close();
                con.Dispose();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }

            if (id > 0)
            {
                getData();

                txtpwd.ReadOnly = true;
                txtrpwd.ReadOnly = true;
            }


        }

        void processSave()
        {
            int i = 0;


            int positionID;


            if (id > 0)
            {
                //modify
                con = Connection.con();
                con.Open();

                positionID = Helper.returnIDperConnection(con, "nposition", "position", cmbPosition.Text, "positionID");

                query = @"UPDATE user_info SET username=?uname, lname=?lname, fname=?fname, 
                        mname = ?mname, positionID=?posid, ntUser=?ntuser WHERE userinfoID=?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?uname", txtuser.Text);
                //cmd.Parameters.AddWithValue("?pwd", txtpwd.Text);
                cmd.Parameters.AddWithValue("?lname", txtlname.Text);
                cmd.Parameters.AddWithValue("?fname", txtfname.Text);
                cmd.Parameters.AddWithValue("?mname", txtmname.Text);
                cmd.Parameters.AddWithValue("?posid", positionID);
                cmd.Parameters.AddWithValue("?ntuser", Properties.Settings.Default.user);
                cmd.Parameters.AddWithValue("?id", id);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    Box.infoBox("Data successfully updated!");
                }
                else
                {
                    //msg = "Save data error! Please contact Administrator!";
                    Box.errBox("Update data error! Please contact Administrator!");
                }



            }
            else
            {
                //add
                con = Connection.con();
                con.Open();

                positionID = Helper.returnIDperConnection(con, "nposition", "position", cmbPosition.Text, "positionID");
               

                query = @"INSERT INTO user_info (username, pwd, lname, fname, mname, positionID, ntUser) VALUES 
                        (?uname, ?pwd, ?lname, ?fname, ?mname, ?posid, ?ntuser)";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?uname", txtuser.Text);
                cmd.Parameters.AddWithValue("?pwd", txtpwd.Text);
                cmd.Parameters.AddWithValue("?lname", txtlname.Text);
                cmd.Parameters.AddWithValue("?fname", txtfname.Text);
                cmd.Parameters.AddWithValue("?mname", txtmname.Text);
                cmd.Parameters.AddWithValue("?posid", positionID);
                cmd.Parameters.AddWithValue("?ntuser", Properties.Settings.Default.user);
           

                i = cmd.ExecuteNonQuery();

                id = Helper.returnLastInsertID(con);
                if (i > 0)
                {
                    Box.infoBox("Data successfully saved!");
                    //clear();
                }
                else
                { 
                    Box.errBox("Save data error! Please contact Administrator!");
                }
            }

        }




        void clear()
        {
            txtuser.Text = "";
            txtpwd.Text = "";
            txtrpwd.Text = "";
            txtlname.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            cmbPosition.SelectedIndex = -1;
           
        }


        private void btnNewClear_Click(object sender, EventArgs e)
        {
            clear();
            txtpwd.ReadOnly = false;
            txtrpwd.ReadOnly = false;
            try
            {
                con = Connection.con();
                con.Open();
                con.Close();
                con.Dispose();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
            id = 0;
            txtuser.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtuser.Text == "")
            {
                Box.warnBox("Please fill username textbox.");
                return;
            }

            if (id == 0)
            {
                if (this.txtpwd.Text == "")
                {
                    Box.warnBox("Please fill password textbox.");
                    return;
                }

                if (this.txtpwd.Text != this.txtrpwd.Text)
                {
                    Box.warnBox("Password not match!");
                    return;
                }
            }


            if (String.IsNullOrEmpty(txtlname.Text))
            {
                Box.warnBox("Lastname is required.");
                return;
            }
            if (String.IsNullOrEmpty(txtfname.Text))
            {
                Box.warnBox("Firstname is required.");
                return;
            }

            if (cmbPosition.Text == "")
            {
                Box.warnBox("Please select position.");
                return;
            }

            try
            {
                if (txtuser.Text != tempUser)
                {
                    if (Helper.isExistString("user_info", "username", txtuser.Text))
                    {
                        Box.warnBox("Username already exist. Please select another username.");

                        txtuser.Text = "";
                        txtpwd.Text = "";
                        txtrpwd.Text = "";
                        txtuser.Focus();
                        return;
                    }
                }


                processSave();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }


            _frm.loaddata();
        }
    }
}
