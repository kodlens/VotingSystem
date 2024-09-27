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
    public partial class InstituteAdd : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;

        InstituteMainform _frm;

        public InstituteAdd(InstituteMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }



        void getData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from institute where instituteID=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            if (dt.Rows.Count > 0)
            {
                txtCode.Text = Convert.ToString(dt.Rows[0]["code"]);
                txtdesc.Text = Convert.ToString(dt.Rows[0]["institute"]);
             
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                Box.warnBox("Please input institute code.");
                return;
            }
            if (String.IsNullOrEmpty(txtdesc.Text))
            {
                Box.warnBox("Please input institute description.");
                return;
            }

            if (id == 0)
            {
                if(Helper.isExistString("institute", "code", txtCode.Text) == true)
                {
                    Box.warnBox("Institute Code already in the database.");
                    return;
                }
            }


            processSave();
            this.Close();
        }

        void processSave()
        {

           
            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                query = @"UPDATE institute SET code=?code,  institute=?ins 
                        WHERE instituteID = ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?code", txtCode.Text);
                cmd.Parameters.AddWithValue("?ins", txtdesc.Text);
                cmd.Parameters.AddWithValue("?id", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.infoBox("Institute successfully updated.");
                }
                else
                {
                    Box.errBox("An error occured. Please contact administrator.");
                }


            }
            else
            {
                con = Connection.con();
                con.Open();
                query = @"INSERT INTO institute SET code=?code,  institute=?ins";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?code", txtCode.Text);
                cmd.Parameters.AddWithValue("?ins", txtdesc.Text);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();


                if (n > 0)
                {
                    Box.infoBox("Institute successfully saved!.");
                }
                else
                {
                    Box.errBox("An error occured. Please contact administrator.");
                }

            }


            _frm.LoadData();
        }



        private void InstituteAdd_Load(object sender, EventArgs e)
        {
            try
            {


                if (id > 0)
                {
                    getData();
                }
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }
    }
}
