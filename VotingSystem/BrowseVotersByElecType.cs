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
    public partial class BrowseVotersByElecType : Form
    {
        public string elecType;



        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        CandidateAdd _frm;

        public BrowseVotersByElecType(CandidateAdd _frm)
        {
            InitializeComponent();
            this._frm = _frm;

            txtVotersID.KeyDown += Search_KeyDown;
            txtlname.KeyDown += Search_KeyDown;
            txtfname.KeyDown += Search_KeyDown;
        }

        public void loaddata()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = @"select * from (select * from vw_registeredvoter where electionName = ?electName) as a where votersID like ?id
                        and lname like ?lname and fname like ?fname and programCode like ?progcode";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?electName", elecType);
                cmd.Parameters.AddWithValue("?id", txtVotersID.Text + "%");
                cmd.Parameters.AddWithValue("?lname", txtlname.Text + "%");
                cmd.Parameters.AddWithValue("?fname", txtfname.Text + "%");
                cmd.Parameters.AddWithValue("?progcode", cmbProgram.Text + "%");
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

        private void BrowseVotersByElecType_Load(object sender, EventArgs e)
        {
            loaddata();

            Helper.LoadCmb("select distinct(programCode) from programs order by programCode asc", cmbProgram);
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loaddata();
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                _frm.txtVotersID.Text = Convert.ToString(flx[flx.RowSel,"votersID"]);
                _frm.txtlname.Text = Convert.ToString(flx[flx.RowSel, "lname"]);
                _frm.txtfname.Text = Convert.ToString(flx[flx.RowSel, "fname"]);
                _frm.txtmname.Text = Convert.ToString(flx[flx.RowSel, "mname"]);
                this.Close();
            }
            else
            {
                Box.warnBox("No data found.");
            }
        }

        private void flx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSelect_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
