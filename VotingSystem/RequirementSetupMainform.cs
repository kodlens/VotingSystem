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
    public partial class RequirementSetupMainform : Form
    {


        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public RequirementSetupMainform()
        {
            InitializeComponent();


            cmbElectionName.KeyDown += Search_KeyDown;
            txtDesc.KeyDown += Search_KeyDown;
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loaddata();
            }
        }

        public void loaddata()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_reqsetup where electionName like ?elecname and description like ?desc";
                cmd = new MySqlCommand(query, con);
               cmd.Parameters.AddWithValue("?elecname", cmbElectionName.Text + "%");
                cmd.Parameters.AddWithValue("?desc", txtDesc.Text + "%");
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

        private void RequirementSetupMainform_Load(object sender, EventArgs e)
        {
            Helper.cmbLoadElectionName(cmbElectionName);
            loaddata();
          
        }

        private void newElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequirementSetUpAdd frm = new RequirementSetUpAdd(this);
            frm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaddata();
           
        }

        private void modifyElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                try
                {
                    RequirementSetUpAdd frm = new RequirementSetUpAdd(this);
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

        private void deleteElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                try
                {
                    if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
                    {
                        int id = Convert.ToInt32(flx[flx.RowSel, 1]);
                        Helper.deleteByInt("requirements_setup", "reqsetupID", id);
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

        private void btnNewRequirement_Click(object sender, EventArgs e)
        {
            newElectionSetupToolStripMenuItem_Click(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyElectionSetupToolStripMenuItem_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshToolStripMenuItem_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteElectionSetupToolStripMenuItem_Click(sender, e);
        }
    }
}
