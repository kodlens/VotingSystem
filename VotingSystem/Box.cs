using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    class Box
    {

        public static void infoBox(string msg)
        {
            MessageBox.Show(msg, "INFORMATION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void warnBox(string msg)
        {
            MessageBox.Show(msg, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void errBox(string msg)
        {
            MessageBox.Show(msg, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Boolean questionBox(string msg, string title)
        {
            bool flag;
            DialogResult dg = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        public static Boolean warningQuestionBox(string msg, string title)
        {
            bool flag;
            DialogResult dg = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }


        public static void successSave()
        {
            MessageBox.Show("Data successfully saved!", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void successUpdate()
        {
            MessageBox.Show("Data successfully update!", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void failedSave()
        {
            MessageBox.Show("An error occured. Please contact system administrator.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
