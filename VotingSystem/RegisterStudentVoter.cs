using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using C1.Win;
using MySql.Data.MySqlClient;



namespace VotingSystem
{
    public partial class RegisterStudentVoter : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public string electionName;

        RegisterdVoterMainform _frm;

        public RegisterStudentVoter(RegisterdVoterMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }


        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "proc_regvoter_only";
                cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("?velectionName", electionName);
                cmd.Parameters.AddWithValue("?vlname", txtlname.Text);
                cmd.Parameters.AddWithValue("?vfname", txtfname.Text);
                cmd.Parameters.AddWithValue("?vcode", cmbProgram.Text);
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

               this.flxStudent.AutoGenerateColumns = false;
               this.flxStudent.DataSource = dt;

                lblNoRows.Text = "Number of Rows : " + dt.Rows.Count.ToString();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(flxStudent.Rows.Count > 1)
            {

               
                con = Connection.con();
                con.Open();

                foreach (C1.Win.C1FlexGrid.RowCol row in flxStudent.Rows)
                {
                    if (row.Selected == true)
                    {
                        int id = Convert.ToInt32(flxStudent[row.Index, "votersID"]);
                        int esetupID = Helper.returnIDperConnection(con, "election_setup", "electionName", electionName, "electionSetUpID");

                        query = "INSERT INTO register_voter (votersID, electionSetupID) VALUES (?votersid, ?esetupID)";
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


                Box.infoBox("Successfully registered.");
                LoadData();
                _frm.loaddata();
            }
            else
            {
                Box.warnBox("No data found.");
            }
           
        }



        private void RegisterStudentVoter_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.LoadCmb("select distinct(programCode) as programCode from programs order by programCode asc", cmbProgram);
                LoadData();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }



    }
}
