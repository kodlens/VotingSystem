namespace VotingSystem
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityTownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instituteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVotedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNotVotedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblPosition = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.administrativeToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.User_Group_icon16x16;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // administrativeToolStripMenuItem
            // 
            this.administrativeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provinceToolStripMenuItem,
            this.cityTownToolStripMenuItem,
            this.barangayToolStripMenuItem,
            this.programsToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.instituteToolStripMenuItem});
            this.administrativeToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.Settings_icon16x16;
            this.administrativeToolStripMenuItem.Name = "administrativeToolStripMenuItem";
            this.administrativeToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.administrativeToolStripMenuItem.Text = "Administrative";
            // 
            // provinceToolStripMenuItem
            // 
            this.provinceToolStripMenuItem.Name = "provinceToolStripMenuItem";
            this.provinceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.provinceToolStripMenuItem.Text = "Province";
            this.provinceToolStripMenuItem.Click += new System.EventHandler(this.provinceToolStripMenuItem_Click);
            // 
            // cityTownToolStripMenuItem
            // 
            this.cityTownToolStripMenuItem.Name = "cityTownToolStripMenuItem";
            this.cityTownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cityTownToolStripMenuItem.Text = "City / Town";
            this.cityTownToolStripMenuItem.Click += new System.EventHandler(this.cityTownToolStripMenuItem_Click);
            // 
            // barangayToolStripMenuItem
            // 
            this.barangayToolStripMenuItem.Name = "barangayToolStripMenuItem";
            this.barangayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barangayToolStripMenuItem.Text = "Barangay";
            this.barangayToolStripMenuItem.Click += new System.EventHandler(this.barangayToolStripMenuItem_Click);
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programsToolStripMenuItem.Text = "Programs";
            this.programsToolStripMenuItem.Click += new System.EventHandler(this.programsToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.positionToolStripMenuItem.Text = "Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.positionToolStripMenuItem_Click);
            // 
            // instituteToolStripMenuItem
            // 
            this.instituteToolStripMenuItem.Name = "instituteToolStripMenuItem";
            this.instituteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instituteToolStripMenuItem.Text = "Institute";
            this.instituteToolStripMenuItem.Click += new System.EventHandler(this.instituteToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewVotedToolStripMenuItem,
            this.viewNotVotedToolStripMenuItem});
            this.reportToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.SEO_icon16x16;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // viewVotedToolStripMenuItem
            // 
            this.viewVotedToolStripMenuItem.Name = "viewVotedToolStripMenuItem";
            this.viewVotedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewVotedToolStripMenuItem.Text = "View Voted";
            this.viewVotedToolStripMenuItem.Click += new System.EventHandler(this.viewVotedToolStripMenuItem_Click);
            // 
            // viewNotVotedToolStripMenuItem
            // 
            this.viewNotVotedToolStripMenuItem.Name = "viewNotVotedToolStripMenuItem";
            this.viewNotVotedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewNotVotedToolStripMenuItem.Text = "View Not Voted";
            this.viewNotVotedToolStripMenuItem.Click += new System.EventHandler(this.viewNotVotedToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.Logout_icon16x16;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblName,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.lblPosition});
            this.toolStrip1.Location = new System.Drawing.Point(0, 476);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 22);
            this.lblName.Text = "toolStripLabel2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Position:";
            // 
            // lblPosition
            // 
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(86, 22);
            this.lblPosition.Text = "toolStripLabel3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "E-Voting System of Gov. Alfonso D. Tan College";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(254, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::VotingSystem.Properties.Resources.Actions_view_list_details_icon32x32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(361, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 55);
            this.button3.TabIndex = 10;
            this.button3.Text = "Result";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::VotingSystem.Properties.Resources.Documents_icon32x32;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(361, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(202, 55);
            this.button7.TabIndex = 8;
            this.button7.Text = "Setup Candidates Requirements";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::VotingSystem.Properties.Resources.User_Group_48x48;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(361, 303);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 55);
            this.button6.TabIndex = 7;
            this.button6.Text = "Candidates";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::VotingSystem.Properties.Resources.Apps_preferences_contact_list_icon32x32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(130, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Setup Voting";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::VotingSystem.Properties.Resources.level_icon32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(130, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Setup Position";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Green;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::VotingSystem.Properties.Resources.user_icon32x32;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(130, 242);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(202, 55);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Unofficial Registered Voters";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 501);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityTownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblPosition;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVotedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewNotVotedToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem instituteToolStripMenuItem;
    }
}

