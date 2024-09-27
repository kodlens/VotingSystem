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
    public partial class InstituteMainform : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public InstituteMainform()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "select * from institute WHERE code like ?key or institute like ?key order by code asc";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?key", txtsearch.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();

                this.flx.AutoGenerateColumns = false;
                this.flx.DataSource = dt;
                //flxAY
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void InstituteMainform_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 0)
            {
                InstituteAdd frm = new InstituteAdd(this);
                // frm.id = Convert.ToInt32(flx[flx.RowSel, 1]);
                frm.id = 0;
                frm.ShowDialog(this);
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 0)
            {
                InstituteAdd frm = new InstituteAdd(this);
                 frm.id = Convert.ToInt32(flx[flx.RowSel, 1]);
         
                frm.ShowDialog(this);
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flx.Rows.Count > 0)
            {
                if (Box.questionBox("Are you sure you want to delete this row?", "DELETE?"))
                {
                    int id = Convert.ToInt32(flx[flx.RowSel, 1]);
                    Helper.deleteByInt("institute", "instituteID", id);
                    Box.infoBox("Deleted successfully.");
                    LoadData();
                }
            }
            else
            {
                Box.warnBox("No data found!");
            }
        }
    }
}
