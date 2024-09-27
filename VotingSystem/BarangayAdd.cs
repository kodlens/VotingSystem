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
    public partial class BarangayAdd : Form
    {


        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;


        BarangayMainform _frm;

        string temp;



        public BarangayAdd(BarangayMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }


        void getData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "SELECT * FROM vw_brgy WHERE brgyID = ?id";
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
                    cmbProvince.Text = Convert.ToString(dt.Rows[0]["province"]);
                    cmbCity.Text = Convert.ToString(dt.Rows[0]["cityTown"]);
                    txtbrgy.Text = Convert.ToString(dt.Rows[0]["brgy"]);
                    temp = Convert.ToString(dt.Rows[0]["brgy"]);


                }

            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbProvince.Text))
            {
                Box.warnBox("Please select province.");
                return;
            }

            if (String.IsNullOrEmpty(cmbCity.Text))
            {
                Box.warnBox("Please select City.");
                return;
            }
            if (String.IsNullOrEmpty(txtbrgy.Text))
            {
                Box.warnBox("Barangay is required.");
                return;
            }

            if (temp != txtbrgy.Text)
            {
                if (isExistbrgy())
                {
                    Box.warnBox("Barangay already in the list.");
                    return;
                }
            }

            processSave();
        }

        bool isExistbrgy()
        {
            try
            {
                bool flag = false;
                con = Connection.con();
                con.Open();
                query = "select * from vw_brgy where cityTown=?cty and brgy=?brgy";
                cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                flag = dr.Read();
                dr.Close();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                return flag;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }


        void processSave()
        {
            try
            {

                if (id > 0)
                {
                    //update
                    con = Connection.con();
                    con.Open();

                    int cityID = Helper.returnIDperConnection(con, "city_town", "cityTown", cmbCity.Text.Trim(), "cityTownID");

                    query = @"UPDATE brgy SET cityTownID = ?cid, brgy=?brgy WHERE brgyID=?id";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?cid", cityID);
                    cmd.Parameters.AddWithValue("?brgy", txtbrgy.Text);
                    cmd.Parameters.AddWithValue("?id", id);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        Box.successUpdate();
                    }
                    else
                    {
                        Box.failedSave();
                    }
                    cmd.Dispose();
                    con.Close();

                }
                else
                {
                    //insert
                    con = Connection.con();
                    con.Open();

                    int cityID = Helper.returnIDperConnection(con, "city_town", "cityTown", cmbCity.Text.Trim(), "cityTownID");

                    query = @"INSERT INTO brgy (cityTownID, brgy) VALUES (?cid, ?brgy)";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?cid", cityID);
                    cmd.Parameters.AddWithValue("?brgy", txtbrgy.Text);

                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        Box.successSave();
                    }
                    else
                    {
                        Box.errBox("An error occured. Please contact administrator.");
                    }
                    cmd.Dispose();
                    con.Close();
                    con.Dispose();

                }

                _frm.LoadData();
                this.Close();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }
        }

        private void BarangayAdd_Load(object sender, EventArgs e)
        {
            Helper.LoadCmb("SELECT distinct(province) FROM vw_citytown", cmbProvince);


            if (id > 0)
            {
                getData();
            }
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCity.SelectedIndex = -1;
            Helper.LoadCmb("SELECT distinct(cityTown) FROM vw_citytown WHERE province= '" + cmbProvince.Text.Trim().Replace("'", "'") + "'", cmbCity);
        }


    }
}
