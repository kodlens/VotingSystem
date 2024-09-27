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
    public partial class VotersUploaderForm : Form
    {
        MySqlConnection con;
        MySqlCommand cmd, cmd1;
        MySqlDataReader dr;
        string query;




        public VotersUploaderForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenDialog();
            }
            catch (Exception er)
            {
                Box.errBox(er.Message + "\nPlease check also for null/empty fields.");
            }
        }

        private void toolBtnClear_Click(object sender, EventArgs e)
        {
            flx.Rows.Count = flx.Rows.Fixed;
            flx.Rows.Count = 1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.flx.Rows.Count < 2)
            {
                Box.warnBox("No data loaded.");
                return;
            }

            int counterUploaded = 0;
            int counterFailed = 0;

            con = Connection.con();
            con.Open();

            query = @"INSERT INTO voters SET agencyNo=?agencyNo, lname=?lname, fname=?fname,
                        mname=?mname, gender=?gender, programID=?programID, yearlvl=?yearlvl, email=?email,
                        contactNo=?contactNo, user=?user, pwd=?pwd, instituteID=?insid";
            cmd = new MySqlCommand(query, con);

            int maxrow = this.flx.Rows.Count;
            int row = 1;
            for (int r = 1; r < maxrow; r++)
            {
                string agency_no = Convert.ToString(flx[row, "agencyNo"]);
                string lastname = Convert.ToString(flx[row, "lname"]);
                string firstname = Convert.ToString(flx[row, "fname"]);
                string middlename = Convert.ToString(flx[row, "mname"]);
                string gender = Convert.ToString(flx[row, "gender"]);
             
                string yearlvl = Convert.ToString(flx[row, "yearlvl"]);

                string program_id = Convert.ToString(flx[row, "programID"]);
                string email = Convert.ToString(flx[row, "email"]);
                string contactNo = Convert.ToString(flx[row, "contactNo"]);
                string user = Convert.ToString(flx[row, "user"]);
                string password = Convert.ToString(flx[row, "pwd"]);
                string institute_id = Convert.ToString(flx[row, "instituteID"]);

             
                cmd.Parameters.AddWithValue("?agencyNo", agency_no);
                cmd.Parameters.AddWithValue("?lname", lastname);
                cmd.Parameters.AddWithValue("?fname", firstname);
                cmd.Parameters.AddWithValue("?mname", middlename);
                cmd.Parameters.AddWithValue("?gender", gender);
                cmd.Parameters.AddWithValue("?programID", program_id);
                cmd.Parameters.AddWithValue("?yearlvl", yearlvl);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?contactNo", contactNo);
                cmd.Parameters.AddWithValue("?user", user);
                cmd.Parameters.AddWithValue("?pwd", password);
                cmd.Parameters.AddWithValue("?insid", institute_id);
                int insert = 0;
                insert = cmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    //flx.Select(row, 1, true);
                    if (flx.Rows.Count > 1)
                    {
                        flx.Rows.Remove(row);
                    }
                    counterUploaded++;
                }
                else
                {
                    counterFailed++;
                    row++;
                }
                cmd.Parameters.Clear();
                Application.DoEvents();
                lblNoRows.Text = Convert.ToString("No. of Rows Uploaded : " + counterUploaded);



            }//loop
            cmd.Dispose();

            con.Close();
            con.Dispose();
            Box.infoBox("Uploaded " + counterUploaded + " successfully! \nNo. of failed upload : " + counterFailed);


        }

        private void toolBtnCheckID_Click(object sender, EventArgs e)
        {
            con = Connection.con();
            con.Open();



            for (int row = 1; row < this.flx.Rows.Count; row++)
            {
                string program_code = Convert.ToString(flx[row, "program_code"]);
                flx[row, "instituteID"] = Convert.ToString(getInstituteID(con, program_code));
                flx[row, "programID"] = Convert.ToString(getProgramID(con, program_code));
            }

            con.Close();
            con.Dispose();

               
        }

        private void OpenDialog()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Excel Files|*.xls;*.xlsx|XLS|*.xls|XLSX|*.xlsx";
            dlg.Title = "Browse Excel File";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            c1XLBook1.Clear();
            c1XLBook1.Load(dlg.FileName);
            Helper.LoadSheet(flx, c1XLBook1.Sheets[Convert.ToInt32(sheetNo.Value)], 13);
            lblNoRows.Text = "Total Rows Loaded : " + Convert.ToString(flx.Rows.Count - 1);
            Box.infoBox("Excel Loaded!");

        }



        private int getInstituteID(MySqlConnection con, string code)
        {
            int insid = 0;
            cmd = new MySqlCommand("select * from programs where programCode = ?code", con);
            cmd.Parameters.AddWithValue("?code", code);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                insid = Convert.ToInt32(dr["instituteID"]);
            }
            dr.Close();
            cmd.Dispose();
            return insid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flx.Rows.Count > 1)
            {
                flx.Rows.Remove(1);
            }
           
        }

        private int getProgramID(MySqlConnection con, string code)
        {
            int pid = 0;
            cmd = new MySqlCommand("select * from programs where programCode = ?code", con);
            cmd.Parameters.AddWithValue("?code", code);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pid = Convert.ToInt32(dr["programID"]);
            }
            dr.Close();
            cmd.Dispose();
            return pid;
        }


    }
}
