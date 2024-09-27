namespace VotingSystem
{
    partial class RegisterdVoterMainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterdVoterMainform));
            this.flxRegVoters = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNoRows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTypeElection = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbInstitute = new VotingSystem.FlatComboBox();
            this.cmbProgram = new VotingSystem.FlatComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flxRegVoters)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flxRegVoters
            // 
            this.flxRegVoters.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.flxRegVoters.AllowEditing = false;
            this.flxRegVoters.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flxRegVoters.ColumnInfo = resources.GetString("flxRegVoters.ColumnInfo");
            this.flxRegVoters.ContextMenuStrip = this.contextMenuStrip1;
            this.flxRegVoters.ExtendLastCol = true;
            this.flxRegVoters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flxRegVoters.Location = new System.Drawing.Point(12, 127);
            this.flxRegVoters.Name = "flxRegVoters";
            this.flxRegVoters.Rows.DefaultSize = 20;
            this.flxRegVoters.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.flxRegVoters.Size = new System.Drawing.Size(834, 405);
            this.flxRegVoters.StyleInfo = resources.GetString("flxRegVoters.StyleInfo");
            this.flxRegVoters.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem,
            this.removeStudentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 48);
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registerStudentToolStripMenuItem.Text = "Register Voters From List";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removeStudentToolStripMenuItem.Text = "Remove From Official List";
            this.removeStudentToolStripMenuItem.Click += new System.EventHandler(this.removeStudentToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Programs:";
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Location = new System.Drawing.Point(89, 100);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(184, 21);
            this.txtfname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firstname:";
            // 
            // txtlname
            // 
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.Location = new System.Drawing.Point(89, 73);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(184, 21);
            this.txtlname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lastname:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(745, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNoRows
            // 
            this.lblNoRows.AutoSize = true;
            this.lblNoRows.Location = new System.Drawing.Point(18, 535);
            this.lblNoRows.Name = "lblNoRows";
            this.lblNoRows.Size = new System.Drawing.Size(35, 15);
            this.lblNoRows.TabIndex = 15;
            this.lblNoRows.Text = "####";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "OFFICIAL REGISTERED VOTERS";
            // 
            // lblTypeElection
            // 
            this.lblTypeElection.AutoSize = true;
            this.lblTypeElection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeElection.Location = new System.Drawing.Point(18, 34);
            this.lblTypeElection.Name = "lblTypeElection";
            this.lblTypeElection.Size = new System.Drawing.Size(300, 24);
            this.lblTypeElection.TabIndex = 17;
            this.lblTypeElection.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Institute:";
            // 
            // cmbInstitute
            // 
            this.cmbInstitute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInstitute.FormattingEnabled = true;
            this.cmbInstitute.Location = new System.Drawing.Point(392, 99);
            this.cmbInstitute.Name = "cmbInstitute";
            this.cmbInstitute.Size = new System.Drawing.Size(176, 23);
            this.cmbInstitute.TabIndex = 18;
            // 
            // cmbProgram
            // 
            this.cmbProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Location = new System.Drawing.Point(392, 72);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(176, 23);
            this.cmbProgram.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(616, 538);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(113, 45);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register Voter From List";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(735, 538);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 45);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove Voter From List";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RegisterdVoterMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbInstitute);
            this.Controls.Add(this.lblTypeElection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNoRows);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProgram);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flxRegVoters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterdVoterMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registered Voter";
            this.Load += new System.EventHandler(this.RegisterdVoterMainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flxRegVoters)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flxRegVoters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private FlatComboBox cmbProgram;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;
        private System.Windows.Forms.Label lblNoRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTypeElection;
        private System.Windows.Forms.Label label5;
        private FlatComboBox cmbInstitute;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRemove;
    }
}