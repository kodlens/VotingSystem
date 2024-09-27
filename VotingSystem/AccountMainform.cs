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
    public partial class AccountMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public AccountMainform()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_userinfo where userinfoID like ?id and lname like ?lname and fname like ?fname";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", txtid.Text + "%");
                cmd.Parameters.AddWithValue("?lname", txtlname.Text + "%");
                cmd.Parameters.AddWithValue("?fname", txtfname.Text + "%");
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adptr.Fill(dt);

                adptr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                this.flxAccount.DataSource = dt;
            }
            catch (Exception rt)
            {
                Box.errBox(rt.Message);
                //throw;
            }
        }

        private void AccountMainform_Load(object sender, EventArgs e)
        {
            try
            {
              //  Helper.SetupControlAccess(this, contextMenuStrip1);
                loaddata();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AccountAdd frm = new AccountAdd(this);
                frm.id = 0;
                frm.ShowDialog();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(flxAccount.Rows.Count > 1)
            {
                try
                {
                    AccountAdd frm = new AccountAdd(this);
                    frm.id = Convert.ToInt32(flxAccount[flxAccount.RowSel, 1]);
                    frm.ShowDialog();
                }
                catch (Exception er)
                {
                    Box.errBox(er.Message);
                    // throw;
                }
            }
            else
            {
                Box.warnBox("No data selected.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flxAccount.Rows.Count > 1)
            {
                try
                {
                    if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
                    {
                        int id = Convert.ToInt32(flxAccount[flxAccount.RowSel, 1]);
                        Helper.deleteByInt("user_info", "userinfoID", id);
                        Box.infoBox("Deleted successfully.");
                        loaddata();
                    }
                }
                catch (Exception er)
                {
                    Box.errBox(er.Message);
                    //throw;
                }
            }
            else
            {
                Box.warnBox("No data selected.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ResetPassword frm = new ResetPassword();
                frm.id = Convert.ToInt32(flxAccount[flxAccount.RowSel, 1]);
                frm.position = Convert.ToString(flxAccount[flxAccount.RowSel, "position"]);
                frm.ShowDialog();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
               // throw;
            }
          
        }


    }
}
