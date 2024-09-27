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
    public partial class ResetPassword : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public int id;
        public string position;

      


        public ResetPassword()
        {
            InitializeComponent();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnpwd.Text))
            {
                Box.warnBox("Please input new password.");
                  return;
            }
            if (String.IsNullOrEmpty(txtrpwd.Text))
            {
                Box.warnBox("Retype the password.");
                return;
            }
            if(txtnpwd.Text != txtrpwd.Text)
            {
                Box.warnBox("Password not match.");
                return;
            }

            try
            {
                processSave();
                this.Close();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
               // throw;
            }
        }


        void processSave()
        {
            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                query = "UPDATE user_info SET pwd=?pwd WHERE userinfoID=?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pwd", txtnpwd.Text);
                cmd.Parameters.AddWithValue("?id", id);
                int i = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (i > 0)
                {
                    Box.infoBox("Password reset.");
                   // Box.infoBox(Properties.Settings.Default.position.ToLower());
                    if(position.ToLower() == "administrator")
                    {
                        Box.infoBox("E-VOTING SYSTEM WILL CLOSE.");
                        Application.Exit();
                        //this.Close();
                    }
                }
                else
                {
                    Box.warnBox("An error occured. Please contact System Administrator.");
                }
            }
        }


    }
}
