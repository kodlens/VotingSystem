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
    public partial class VotersMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;



        public VotersMainform()
        {
            InitializeComponent();


            txtIDNo.KeyDown += Search_KeyDown;
            txtfname.KeyDown += Search_KeyDown;
            txtlname.KeyDown += Search_KeyDown;

            cmbProgramcode.KeyDown += Search_KeyDown;


        }


        public void LoadData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from vw_votersinfo where votersID like ?votersid and lname like ?lname and fname like ?fname and programCode like ?pCode  order by lname asc ";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("??votersid", txtIDNo.Text + "%");
            cmd.Parameters.AddWithValue("?lname", txtlname.Text + "%");
            cmd.Parameters.AddWithValue("?fname", txtfname.Text + "%");
            cmd.Parameters.AddWithValue("?pCode", cmbProgramcode.Text + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            flxVoter.AutoGenerateColumns = false;
            flxVoter.DataSource = dt;

            lblRows.Text =  dt.Rows.Count.ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VotersAdd frm = new VotersAdd(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void StudentMainform_Load(object sender, EventArgs e)
        {
           // Helper.SetupControlAccess(this, contextMenuStrip1);
               Helper.LoadCmb("select distinct(programCode) from programs order by programCode asc", cmbProgramcode);
                LoadData();
            try
            {
               // Helper.SetupControlAccess(this, contextMenuStrip1);
                Helper.LoadCmb("select distinct(programCode) from programs order by programCode asc", cmbProgramcode);
                LoadData();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flxVoter.Rows.Count > 1)
            {
                VotersAdd frm = new VotersAdd(this);
                frm.id = Convert.ToInt32(flxVoter[flxVoter.RowSel, 1]);
                frm.ShowDialog(this);
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    LoadData();
                }
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(flxVoter.Rows.Count > 1)
            {
                if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
                {
                    int id = Convert.ToInt32(flxVoter[flxVoter.RowSel, 1]);
                    Helper.deleteByInt("voters", "votersID", id);
                    Box.infoBox("Deleted successfully.");
                    LoadData();
                }
            }
            else
            {
                Box.warnBox("No data found.");
            }
        }

        private void chagePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxVoter.Rows.Count > 1)
            {
                ChangePasswordFrom frm = new ChangePasswordFrom();
                frm.id = Convert.ToInt32(flxVoter[flxVoter.RowSel, 1]);
                frm.ShowDialog(this);
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(sender, e);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            VotersUploaderForm frm = new VotersUploaderForm();
            frm.ShowDialog();
        }


    }
}
