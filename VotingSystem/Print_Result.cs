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
    public partial class Print_Result : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

       // public string electName;

        public Print_Result()
        {
            InitializeComponent();
        }

        void loadReport()
        {
            Helper.getActiveElection();

           // Box.infoBox(Helper.electionName);
            con = Connection.con();
            con.Open();
            query = "proc_result";
            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?velectName", Helper.electionName);
            cmd.Parameters.AddWithValue("?insCode", cmbInstitute.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            Report_Result rpt = new Report_Result();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }

        private void Print_Result_Load(object sender, EventArgs e)
        {
           
            try
            {
                //loadReport();
                Helper.LoadCmb("select code from institute order by code asc", cmbInstitute);
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
              //  throw;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            loadReport();
        }
    }
}
