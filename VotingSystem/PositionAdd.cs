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
    public partial class PositionAdd : Form
    {

        MySqlCommand cmd;
        MySqlConnection con;
        string query;


        public int id;
        string temp;


        PositionMainform _frm;


        public PositionAdd(PositionMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPos.Text.Trim()))
            {
                Box.warnBox("Please input position.");
                return;
            }

            if (temp != txtPos.Text)
            {
                if (Helper.isExistString("nposition", "position", txtPos.Text.Trim()))
                {
                    Box.warnBox("Position already in list.");
                    txtPos.Text = "";
                    txtPos.Focus();
                    return;
                }
            }

            try
            {
                processSave();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);

                //   throw;
            }
        }

        private void PositionAdd_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                getData();
            }
        }

        void getData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from nposition where positionID=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPos.Text = Convert.ToString(dr["position"]);
                temp = Convert.ToString(dr["position"]);

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        void processSave()
        {
            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                query = @"UPDATE nposition SET position=?pos WHERE positionID=?posid";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos", txtPos.Text.Trim());
                cmd.Parameters.AddWithValue("?posid", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.successUpdate();

                    _frm.LoadData();

                }
                else
                {
                    Box.failedSave();
                }


            }
            else
            {
                con = Connection.con();
                con.Open();
                query = @"INSERT INTO nposition (position) VALUES 
                        (?pos)";

                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pos", txtPos.Text.Trim());
                int n = cmd.ExecuteNonQuery();
                id = Helper.returnLastInsertID(con);
                // btnSave.Text = "Update";
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.successSave();

                    _frm.LoadData();
                }
                else
                {
                    Box.failedSave();
                }

            }
        }

        private void btnNewClear_Click(object sender, EventArgs e)
        {

            txtPos.Text = "";
            id = 0;
            txtPos.Focus();
        }
    }
}
