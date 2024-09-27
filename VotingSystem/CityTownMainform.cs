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
    public partial class CityTownMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public CityTownMainform()
        {
            InitializeComponent();


            this.txtzip.KeyPress += Helper.txtInteger;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            con = Connection.con();
            con.Open();
            query = "select * from vw_citytown where province like ?prov and cityTown like ?city and zipcode like ?zip order by cityTown asc";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?prov", txtProv.Text + "%");
            cmd.Parameters.AddWithValue("?city", txtCityTown.Text + "%");
            cmd.Parameters.AddWithValue("?zip", txtzip.Text + "%");
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            flxCItyTown.AutoGenerateColumns = false;
            flxCItyTown.DataSource = dt;
        }

        private void CityTownMainform_Load(object sender, EventArgs e)
        {
            try
            {
                //Helper.SetupControlAccess(this, contextMenuStrip1);
                //Helper.LoadCmb("select distinct(programCode) from programs order by programCode asc", cmbProgramcode);
                loaddata();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                // throw;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityTownAdd frm = new CityTownAdd(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxCItyTown.Rows.Count > 1)
            {
                CityTownAdd frm = new CityTownAdd(this);
                frm.id = Helper.getIDFlexGrid(flxCItyTown);
                frm.ShowDialog();
            }
            else
            {
                Box.warnBox("No data selected!");
            }
        }

        private void addProvinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinceAdd frm = new ProvinceAdd();
            frm.id = 0;
            frm.isFromProvMainForm = false;
            frm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flxCItyTown.Rows.Count > 1)
            {
                // int dataid = Convert.ToInt32(flxProvince[flxProvince.RowSel, 1]);
                if (Box.questionBox("Are you sure you want to delete this data?", "DELETE?"))
                {
                    Helper.deleteByInt("city_town", "cityTownID", Helper.getIDFlexGrid(flxCItyTown));

                    Box.infoBox("Data deleted successfully.");
                    loaddata();
                }
            }
            else
            {
                Box.warnBox("No data selected!");
            }
        }
    }
}
