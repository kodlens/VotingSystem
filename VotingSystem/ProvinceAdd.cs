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
    public partial class ProvinceAdd : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;

        ProvinceMainform _frm;


        public bool isFromProvMainForm; //if the call is from ProvinceMainform

        public ProvinceAdd()
        {
            InitializeComponent();
        }

        public ProvinceAdd(ProvinceMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }


        void processSave()
        {
            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                query = "UPDATE province SET province=?prov WHERE provinceID=?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?prov", txtProvince.Text.Trim());
                cmd.Parameters.AddWithValue("?id", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.successUpdate();
                    if (isFromProvMainForm) { _frm.loadData(); }

                    this.Close();
                }
                else
                {
                    Box.errBox("An error occured during saving the data. Please contact administrator.");
                }
            }
            else
            {
                con = Connection.con();
                con.Open();
                query = "INSERT INTO province (province) VALUES (?prov)";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?prov", txtProvince.Text.Trim());
                int n = cmd.ExecuteNonQuery();
                //id = Helper.returnLastInsertID(con);

                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.successSave();
                    if (isFromProvMainForm) { _frm.loadData(); }
                    // btnClear_Click(sender, e);
                    clear();
                }
                else
                {
                    Box.errBox("An error occured during saving the data. Please contact administrator.");
                }

                // btnSave.Text = n > 0 ? "UPDATE" : "SAVE";

            }

            //be sure nothing will execute here....
            //----------------------END OF CODE---------------------//
            //--------------------NOTHING FOLLOWS-----------------//
        }



        private void btnSave_Click(object sender, EventArgs e)
        { if (String.IsNullOrEmpty(txtProvince.Text))
            {
                Box.warnBox("Please input province.");
                return;
            }

            if(id == 0)
            {
                if (Helper.isExistString("province", "province", txtProvince.Text))
                {
                    Box.warnBox("Inputted province already existed.");
                    txtProvince.Text = "";
                    txtProvince.Focus();
                    return;
                }
            }

            processSave();

        }


        void getData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from province where provinceID=?id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?id", id);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtProvince.Text = Convert.ToString(dr["province"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        void clear()
        {
            id = 0;
            txtProvince.Text = "";
            btnSave.Text = "SAVE";
            txtProvince.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ProvinceAdd_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                getData();
                btnSave.Text = "UPDATE";
            }
        }
    }
}
