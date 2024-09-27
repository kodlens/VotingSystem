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
    public partial class CandidateAdd : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;

        CandidateMainform _frm;

        public CandidateAdd(CandidateMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }

        private void CandidateAdd_Load(object sender, EventArgs e)
        {
            Helper.cmbLoadActivePositions(cmbPosition);
            if (id > 0)
            {
                getData();
            }
        }


        void getData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "SELECT * FROM vw_candidates WHERE candidateID = ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (dt.Rows.Count > 0)
                {
                    cmbPosition.Text = Convert.ToString(dt.Rows[0]["position"]);
                    txtDesc.Text = Convert.ToString(dt.Rows[0]["positionDesc"]);
                    txtElectionType.Text = Convert.ToString(dt.Rows[0]["electionName"]);
                    txtVotersID.Text = Convert.ToString(dt.Rows[0]["votersID"]);
                    txtlname.Text = Convert.ToString(dt.Rows[0]["lname"]);
                    txtfname.Text = Convert.ToString(dt.Rows[0]["fname"]);
                    txtmname.Text = Convert.ToString(dt.Rows[0]["mname"]);
                    //cmbInstitute.Text = Convert.ToString(dt.Rows[0]["insCode"]);
                }

            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
            }
        }


        public void setDescAndElectionName()
        {
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM vw_active_position WHERE position=?pos";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?pos", cmbPosition.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtDesc.Text = (Convert.ToString(dr["positionDesc"]));
                txtElectionType.Text = (Convert.ToString(dr["electionName"]));
            }
            dr.Close();
            cmd.Dispose();

            con.Close();
            con.Dispose();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDescAndElectionName();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseVotersByElecType frm = new BrowseVotersByElecType(this);
            frm.elecType = txtElectionType.Text;
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbPosition.Text))
            {
                Box.warnBox("Please select position.");
                return;

            }
            if (String.IsNullOrEmpty(txtVotersID.Text))
            {
                Box.warnBox("Please select position.");
                return;
            }

            if (isExistCandidateAndPosition())
            {
                Box.warnBox("Candidate already added.");
                return;
            }

            processSave();

        }


        void processSave()
        {
            if(id > 0)
            {
                if(update() > 0)
                {
                    Box.infoBox("Successfully updated.");
                }
            }
            else
            {
                if (insert() > 0)
                {
                    Box.infoBox("Successfully Added.");
                }

            }

            _frm.loaddata();
            this.Close();
        }


        int insert()
        {
            int posid = getPositionSetupID();
            int i = 0;
            con = Connection.con();
            con.Open();
            query = "INSERT INTO candidates SET votersID=?votersid, positionSetUpID=?posid";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?votersid", txtVotersID.Text);
            cmd.Parameters.AddWithValue("?posid", posid);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Dispose();
            con.Close();

            return i;
        }


        int update()
        {
            int posid = getPositionSetupID();
            int i = 0;
            con = Connection.con();
            con.Open();
            query = "UPDATE candidates SET votersID=?votersid, positionSetUpID=?posid WHERE candidateID=?canid";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?votersid", txtVotersID.Text);
            cmd.Parameters.AddWithValue("?posid", posid);
            cmd.Parameters.AddWithValue("?canid", id);
            i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Dispose();
            con.Close();

            return i;
        }


        int getPositionSetupID()
        {
            int posid = 0;
            con = Connection.con();
            con.Open();
            query = "select * from vw_active_position where position =?pos";
            cmd = new MySqlCommand(query, con);
          //  cmd.Parameters.AddWithValue("elecName", txtElectionType.Text);
            cmd.Parameters.AddWithValue("?pos", cmbPosition.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                posid = Convert.ToInt32(dr["positionSetupID"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return posid;
        }

        bool isExistCandidateAndPosition()
        {
            int posid = getPositionSetupID();
            bool flag = true;
            con = Connection.con();
            con.Open();
            query = "select * from vw_candidates where votersID = ?votersid and electionName =?elecName";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("votersid", txtVotersID.Text);
            cmd.Parameters.AddWithValue("?elecName", txtElectionType.Text);
          //  cmd.Parameters.AddWithValue("?pos", cmbPosition.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            flag = dr.Read();
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return flag;
        }


    }
}
