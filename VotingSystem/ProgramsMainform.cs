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
    public partial class ProgramsMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public ProgramsMainform()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_programs WHERE programCode like ?code and programDesc like ?desc order by programCode asc";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?code", txtCode.Text + "%");
                cmd.Parameters.AddWithValue("?desc", txtDesc.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                this.flxPrograms.AutoGenerateColumns = false;
                this.flxPrograms.DataSource = dt;
                //flxAY
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void ProgramsMainform_Load(object sender, EventArgs e)
        {
            try
            {
             //   Helper.cmbLoadAY(cmbAy);

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
            }
        }

        private void newElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramsAdd frm = new ProgramsAdd(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void modifyElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxPrograms.Rows.Count > 0)
            {
                ProgramsAdd frm = new ProgramsAdd(this);
                frm.id = Convert.ToInt32(flxPrograms[flxPrograms.RowSel, 1]);
                frm.ShowDialog(this);
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void deleteElectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flxPrograms.Rows.Count > 1)
            {
                if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
                {
                    int id = Convert.ToInt32(flxPrograms[flxPrograms.RowSel, 1]);
                    Helper.deleteByInt("programs", "programID", id);
                    Box.infoBox("Deleted successfully.");
                    LoadData();
                }
            }
        }


    }
}
