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
    public partial class ChangePasswordFrom : Form
    {
        MySqlCommand cmd;
        MySqlConnection con;
        string query;


        public int id;

        public ChangePasswordFrom()
        {
            InitializeComponent();
        }

        private void ChangePasswordFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtpwd.Text))
                {
                    Box.warnBox("Please input new password.");
                    return;
                }
                if (txtpwd.Text.Trim() != txtrpwd.Text.Trim())
                {
                    Box.warnBox("Password not match.");
                    return;
                }

                processSave();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
               // throw;
            }
         
        }

        void processSave()
        {
            con = Connection.con();
            con.Open();
            query = "UPDATE voters SET pwd=?pwd WHERE votersID = ?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?pwd", txtpwd.Text.Trim());
            cmd.Parameters.AddWithValue("?id", id);
            int n = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            Box.infoBox("Password successfully modified.");
            this.Close();
        }


    }
}
