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
    public partial class Login : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtuser.Text))
            {
                Box.warnBox("Please input username.");
                return;
            }
            if (String.IsNullOrEmpty(txtpwd.Text))
            {
                Box.warnBox("Please input password.");
                return;
            }

            if (isLogin())
            {
                txtuser.Text = "";
                txtpwd.Text = "";

                Mainform frm = new Mainform(this);
                frm.Show();
                this.Hide();
            }
            else
            {
                Box.errBox("Username and Password error.");
            }

        }



        bool isLogin()
        {
            bool flag = false;
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM vw_userinfo WHERE username = ?user and pwd=?pwd";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?user", txtuser.Text);
            cmd.Parameters.AddWithValue("?pwd", txtpwd.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                flag = true;
                Properties.Settings.Default.user = Convert.ToString(dr["username"]);
                Properties.Settings.Default.lname = Convert.ToString(dr["lname"]);
                Properties.Settings.Default.fname = Convert.ToString(dr["fname"]);
                Properties.Settings.Default.mname = Convert.ToString(dr["mname"]);
                Properties.Settings.Default.position = Convert.ToString(dr["position"]);
                Properties.Settings.Default.Save();
            }
          
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return flag;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
