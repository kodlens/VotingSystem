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
    public partial class CandidateMainform : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public CandidateMainform()
        {
            InitializeComponent();

            cmbPosition.KeyDown += Search_KeyDown;
            txtlname.KeyDown += Search_KeyDown;
            txtfname.KeyDown += Search_KeyDown;

            Helper.getActiveElection();
        }


        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loaddata();
        }

        public void loaddata()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_candidates where lname like ?lname and fname like ?fname and electionName like ?ename and position like ?pos and code like ?code order by lname asc";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?lname", txtlname.Text + "%");
                cmd.Parameters.AddWithValue("?fname", txtfname.Text + "%");
                cmd.Parameters.AddWithValue("?ename", Helper.electionName);
                cmd.Parameters.AddWithValue("?pos", cmbPosition.Text + "%");
                cmd.Parameters.AddWithValue("?code", cmbInstitute.Text + "%");
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adptr.Fill(dt);

                adptr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                flx.AutoGenerateColumns = false;
                this.flx.DataSource = dt;
            }
            catch (Exception rt)
            {
                Box.errBox(rt.Message);
                //throw;
            }
        }

        private void CandidateMainform_Load(object sender, EventArgs e)
        {
            Helper.LoadCmb("select distinct(code) from institute order by code asc",cmbInstitute);
            Helper.cmbLoadActivePositions(cmbPosition);
            loaddata();
        }

        private void newCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CandidateAdd frm = new CandidateAdd(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void modifyCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 0)
            {
                try
                {
                    CandidateAdd frm = new CandidateAdd(this);
                    frm.id = Convert.ToInt32(flx[flx.RowSel, 1]);
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
                Box.warnBox("No data found.");
            }
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void deleteCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 1)
            {
                try
                {
                    if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
                    {
                        int id = Convert.ToInt32(flx[flx.RowSel, 1]);
                        Helper.deleteByInt("candidates", "candidateID", id);
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
                Box.warnBox("No data found.");
            }
        }

        private void checkCandidateRequirementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                CheckCandidateRequirementsForm frm = new CheckCandidateRequirementsForm();
                frm.electionName = Helper.electionName;
                frm.votersID = Convert.ToInt32(flx[flx.RowSel, "votersID"]);
                frm.fullname = Convert.ToString(flx[flx.RowSel, "lname"] + ", " + flx[flx.RowSel, "fname"] + " " + flx[flx.RowSel, "mname"]).Trim();
                frm.candidateID = Convert.ToInt32(flx[flx.RowSel, "candidateID"]);
                frm.ShowDialog();
            }
            else
            {
                Box.warnBox("No data found.");
            }
           
        }

        private void viewCertificateOfCandidacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                try
                {
                    Print_COC frm = new Print_COC();
                    frm.id = Convert.ToInt32(flx[flx.RowSel, 1]);
                    frm.ShowDialog();
                }
                catch (Exception er)
                {
                    Box.errBox(er.Message);
                    //throw;
                }
            }
        }

        private void btnNewCandidate_Click(object sender, EventArgs e)
        {
            newCandidateToolStripMenuItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modifyCandidateToolStripMenuItem_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshListToolStripMenuItem_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteCandidateToolStripMenuItem_Click(sender, e);
        }

        private void markAsEligibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            if(flx.Rows.Count > 1)
            {

                try
                {
                    int id = Convert.ToInt32(flx[flx.RowSel, "candidateID"]);
                    con = Connection.con();
                    con.Open();


                    query = "update candidates set eligible = 1 where candidateID=?cid";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?cid", id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    con.Dispose();

                    Box.infoBox("Successfully set to eligible.");
                   // loaddata();
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
    }
}
