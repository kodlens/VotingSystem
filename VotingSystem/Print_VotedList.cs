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
    public partial class Print_VotedList : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public string reportType;


        public Print_VotedList()
        {
            InitializeComponent();
        }

        void loadReport()
        {
           // Helper.getActiveElection();

            // Box.infoBox(Helper.electionName);
            con = Connection.con();
            con.Open();

            if (reportType == "votedlist")
                query = "proc_votedlist";
            else
                query = "proc_notvotedlist";


            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("?velectionName", cmbElectionType.Text);
            cmd.Parameters.AddWithValue("?insCode", cmbInstitute.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            adptr.Fill(dt);
            adptr.Dispose();
            cmd.Dispose();
            con.Close();
            con.Dispose();


            if (reportType == "votedlist")
            {
                Report_VotedList rpt = new Report_VotedList();
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            else
            {
                Report_NotVotedList rpt = new Report_NotVotedList();
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
                

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loadReport();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
               // throw;
            }
        }

        private void Print_VotedList_Load(object sender, EventArgs e)
        {
            Helper.cmbLoadElectionName(cmbElectionType);
            Helper.LoadCmb("select distinct(code) from institute order by code asc",cmbInstitute);
        }
    }
}
