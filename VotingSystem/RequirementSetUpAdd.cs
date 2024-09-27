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
    public partial class RequirementSetUpAdd : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;

        RequirementSetupMainform _frm;


        public RequirementSetUpAdd(RequirementSetupMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;

            cmbElectionName.KeyDown += EnterKeydown;
            txtdesc.KeyDown += EnterKeydown;
        }


        private void EnterKeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        void processSave()
        {
            if (id > 0)
            {

                int electionSetupID = Helper.returnElectionSetupID(cmbElectionName);

                con = Connection.con();
                con.Open();
                query = @"UPDATE requirements_setup SET description=?desc, electionSetUpID=?elecID WHERE reqsetupID = ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?desc", txtdesc.Text);
                cmd.Parameters.AddWithValue("?elecID", electionSetupID);
               
                cmd.Parameters.AddWithValue("?id", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.infoBox("Requirement Setup successfully updated.");
                }
                else
                {
                    Box.errBox("An error occured. Please contact administrator.");
                }


            }
            else
            {
                int electionSetupID = Helper.returnElectionSetupID(cmbElectionName);

                con = Connection.con();
                con.Open();
                query = @"INSERT INTO requirements_setup SET description=?desc, electionSetUpID=?elecID";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?desc", txtdesc.Text);
                cmd.Parameters.AddWithValue("?elecID", electionSetupID);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                id = Helper.returnLastInsertID(con);
                con.Close();
                con.Dispose();

                // Box.infoBox("Institute successfully updated.");

                if (n > 0)
                {
                    Box.infoBox("Requirement Setup successfully saved!.");
                }
                else
                {
                    Box.errBox("An error occured. Please contact administrator.");
                }

            }


            _frm.loaddata();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbElectionName.Text))
            {
                Box.warnBox("Please select election name.");
                return;
            }
            if (String.IsNullOrEmpty(txtdesc.Text))
            {
                Box.warnBox("Please input description.");
                return;
            }

            processSave();
        }

        private void RequirementSetUpAdd_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.cmbLoadElectionName(cmbElectionName);

                if (id > 0)
                {
                    getData();
                }
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }

        void getData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from vw_reqsetup where reqsetupID=?id";
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
                txtdesc.Text = Convert.ToString(dt.Rows[0]["description"]);
                cmbElectionName.Text = Convert.ToString(dt.Rows[0]["electionName"]);
            }



        }




    }
}
