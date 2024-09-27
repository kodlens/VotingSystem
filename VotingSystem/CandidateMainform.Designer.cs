namespace VotingSystem
{
    partial class CandidateMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateMainform));
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkCandidateRequirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCertificateOfCandidacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewCandidate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbInstitute = new VotingSystem.FlatComboBox();
            this.cmbPosition = new VotingSystem.FlatComboBox();
            this.markAsEligibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flx
            // 
            this.flx.AllowEditing = false;
            this.flx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flx.ColumnInfo = resources.GetString("flx.ColumnInfo");
            this.flx.ContextMenuStrip = this.contextMenuStrip1;
            this.flx.ExtendLastCol = true;
            this.flx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flx.Location = new System.Drawing.Point(12, 67);
            this.flx.Name = "flx";
            this.flx.Rows.DefaultSize = 22;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(1026, 410);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCandidateToolStripMenuItem,
            this.modifyCandidateToolStripMenuItem,
            this.refreshListToolStripMenuItem,
            this.deleteCandidateToolStripMenuItem,
            this.checkCandidateRequirementsToolStripMenuItem,
            this.viewCertificateOfCandidacyToolStripMenuItem,
            this.markAsEligibleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 180);
            // 
            // newCandidateToolStripMenuItem
            // 
            this.newCandidateToolStripMenuItem.Name = "newCandidateToolStripMenuItem";
            this.newCandidateToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.newCandidateToolStripMenuItem.Text = "New Candidate";
            this.newCandidateToolStripMenuItem.Click += new System.EventHandler(this.newCandidateToolStripMenuItem_Click);
            // 
            // modifyCandidateToolStripMenuItem
            // 
            this.modifyCandidateToolStripMenuItem.Name = "modifyCandidateToolStripMenuItem";
            this.modifyCandidateToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.modifyCandidateToolStripMenuItem.Text = "Modify Candidate";
            this.modifyCandidateToolStripMenuItem.Click += new System.EventHandler(this.modifyCandidateToolStripMenuItem_Click);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // deleteCandidateToolStripMenuItem
            // 
            this.deleteCandidateToolStripMenuItem.Name = "deleteCandidateToolStripMenuItem";
            this.deleteCandidateToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.deleteCandidateToolStripMenuItem.Text = "Delete Candidate";
            this.deleteCandidateToolStripMenuItem.Click += new System.EventHandler(this.deleteCandidateToolStripMenuItem_Click);
            // 
            // checkCandidateRequirementsToolStripMenuItem
            // 
            this.checkCandidateRequirementsToolStripMenuItem.Name = "checkCandidateRequirementsToolStripMenuItem";
            this.checkCandidateRequirementsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.checkCandidateRequirementsToolStripMenuItem.Text = "Check Candidate Requirements";
            this.checkCandidateRequirementsToolStripMenuItem.Click += new System.EventHandler(this.checkCandidateRequirementsToolStripMenuItem_Click);
            // 
            // viewCertificateOfCandidacyToolStripMenuItem
            // 
            this.viewCertificateOfCandidacyToolStripMenuItem.Name = "viewCertificateOfCandidacyToolStripMenuItem";
            this.viewCertificateOfCandidacyToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.viewCertificateOfCandidacyToolStripMenuItem.Text = "View Certificate of Candidacy";
            this.viewCertificateOfCandidacyToolStripMenuItem.Click += new System.EventHandler(this.viewCertificateOfCandidacyToolStripMenuItem_Click);
            // 
            // txtlname
            // 
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlname.Location = new System.Drawing.Point(87, 12);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(143, 21);
            this.txtlname.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Firstname:";
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfname.Location = new System.Drawing.Point(87, 40);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(143, 21);
            this.txtfname.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Positions:";
            // 
            // btnNewCandidate
            // 
            this.btnNewCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCandidate.Location = new System.Drawing.Point(19, 483);
            this.btnNewCandidate.Name = "btnNewCandidate";
            this.btnNewCandidate.Size = new System.Drawing.Size(98, 50);
            this.btnNewCandidate.TabIndex = 25;
            this.btnNewCandidate.Text = "New Candidate";
            this.btnNewCandidate.UseVisualStyleBackColor = true;
            this.btnNewCandidate.Click += new System.EventHandler(this.btnNewCandidate_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "Modify Candidate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(227, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(331, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 50);
            this.button3.TabIndex = 28;
            this.button3.Text = "Delete Candidate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Institute:";
            // 
            // cmbInstitute
            // 
            this.cmbInstitute.FormattingEnabled = true;
            this.cmbInstitute.Location = new System.Drawing.Point(778, 6);
            this.cmbInstitute.Name = "cmbInstitute";
            this.cmbInstitute.Size = new System.Drawing.Size(250, 23);
            this.cmbInstitute.TabIndex = 29;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(778, 39);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(250, 23);
            this.cmbPosition.TabIndex = 23;
            // 
            // markAsEligibleToolStripMenuItem
            // 
            this.markAsEligibleToolStripMenuItem.Name = "markAsEligibleToolStripMenuItem";
            this.markAsEligibleToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.markAsEligibleToolStripMenuItem.Text = "Mark as Eligible";
            this.markAsEligibleToolStripMenuItem.Click += new System.EventHandler(this.markAsEligibleToolStripMenuItem_Click);
            // 
            // CandidateMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbInstitute);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewCandidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CandidateMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidate List";
            this.Load += new System.EventHandler(this.CandidateMainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkCandidateRequirementsToolStripMenuItem;
        private FlatComboBox cmbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewCertificateOfCandidacyToolStripMenuItem;
        private System.Windows.Forms.Button btnNewCandidate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private FlatComboBox cmbInstitute;
        private System.Windows.Forms.ToolStripMenuItem markAsEligibleToolStripMenuItem;
    }
}