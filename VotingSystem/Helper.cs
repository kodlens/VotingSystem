using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using C1.Win.C1FlexGrid;
using C1.C1Excel;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VotingSystem
{
    class Helper
    {

        //List<String> listControls = new List<String>();

        public static void SetupControlAccess(Form frm, ContextMenuStrip cstrip)
        {
           
            //for Contextmenu Items
            if (cstrip != null)
            {
                foreach (ToolStripItem menuitem in cstrip.Items)
                {
                    //Box.infoBox(menuitem.GetType().ToString());
                    if (menuitem.GetType() == typeof(ToolStripSeparator))
                    {
                        menuitem.Visible = false;
                    }

                    if (menuitem.GetType() == typeof(ToolStripMenuItem))
                    {
                        if (!getAccessControlsList(frm.Name).Contains(menuitem.Name))
                        {
                            //menuitem.Enabled = false;
                            menuitem.Visible = false;
                        }
                    }

                }
            }


            //Controls Items

            //foreach (ToolStripMenuItem btnMenu in frm.Menu)
            //{

            //}
            

            foreach (Control ctrl in frm.Controls)
            {
     
                //Box.infoBox(ctrl.Name);

                if (ctrl.GetType() == typeof(ToolStrip))
                {
                    foreach (ToolStripItem item in ((ToolStrip)ctrl).Items)
                    {

                        if (item.GetType() == typeof(ToolStripSplitButton))
                        {
                            foreach (ToolStripMenuItem item2 in ((ToolStripSplitButton)item).DropDownItems)
                            {
                               //Box.infoBox(item2.Name);
                                if (!getAccessControlsList(frm.Name).Contains(item2.Name))
                            {
                                item2.Enabled = false;
                                //item2.Visible = false;
                            }
                            }
                        }
                      
                        if (!getAccessControlsList(frm.Name).Contains(item.Name))
                        {
                            item.Enabled = false;
                            //item.Visible = false;
                        }


                    }
                }


            }
        }


        private static Control GetControlByName(string controlName, Control.ControlCollection parent)
        {
            Control c = null;
            foreach (Control ctrl in parent)
            {
                if (ctrl.Name.Equals(controlName))
                {
                    c = ctrl;
                    return c;
                }

                if (ctrl.GetType() == typeof(ToolStrip))
                {
                    foreach (ToolStripItem item in ((ToolStrip)ctrl).Items)
                    {
                        if (item.Name.Equals(controlName))
                        {
                            switch (item.GetType().Name)
                            {
                                case "ToolStripComboBox":
                                    c = ((ToolStripComboBox)item).Control;
                                    break;
                                case "ToolStripTextBox":
                                    c = ((ToolStripTextBox)item).Control;
                                    break;
                            }
                            if (c != null)
                            {
                                break;
                            }
                        }
                    }
                }
                if (c == null)
                    c = GetControlByName(controlName, ctrl.Controls);
                else
                    break;
            }
            return c;
        }



        //public static IEnumerable<Control> GetControlHierarchy(Control root)
        //{
        //    var queue = new Queue<Control>();

        //    queue.Enqueue(root);

        //    do
        //    {
        //        var control = queue.Dequeue();

        //        yield return control;

        //        foreach (var child in control.Controls.OfType<Control>())
        //            queue.Enqueue(child);

        //    } while (queue.Count > 0);

        //}


        static List<string> getAccessControlsList(string className)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            string query;

            var retList = new List<string>();

            con = Connection.con();
            con.Open();
            query = "select * from vw_access where positionID=?posid and className=?classname";
            cmd = new MySqlCommand(query, con);
           // cmd.Parameters.AddWithValue("?posid", Properties.Settings.Default.positionID);
            cmd.Parameters.AddWithValue("?classname", className);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                retList.Add(Convert.ToString(dr["controlName"]));
            }
            dr.Close();
            con.Close();
            con.Dispose();

            return retList;
        }


        public static void LoadCmb(string query, ComboBox cmb)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            // string query;
            cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr[0]));
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public static void LoadCmbPerCon(MySqlConnection con, string query, ComboBox cmb)
        {
            //MySqlConnection con;
            MySqlCommand cmd;
            // string query;
            cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr[0]));
            }
            dr.Close();
            cmd.Dispose();
           // con.Close();
           // con.Dispose();
        }



        public static bool deleteByInt(string tblename, string colname, int id)
        {
            //bool flag = false;
            MySqlConnection con;
            MySqlCommand cmd;
            // string query;

            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand("DELETE FROM " + tblename + " WHERE " + colname + " = ?id", con);
            cmd.Parameters.AddWithValue("?id", id);
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool deleteByString(string tblename, string colname, string strID)
        {
            //bool flag = false;
            MySqlConnection con;
            MySqlCommand cmd;
            // string query;

            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand("DELETE FROM " + tblename + " WHERE " + colname + " = ?id", con);
            cmd.Parameters.AddWithValue("?id", strID);
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool isExistString(string tblname, string colname, string key)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM " + tblname + " WHERE " + colname + " = ?key", con);
            cmd.Parameters.AddWithValue("?key", key);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            bool flag = dr.Read();
            dr.Close();
            cmd.Dispose();
            con.Close();
            return flag;
        }

        public static bool isExistInt(string tblname, string colname, int key)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM " + tblname + " WHERE " + colname + " = ?key", con);
            cmd.Parameters.AddWithValue("?key", key);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            bool flag = dr.Read();
            dr.Close();
            cmd.Dispose();
            con.Close();
            return flag;
        }

        public static void txtInteger(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void txtDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static int returnID(string tblname, string colname, string key, string colid)
        {
            int flag = 0;
            MySqlConnection con;
            MySqlCommand cmd;
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM " + tblname + " WHERE " + colname + " = ?key", con);
            cmd.Parameters.AddWithValue("?key", key);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                flag = Convert.ToInt32(dr[colid]);
            }
           
            dr.Close();
            cmd.Dispose();
            con.Close();
            return flag;
        }

        public static int returnIDperConnection(MySqlConnection con, string tblname, string colname, string key, string colid)
        {
            int flag = 0;
            //MySqlConnection con;
            MySqlCommand cmd;
            //con = Connection.con();
            //con.Open();
            cmd = new MySqlCommand("SELECT * FROM " + tblname + " WHERE " + colname + " = ?key", con);
            cmd.Parameters.AddWithValue("?key", key);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                flag = Convert.ToInt32(dr[colid]);
            }

            dr.Close();
            cmd.Dispose();
           // con.Close();
            return flag;
        }

        public static void setAutoComplete(TextBox textbox, string query, string colname)
        {
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader dr;
            conn = Connection.con();
            conn.Open();
            //string query = "SELECT " + colname + " FROM " + tablename + " GROUP BY " + groupby + "";
            cmd = new MySqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                coll.Add(dr[colname].ToString());
            }
            conn.Close();
            dr.Close();
            textbox.AutoCompleteCustomSource = coll;
        }

        public static int returnLastInsertID(MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand("select last_insert_id()", con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }


        public static void FirstDayOfMonth_AddMethod(DateTime value, DateTimePicker dt)
        {
            dt.Value = value.Date.AddDays(1 - value.Day);
        }
        public static void LastDayOfMonth_AddMethod(DateTime value, DateTimePicker dt)
        {
            dt.Value = (value.Date.AddDays(1 - value.Day)).AddMonths(1).AddDays(-1);
        }

        public static void NumRow(C1FlexGrid grid)
        {
            for (int rowno = 1; rowno <= grid.Rows.Count - 1; rowno++)
            {
                grid[rowno, 0] = rowno.ToString();
            }
        }

        public static void LoadSheet(C1FlexGrid _flx, XLSheet xsheet, int noCol)
        {
            int row;
            int col;

            XLCell cell;

            for (row = 1; row < xsheet.Rows.Count; row++)
            {
                _flx.Rows.Add();
                for (col = 0; col < noCol; col++)
                {
                    if (row <= xsheet.Rows.Count - 1)
                    {
                        if (xsheet.GetCell(row, col) != null)
                        {
                            cell = xsheet.GetCell(row, col);
                            _flx[row, col + 1] = Convert.ToString(cell.Value);
                        }
                        _flx[row, 0] = Convert.ToString(row);
                        //_flx.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;

                    }
                    Application.DoEvents();
                }

            }

            Helper.NumRow(_flx);
            //Application.DoEvents();
        }





        public static int getIDFlexGrid(C1FlexGrid flx)
        {
            return Convert.ToInt32(flx[flx.RowSel, 1]);
        }



        public static void getCurrentAY(ComboBox cmb)
        {
            MySqlConnection con = null;
            MySqlCommand cmd;
            string query;
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM ay WHERE active = 1";
            cmd = new MySqlCommand(query, con);
            //cmd.Parameters.AddWithValue("?id", id);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Text = Convert.ToString(dr["ay"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();

        }

        public static void cmbLoadAY(ComboBox cmb)
        {
            MySqlConnection con = null;
            MySqlCommand cmd;
            string query;
            con = Connection.con();
            con.Open();
            query = "SELECT DISTINCT(ay) FROM ay";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["ay"]));
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public static void cmbLoadElectionName(ComboBox cmb)
        {
            MySqlConnection con = null;
            MySqlCommand cmd;
            string query;
            con = Connection.con();
            con.Open();
            query = "SELECT DISTINCT(electionName) FROM election_setup order by electionName asc";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["electionName"]));
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        public static void cmbLoadActivePositions(ComboBox cmb)
        {
            MySqlConnection con = null;
            MySqlCommand cmd;
            string query;
            con = Connection.con();
            con.Open();
            query = "SELECT DISTINCT(position) FROM vw_active_position order by orderNo asc";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["position"]));
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public static void getActiveElection()
        {
            MySqlConnection con = null;
            MySqlCommand cmd;
            string query;
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM vw_active_election";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                electionSetUpID = Convert.ToInt32(dr["electionSetUpID"]);
                electionName = Convert.ToString(dr["electionName"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public static int electionSetUpID { set; get; }
        public static string electionName { set; get; }



        public static int returnAYID(ComboBox cmb)
        {
           return returnID("ay", "ay", cmb.Text, "ayID");
        }

        public static int returnElectionSetupID(ComboBox cmb)
        {
            return returnID("election_setup", "electionName", cmb.Text, "electionSetUpID");
        }

        public static int returnAYIDperConnection(MySqlConnection con, ComboBox cmb)
        {
            return returnIDperConnection(con, "ay", "ay", cmb.Text, "ayID");
        }


        public static void getProgramByInstitute(ComboBox cmbIns, ComboBox programCode)
        {
            programCode.Items.Clear();
            MySqlConnection con = null;
            MySqlCommand cmd;
            string query;
            con = Connection.con();
            con.Open();
            query = "SELECT * FROM vw_programs WHERE code=?code";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?code", cmbIns.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                programCode.Items.Add(Convert.ToString(dr["programCode"])); 
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }
      


    }
}
