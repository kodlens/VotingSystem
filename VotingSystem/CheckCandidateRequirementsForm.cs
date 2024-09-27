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
    public partial class CheckCandidateRequirementsForm : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public string electionName;
        public int votersID;
        public string fullname;
        public int candidateID;

         

        public CheckCandidateRequirementsForm()
        {
            InitializeComponent();
        }

        private void CheckCandidateRequirementsForm_Load(object sender, EventArgs e)
        {
            lblElectionType.Text = electionName;
            lblName.Text = fullname;

            LoadData();
        }

        public void LoadData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "proc_candidate_file";
                cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("?velecName", electionName);
                cmd.Parameters.AddWithValue("?vvotersid", votersID);
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();


                flx.AutoGenerateColumns = false;
                flx.DataSource = dt;

            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
               // throw;
            }
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 0)
            {
                UploadCandidateDocuments frm = new UploadCandidateDocuments(this);
                frm.reqsetupID = Convert.ToInt32(flx[flx.RowSel, "reqsetupID"]);
                frm.votersID = votersID;
                frm.isUpdate = false;
                frm.id = 0;
                frm.ShowDialog();
            }
            else
            {
                Box.warnBox("No data selected.");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            uploadFileToolStripMenuItem_Click(sender, e);
        }

        private void modifyUploadedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                if(Convert.ToString(flx[flx.RowSel, "upreqID"]) == "")
                {
                    Box.warnBox("No data uploaded.");
                    return;
                }


                UploadCandidateDocuments frm = new UploadCandidateDocuments(this);
                frm.reqsetupID = Convert.ToInt32(flx[flx.RowSel, "reqsetupID"]);
                frm.votersID = votersID;
                frm.isUpdate = true;
                frm.id = Convert.ToInt32(flx[flx.RowSel, "upreqID"]);
                frm.ShowDialog();

            }
            else
            {
                Box.warnBox("No data selected.");
            }
        }

        private void btnUpdateEligible_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for(int i=1; i<flx.Rows.Count; i++)
            {
                // Box.infoBox(flx[i,"nStatus"].ToString());
                list.Add(Convert.ToString(flx[i, "nStatus"]));
            }
            if (list.Contains("INCOMPLETE"))
            {
                Box.warnBox("Some requirements are not accomplish.");
                return;
            }
            else
            {
                markComplete();
                Box.infoBox("Candidate set to complete successfully.");
            }
            
        }



        void markComplete()
        {
            con = Connection.con();
            con.Open();
            query = "UPDATE candidates SET eligible = 1 WHERE candidateID=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", candidateID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();

        }


    }
}
