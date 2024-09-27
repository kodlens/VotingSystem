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
    public partial class BarangayMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;



        public BarangayMainform()
        {
            InitializeComponent();
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
                // throw;
            }
        }

        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_brgy where brgy like ?brgy";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?brgy", txtBrgy.Text + "%");

                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                this.flxbrgy.AutoGenerateColumns = false;
                this.flxbrgy.DataSource = dt;
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarangayAdd frm = new BarangayAdd(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxbrgy.Rows.Count > 0)
            {
                BarangayAdd frm = new BarangayAdd(this);
                frm.id = Convert.ToInt32(flxbrgy[flxbrgy.RowSel, "brgyID"]);
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
            {
                int id = Convert.ToInt32(flxbrgy[flxbrgy.RowSel, 1]);
                Helper.deleteByInt("brgy", "brgyID", id);
                Box.infoBox("Deleted successfully.");
                LoadData();
            }
        }

        private void BarangayMainform_Load(object sender, EventArgs e)
        {
            try
            {
                //Helper.SetupControlAccess(this, contextMenuStrip1);

                LoadData();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }

        private void txtBrgy_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                LoadData();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }
    }
}
