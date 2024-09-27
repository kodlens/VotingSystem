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
    public partial class ElectionSetup : Form
    {
        MySqlCommand cmd;
        MySqlConnection con;
        string query;


        public ElectionSetup()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_election_setup WHERE electionName like ?eName order by ay asc";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?eName", txtElection.Text + "%");
               // cmd.Parameters.AddWithValue("?desc", txtDesc.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                this.c1FlexGrid1.AutoGenerateColumns = false;
                this.c1FlexGrid1.DataSource = dt;

                lblNoRows.Text = "Number of Row(s) : " + dt.Rows.Count.ToString();

            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void ElectionSetup_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ElectionSetUpAdd frm = new ElectionSetUpAdd(this);
            frm.ShowDialog();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if(c1FlexGrid1.Rows.Count > 1)
            {
                con = Connection.con();
                con.Open();

                query = "update election_setup set active = 0";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]));
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                query = "update election_setup set active = 1 where electionSetUpID = ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]));
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                con.Close();
                con.Dispose();

                Box.infoBox(c1FlexGrid1[c1FlexGrid1.RowSel,"electionName"].ToString() + " set as default for election.");
                LoadData();
            }
            else
            {
                Box.warnBox("No data selected.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c1FlexGrid1.Rows.Count > 1)
            {
                ElectionSetUpAdd frm = new ElectionSetUpAdd(this);
                frm.id = Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]);
                frm.ShowDialog();
            }
            else
            {
                Box.warnBox("No data selected.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
            {
                int id = Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]);
                Helper.deleteByInt("election_setup", "electionSetUpID", id);
                Box.infoBox("Deleted successfully.");
                LoadData();
            }
        }

        private void newElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElectionSetUpAdd frm = new ElectionSetUpAdd(this);
            frm.ShowDialog();
        }

        private void modifyElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (c1FlexGrid1.Rows.Count > 1)
            {
                ElectionSetUpAdd frm = new ElectionSetUpAdd(this);
                frm.id = Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]);
                frm.ShowDialog();
            }
            else
            {
                Box.warnBox("No data selected.");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void deleteElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
            {
                int id = Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]);
                Helper.deleteByInt("election_setup", "electionSetUpID", id);
                Box.infoBox("Deleted successfully.");
                LoadData();
            }
        }

        private void showRegisteredStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(c1FlexGrid1.Rows.Count > 1)
            {
                RegisterdVoterMainform frm = new RegisterdVoterMainform();
                frm.electionName = c1FlexGrid1[c1FlexGrid1.RowSel, "electionName"].ToString();
                frm.ShowDialog();
            }
        }


    }
}
