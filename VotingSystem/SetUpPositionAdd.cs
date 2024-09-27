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
    public partial class SetUpPositionAdd : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string query;


        public int id;

        string temp;

        SetupPositionMainform _frm;

        public SetUpPositionAdd(SetupPositionMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;


            txtorder.KeyPress += Helper.txtInteger;
        }

        void getData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from vw_position where positionSetUpID=?id";
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
                cmbElection.Text = Convert.ToString(dt.Rows[0]["electionName"]);
                temp = Convert.ToString(dt.Rows[0]["position"]);
                txtPosition.Text = Convert.ToString(dt.Rows[0]["position"]);
                txtDescription.Text = Convert.ToString(dt.Rows[0]["positionDesc"]);
                txtorder.Text = Convert.ToString(dt.Rows[0]["orderNo"]);
                txtNoVotes.Text = Convert.ToString(dt.Rows[0]["noOfVote"]);
                cmbCanvote.Text = Convert.ToString(dt.Rows[0]["canVote"]);
                //  txtAlias.Text = Convert.ToString(dt.Rows[0]["alias"]);
                // txtInsDesc.Text = Convert.ToString(dt.Rows[0]["insDesc"]);
                //active = Convert.ToByte(dt.Rows[0]["active"]);
                //if (active == 1) { checkActive.Checked = true; } else { checkActive.Checked = false; }
            }
        }

        private void SetUpPositionAdd_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.LoadCmb("select distinct(electionName) from election_setup order by electionName asc", cmbElection);

                if (id > 0)
                {
                    getData();
                }
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }


        void processSave()
        {

           // active = checkActive.Checked ? active = 1 : active = 0;

            if (id > 0)
            {
                con = Connection.con();
                con.Open();

                int eID = Helper.returnIDperConnection(con, "election_setup", "electionName", cmbElection.Text, "electionSetUpID");


                query = @"UPDATE position_setup SET electionSetUpID=?eID,  position=?pos, positionDesc=?desc , orderNo=?ono, 
                        noOfVote=?nvote, canVote=?cvote
                        WHERE positionSetUpID = ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?eID", eID);
                cmd.Parameters.AddWithValue("?pos", txtPosition.Text);

                // cmd.Parameters.AddWithValue("?nDesc", txtInsDesc.Text);
                cmd.Parameters.AddWithValue("?desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("?ono", txtorder.Text.Trim());
                cmd.Parameters.AddWithValue("?nvote", txtNoVotes.Text.Trim());
                //  cmd.Parameters.AddWithValue("?alias", txtAlias.Text.Trim().Replace(" ", ""));
                cmd.Parameters.AddWithValue("?cvote", cmbCanvote.Text.Trim());
                cmd.Parameters.AddWithValue("?id", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.infoBox("Position successfully updated.");
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

                int eID = Helper.returnIDperConnection(con, "election_setup", "electionName", cmbElection.Text, "electionSetUpID");


                query = @"INSERT INTO position_setup SET electionSetUpID=?eID,  position=?pos, positionDesc=?desc, 
                        orderNo=?ono, noOfVote=?nvote, canVote=?cvote";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?eID", eID);
                cmd.Parameters.AddWithValue("?pos", txtPosition.Text);

                // cmd.Parameters.AddWithValue("?nDesc", txtInsDesc.Text);
                cmd.Parameters.AddWithValue("?desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("?ono", txtorder.Text.Trim());
                cmd.Parameters.AddWithValue("?nvote", txtNoVotes.Text.Trim());
                cmd.Parameters.AddWithValue("?cvote", cmbCanvote.Text.Trim());
                //   cmd.Parameters.AddWithValue("?alias", txtAlias.Text.Trim().Replace(" ",""));
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.infoBox("Position successfully saved.");
                }
                else
                {
                    Box.errBox("An error occured. Please contact administrator.");
                }

            }


            _frm.LoadData();
            //this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(cmbElection.Text))
            {
                Box.warnBox("Please select election.");
                return;
            }

            if (String.IsNullOrEmpty(txtPosition.Text))
            {
                Box.warnBox("Please input Position.");
                return;
            }

            if (String.IsNullOrEmpty(cmbCanvote.Text))
            {
                Box.warnBox("Please select to vote.");
                cmbCanvote.Focus();
                return;
            }

            //if(Helper.isExistString("position_setup","alias", txtAlias.Text.Trim().Replace(" ","")))
            //{
            //    Box.warnBox("Alias already in the database. Please use another alias.");
            //    txtAlias.Text = "";
            //    txtAlias.Focus();
            //    return;
            //}

            if (id > 0)
            {
                if (temp != txtPosition.Text)
                {
                    if (ifExistPosition())
                    {
                        Box.warnBox("Position is already in the database.");
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
                if (ifExistPosition())
                {
                    Box.warnBox("Position is already in the database.");
                    return;
                }
             

                processSave();
            }



            this.Close();

        }



        bool ifExistPosition()
        {
            bool flag = true;
            try
            {

               // using(MySqlConnection con = new Mysqlc)
                con = Connection.con();
                con.Open();
                query = "select * from vw_position where position=?pos and electionName=?eName";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos", txtPosition.Text);
                cmd.Parameters.AddWithValue("?eName", cmbElection.Text);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                flag = dr.Read();
                dr.Close();
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }

            return flag;
        }
    }
}
