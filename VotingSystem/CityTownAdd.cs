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
    public partial class CityTownAdd : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;

        CityTownMainform _frm;


        public CityTownAdd(CityTownMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;

            this.txtzip.KeyPress += Helper.txtInteger;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Helper.LoadCmb("select distinct(province) from province order by province asc", cmbProv);
        }

        private void CityTownAdd_Load(object sender, EventArgs e)
        {
            Helper.LoadCmb("select distinct(province) from province order by province asc", cmbProv);
            if (id > 0)
            {
                getData();
                btnSave.Text = "Update";
            }
        }

        void getData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from vw_citytown where cityTownID=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProv.Text = Convert.ToString(dr["province"]);
                txtCityTown.Text = Convert.ToString(dr["cityTown"]);
                txtzip.Text = Convert.ToString(dr["zipcode"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }



        bool isExistProvAndCity()
        {
            bool flag = false;

            con = Connection.con();
            con.Open();
            query = "select * from vw_citytown where province = ?prov and cityTown = ?city";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?prov", cmbProv.Text);
            cmd.Parameters.AddWithValue("?city", txtCityTown.Text);
            MySqlDataReader dr;

            dr = cmd.ExecuteReader();
            flag = dr.Read();
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return flag;
        }


        void clear()
        {
            cmbProv.Text = "";
            txtCityTown.Text = "";
            txtzip.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbProv.Text))
            {
                Box.warnBox("Please select province.");
                return;
            }

            if (String.IsNullOrEmpty(txtCityTown.Text))
            {
                Box.warnBox("Please input City/Town.");
                return;
            }

            if (id == 0)
            {
                if (isExistProvAndCity())
                {
                    Box.warnBox("Given City/Town already used.");
                    txtCityTown.Text = "";
                    txtCityTown.Focus();
                    return;
                }
            }


            processSave();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }


        void processSave()
        {

            int provID = 0;

            provID = Helper.returnID("province", "province", cmbProv.Text, "provinceID");




            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                query = @"UPDATE city_town SET provinceID = ?provID, cityTown=?city, zipcode=?zip WHERE cityTownID=?id ";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?provID", provID);
                cmd.Parameters.AddWithValue("?city", txtCityTown.Text.Trim());
                cmd.Parameters.AddWithValue("?zip", txtzip.Text.Trim());
                cmd.Parameters.AddWithValue("?id", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.successSave();
                    clear();
                    _frm.loaddata();
                    txtCityTown.Focus();
                    this.Close();
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
                query = @"INSERT INTO city_town (provinceID, cityTown, zipcode) VALUES 
                        (?provID, ?city, ?zip)";

                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?provID", provID);
                cmd.Parameters.AddWithValue("?city", txtCityTown.Text.Trim());
                cmd.Parameters.AddWithValue("?zip", txtzip.Text.Trim());
                int n = cmd.ExecuteNonQuery();
                //id = Helper.returnLastInsertID(con);
                // btnSave.Text = "Update";
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.successSave();
                    clear();
                    _frm.loaddata();
                }
                else
                {
                    Box.failedSave();
                }

            }



        }


    }
}
