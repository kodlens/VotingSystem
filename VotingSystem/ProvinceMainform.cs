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
    public partial class ProvinceMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public ProvinceMainform()
        {
            InitializeComponent();
        }


        public void loadData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from province where province like ?prov order by province asc";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?prov", txtsearch.Text + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            flxProvince.AutoGenerateColumns = false;
            flxProvince.DataSource = dt;


        }



        private void ProvinceMainform_Load(object sender, EventArgs e)
        {

            try
            {
                // Helper.SetupControlAccess(this, contextMenuStrip1);
                loadData();

            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            loadData();
        }

        private void flxProvince_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteToolStripMenuItem_Click(sender, e);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinceAdd frm = new ProvinceAdd(this);
            frm.id = 0;
            frm.isFromProvMainForm = true;
            frm.ShowDialog();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxProvince.Rows.Count > 1)
            {
                ProvinceAdd frm = new ProvinceAdd(this);
                frm.id = Convert.ToInt32(flxProvince[flxProvince.RowSel, 1]);
                frm.isFromProvMainForm = true;
                frm.ShowDialog();
            }
            else
            {
                Box.warnBox("No data selected!");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxProvince.Rows.Count > 1)
            {
                // int dataid = Convert.ToInt32(flxProvince[flxProvince.RowSel, 1]);
                if (Box.questionBox("Are you sure you want to delete this data?", "DELETE?"))
                {
                    Helper.deleteByInt("province", "provinceID", Helper.getIDFlexGrid(flxProvince));

                    Box.infoBox("Data deleted successfully.");
                    loadData();
                }
            }
            else
            {
                Box.warnBox("No data selected!");
            }
        }
    }
}
