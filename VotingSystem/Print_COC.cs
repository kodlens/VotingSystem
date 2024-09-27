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
    public partial class Print_COC : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;

        public Print_COC()
        {
            InitializeComponent();
        }


        void loadReport()
        {
           // Helper.getActiveElection();

            // Box.infoBox(Helper.electionName);
            con = Connection.con();
            con.Open();
            query = "proc_coc";
            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?cid", id);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            Report_COC rpt = new Report_COC();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }

        private void Print_COC_Load(object sender, EventArgs e)
        {
            try
            {
                loadReport();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }
    }
}
