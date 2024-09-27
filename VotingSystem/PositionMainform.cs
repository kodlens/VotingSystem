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
    public partial class PositionMainform : Form
    {
        public PositionMainform()
        {
            InitializeComponent();
        }

        MySqlCommand cmd;
        MySqlConnection con;
        string query;


        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from nposition where position like ?pos order by position asc";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos", txtsearch.Text + "%");

                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                this.flxPosition.AutoGenerateColumns = false;
                this.flxPosition.DataSource = dt;
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {try
            {
                LoadData();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PositionAdd frm = new PositionAdd(this);
            frm.id = 0;
            frm.ShowDialog(this);

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (flxPosition.Rows.Count > 0)
            {
                PositionAdd frm = new PositionAdd(this);
                frm.id = Convert.ToInt32(flxPosition[flxPosition.RowSel, 1]);
                frm.ShowDialog(this);
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
            {
                int id = Convert.ToInt32(flxPosition[flxPosition.RowSel, 1]);
                Helper.deleteByInt("nposition", "positionID", id);
                Box.infoBox("Deleted successfully.");
                LoadData();
            }
        }

        private void PositionMainform_Load(object sender, EventArgs e)
        {
            try
            {
                //Helper.SetupControlAccess(this, contextMenuStrip1);
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
