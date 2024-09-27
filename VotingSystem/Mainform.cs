using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Mainform : Form
    {
        Login login;
        public Mainform(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            VotersMainform frm = new VotersMainform();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElectionSetup frm = new ElectionSetup();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetupPositionMainform frm = new SetupPositionMainform();
            frm.ShowDialog();
        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            ProgramsMainform frm = new ProgramsMainform();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProvinceMainform frm = new ProvinceMainform();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CityTownMainform frm = new CityTownMainform();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BarangayMainform frm = new BarangayMainform();
            frm.ShowDialog();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            lblName.Text = (Properties.Settings.Default.lname + ", " + Properties.Settings.Default.fname + " " + Properties.Settings.Default.mname).Trim();
            lblPosition.Text = Properties.Settings.Default.position;

            if(lblPosition.Text != "ADMINISTRATOR")
            {
                accountToolStripMenuItem.Visible = false;
                administrativeToolStripMenuItem.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RequirementSetupMainform frm = new RequirementSetupMainform();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CandidateMainform frm = new CandidateMainform();
            frm.ShowDialog();
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.Exit();
            this.Hide();
            login.Show();
        }

        private void provinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinceMainform frm = new ProvinceMainform();
            frm.ShowDialog();
        }

        private void cityTownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityTownMainform frm = new CityTownMainform();
            frm.ShowDialog();
        }

        private void barangayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarangayMainform frm = new BarangayMainform();
            frm.ShowDialog();
        }

        private void programsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramsMainform frm = new ProgramsMainform();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Box.questionBox("Are you sure you want to logout?", "LOGOUT?"))
            {
                login.Show();
                this.Hide();
            }
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Print_Result frm = new Print_Result();
            frm.ShowDialog();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountMainform frm = new AccountMainform();
            frm.ShowDialog();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PositionMainform frm = new PositionMainform();
            frm.ShowDialog();
        }

        private void viewVotedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print_VotedList frm = new Print_VotedList();
            frm.reportType = "votedlist";
            frm.ShowDialog();
        }

        private void viewNotVotedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print_VotedList frm = new Print_VotedList();
            frm.reportType = "";
            frm.ShowDialog();
        }

        private void instituteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstituteMainform frm = new InstituteMainform();
            frm.ShowDialog();
        }
    }
}
