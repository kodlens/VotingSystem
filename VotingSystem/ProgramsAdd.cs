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
    public partial class ProgramsAdd : Form
    {


        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        public int id;

        ProgramsMainform _frm;

        string temp;
        public ProgramsAdd(ProgramsMainform _frm)
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
                query = "SELECT * FROM vw_programs WHERE programID = ?id";
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
                    cmbInstitute.Text = Convert.ToString(dt.Rows[0]["code"]);
                    txtCode.Text = Convert.ToString(dt.Rows[0]["programCode"]);
                    txtDesc.Text = Convert.ToString(dt.Rows[0]["programDesc"]);
                    txtMajor.Text = Convert.ToString(dt.Rows[0]["programMajor"]);

                    temp = Convert.ToString(dt.Rows[0]["programCode"]);
                }

            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
            }
        }

        private void ProgramsAdd_Load(object sender, EventArgs e)
        {

            Helper.LoadCmb("select distinct(code) from institute order by code asc", cmbInstitute);

            try
            {
                if (id > 0)
                {
                    getData();
                }
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                Box.warnBox("Please input Program Code.");
                return;
            }
            if (String.IsNullOrEmpty(txtDesc.Text))
            {
                Box.warnBox("Please input Program Title.");
                return;
            }

            //-----------------Check if exist in the database--------------------//
            if (id > 0)
            {
                if (temp != txtCode.Text)
                {
                    if (Helper.isExistString("programs", "programCode", txtCode.Text))
                    {
                        Box.warnBox("Program Code is already in the database.");
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
                if (Helper.isExistString("programs", "programCode", txtCode.Text))
                {
                    Box.warnBox("Program code is already in the database.");
                    return;
                }

                processSave();
            }
            //----------------------------------------------------------------//

        }

        void processSave()
        {
            int isExecute;
            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                int insid = Helper.returnIDperConnection(con, "institute", "code", cmbInstitute.Text, "instituteID");
                query = @"UPDATE programs SET instituteID=?insID, programCode=?code, programDesc=?desc, programMajor=?pmajor WHERE programID=?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?insID", insid);
                cmd.Parameters.AddWithValue("?code", txtCode.Text.Trim());
                cmd.Parameters.AddWithValue("?desc", txtDesc.Text.Trim());
                cmd.Parameters.AddWithValue("?pmajor", txtMajor.Text.Trim());
                cmd.Parameters.AddWithValue("?id", id);
                isExecute = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (isExecute > 0)
                {
                    Box.infoBox("Data successfully updated!");
                }
                else
                {
                    Box.errBox("Saving failed. Please contact System administrator");
                }
            }
            else
            {
                
                con = Connection.con();
                con.Open();

                int insid = Helper.returnIDperConnection(con, "institute", "code", cmbInstitute.Text, "instituteID");
                query = @"INSERT INTO programs SET instituteID=?insID, programCode=?code, programDesc=?desc, programMajor=?pmajor";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?insID",insid);
                cmd.Parameters.AddWithValue("?code", txtCode.Text.Trim());
                cmd.Parameters.AddWithValue("?desc", txtDesc.Text.Trim());
                cmd.Parameters.AddWithValue("?pmajor", txtMajor.Text.Trim());
                isExecute = cmd.ExecuteNonQuery();

              //  id = Helper.returnLastInsertID(con);
                cmd.Dispose();

                con.Close();
                con.Dispose();
                if (isExecute > 0)
                {
                    Box.infoBox("Data successfully saved!");
                }
                else
                {
                    Box.errBox("Saving failed. Please contact System administrawtor");
                }


            }

            _frm.LoadData();
            this.Close();
        }





    }
}
