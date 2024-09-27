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
    public partial class ElectionSetUpAdd : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        string temp;

        public int id;

        ElectionSetup _frm;

        byte active;



        public ElectionSetUpAdd(ElectionSetup _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           


            if (String.IsNullOrEmpty(txtElectionName.Text))
            {
                Box.warnBox("Please input election code.");
                return;
            }

            if (id > 0)
            {
                if (temp.ToLower() != txtElectionName.Text.ToLower())
                {
                    if (Helper.isExistString("election_setup", "electionName", txtElectionName.Text))
                    {
                        Box.warnBox("Election name is already in the database. hala");
                        return;
                    }
                    else
                    {
                        processSave();
                    }
                }
                else
                {
                    processSave();
                }
            }
            else
            {
                if (Helper.isExistString("election_setup", "electionName", txtElectionName.Text))
                {
                    Box.warnBox("Election name is already in the database.");
                    return;
                }

                processSave();
            }
        }


        void getData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from vw_election_setup where electionSetUpID=?id";
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
                txtElectionName.Text = Convert.ToString(dt.Rows[0]["electionName"]);
                temp = Convert.ToString(dt.Rows[0]["electionName"]);
                cmbAY.Text = Convert.ToString(dt.Rows[0]["ay"]);

                //if (Convert.ToByte(dt.Rows[0]["active"]) == 1)
                //{  checkActive.Checked = true; }
                //else { checkActive.Checked = false; }
            }
        }



        void processSave()
        {

           //  active = checkActive.Checked ? active = 1 : active = 0;

            

            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                int ayid = Helper.returnIDperConnection(con, "ay", "ay", cmbAY.Text, "ayID");
                query = @"UPDATE election_setup SET electionName=?electionName, ayID=?ayid, active=?actv, dateEvent=?dtevent
                        WHERE electionSetUpID = ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?electionName", txtElectionName.Text);
                cmd.Parameters.AddWithValue("?ayid", ayid);
                cmd.Parameters.AddWithValue("?actv", active);
                cmd.Parameters.AddWithValue("?dtevent", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("?id", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.infoBox("Election name successfully updated.");
                }
                else
                {
                    Box.errBox("An error occured. Please contact administrator.");
                }


            }
            else
            {
                con = Connection.con();
                con.Open();
                int ayid = Helper.returnIDperConnection(con, "ay", "ay", cmbAY.Text, "ayID");
                query = @"INSERT INTO election_setup (electionName, ayID, active, dateEvent) VALUES
                        (?electionName, ?ayid, ?actv, ?dtevent)";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?electionName", txtElectionName.Text);
                cmd.Parameters.AddWithValue("?ayid", ayid);
                cmd.Parameters.AddWithValue("?actv", active);
                cmd.Parameters.AddWithValue("?dtevent", dateTimePicker1.Text);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();

                //id = Helper.returnLastInsertID(con);
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.infoBox("Election name successfully saved!.");
                }
                else
                {
                    Box.errBox("An error occured. Please contact administrator.");
                }

            }


            _frm.LoadData();
            this.Close();
        }

        private void ElectionSetUpAdd_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.cmbLoadAY(cmbAY);
                if (id > 0)
                {
                    getData();
                }
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
               // throw;
            }
        }
        


    }
}
