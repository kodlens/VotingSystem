using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VotingSystem
{
    class Connection
    {

        public static MySqlConnection con()
        {
                string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + "/config.txt");
                return new MySqlConnection("server=localhost;database=voting_sys;user=root;password=''");
                //return new MySqlConnection("server=localhost;database=voting_sys;user=root;password=''");  

            //catch (Exception er)
            //{
            //    Box.infoBox("Connecting to database error. Please check your connection to server or you may contact system administrator.");
            //    // throw;
            //    return null;
            //}

        }

    }
}
