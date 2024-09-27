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
    public partial class SetupPositionMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public SetupPositionMainform()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from vw_position WHERE position like ?pos and electionName like ?elecName order by orderNo asc";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos", txtPosition.Text + "%");
                cmd.Parameters.AddWithValue("?elecName", cmbElection.Text + "%");
                //cmd.Parameters.AddWithValue("?desc", txtDesc.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                this.c1FlexGrid1.AutoGenerateColumns = false;
                this.c1FlexGrid1.DataSource = dt;
                //flxAY
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void SetupPositionMainform_Load(object sender, EventArgs e)
        {

            Helper.LoadCmb("select distinct(electionName) from election_setup order by electionName asc", cmbElection);

            LoadData();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetUpPositionAdd frm = new SetUpPositionAdd(this);
            frm.id = 0;
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (c1FlexGrid1.Rows.Count > 01)
            {
                SetUpPositionAdd frm = new SetUpPositionAdd(this);
                frm.id = Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]);
                frm.ShowDialog(this);
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (c1FlexGrid1.Rows.Count > 1)
            {
                if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
                {
                    int id = Convert.ToInt32(c1FlexGrid1[c1FlexGrid1.RowSel, 1]);
                    Helper.deleteByInt("position_setup", "positionSetUpID", id);
                    Box.infoBox("Deleted successfully.");
                    LoadData();
                }
            }
            else
            {
                Box.warnBox("No data selected.");
            }
                
        }
    }

}
