using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class RegisterdVoterMainform : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public string electionName;

        public RegisterdVoterMainform()
        {
            InitializeComponent();
        }


        public void loaddata()
        {
            con = Connection.con();
            con.Open();
            query = @"select * from (select * from vw_registeredvoter where electionName = ?ename) as a 
                    where lname like ?lname and fname like ?fname and programCode like ?code and code like ?inscode order by lname asc";
            cmd = new MySqlCommand(query, con);
            //  cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?lname", txtlname.Text + "%");
            cmd.Parameters.AddWithValue("?fname", txtfname.Text + "%");
            cmd.Parameters.AddWithValue("?code",cmbProgram.Text + "%");
            cmd.Parameters.AddWithValue("?inscode", cmbInstitute.Text + "%");
            cmd.Parameters.AddWithValue("?ename", electionName);
            DataTable dt = new DataTable();
            MySqlDataAdapter adtpr = new MySqlDataAdapter(cmd);
            adtpr.Fill(dt);
            adtpr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            flxRegVoters.AutoGenerateColumns = false;
            flxRegVoters.DataSource = dt;
            lblNoRows.Text = "Number of Row(s) : " + dt.Rows.Count.ToString();
        }

        private void RegisterdVoterMainform_Load(object sender, EventArgs e)
        {
            try
            {
                lblTypeElection.Text = electionName;
                Helper.LoadCmb("select distinct(programCode) as programCode from programs order by programCode asc", cmbProgram);
                Helper.LoadCmb("select distinct(code) as code from institute order by code asc", cmbInstitute);
                loaddata();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudentVoter frm = new RegisterStudentVoter(this);
            frm.electionName = electionName;
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loaddata();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
          
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxRegVoters.Rows.Count > 1)
            {
                if (Box.questionBox("Are you sure you want to remove this/these voter(s)?","REMOVE?"))
                {
                    con = Connection.con();
                    con.Open();

                    foreach (C1.Win.C1FlexGrid.RowCol row in flxRegVoters.Rows)
                    {
                        if (row.Selected == true)
                        {
                            int id = Convert.ToInt32(flxRegVoters[row.Index, "votersID"]);
                            int esetupID = Helper.returnIDperConnection(con, "election_setup", "electionName", electionName, "electionSetUpID");

                            query = "DELETE FROM register_voter WHERE votersID = ?votersid AND electionSetupID = ?esetupID";
                            cmd = new MySqlCommand(query, con);
                            cmd.Parameters.AddWithValue("?votersid", id);
                            cmd.Parameters.AddWithValue("?esetupID", esetupID);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                    }


                    cmd.Dispose();
                    con.Close();
                    con.Dispose();


                    Box.infoBox("Voter(s) successfully removed.");
                    loaddata();
                }
            }
            else
            {
                Box.warnBox("No data found.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerStudentToolStripMenuItem_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeStudentToolStripMenuItem_Click(sender, e);
        }
    }
}
