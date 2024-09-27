namespace VotingSystem
{
    partial class ElectionSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectionSetup));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRegisteredStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.lblNoRows = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtElection = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.ContextMenuStrip = this.contextMenuStrip1;
            this.c1FlexGrid1.ExtendLastCol = true;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.c1FlexGrid1.Location = new System.Drawing.Point(13, 76);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 20;
            this.c1FlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.c1FlexGrid1.Size = new System.Drawing.Size(627, 292);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newElectionSetupToolStripMenuItem,
            this.modifyElectionSetupToolStripMenuItem,
            this.showRegisteredStudentToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.deleteElectionSetupToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 114);
            // 
            // newElectionSetupToolStripMenuItem
            // 
            this.newElectionSetupToolStripMenuItem.Name = "newElectionSetupToolStripMenuItem";
            this.newElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.newElectionSetupToolStripMenuItem.Text = "New Election Setup";
            this.newElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.newElectionSetupToolStripMenuItem_Click);
            // 
            // modifyElectionSetupToolStripMenuItem
            // 
            this.modifyElectionSetupToolStripMenuItem.Name = "modifyElectionSetupToolStripMenuItem";
            this.modifyElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.modifyElectionSetupToolStripMenuItem.Text = "Modify Election Setup";
            this.modifyElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.modifyElectionSetupToolStripMenuItem_Click);
            // 
            // showRegisteredStudentToolStripMenuItem
            // 
            this.showRegisteredStudentToolStripMenuItem.Name = "showRegisteredStudentToolStripMenuItem";
            this.showRegisteredStudentToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showRegisteredStudentToolStripMenuItem.Text = "Show Registered Voters";
            this.showRegisteredStudentToolStripMenuItem.Click += new System.EventHandler(this.showRegisteredStudentToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // deleteElectionSetupToolStripMenuItem
            // 
            this.deleteElectionSetupToolStripMenuItem.Name = "deleteElectionSetupToolStripMenuItem";
            this.deleteElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.deleteElectionSetupToolStripMenuItem.Text = "Delete ElectionSetup";
            this.deleteElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.deleteElectionSetupToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(99, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(180, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(261, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnActive
            // 
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.Location = new System.Drawing.Point(17, 389);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(156, 34);
            this.btnActive.TabIndex = 7;
            this.btnActive.Text = "Set Default";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // lblNoRows
            // 
            this.lblNoRows.AutoSize = true;
            this.lblNoRows.Location = new System.Drawing.Point(14, 371);
            this.lblNoRows.Name = "lblNoRows";
            this.lblNoRows.Size = new System.Drawing.Size(35, 15);
            this.lblNoRows.TabIndex = 17;
            this.lblNoRows.Text = "####";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "ELECTION SETUP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Election Name:";
            // 
            // txtElection
            // 
            this.txtElection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtElection.Location = new System.Drawing.Point(111, 49);
            this.txtElection.Name = "txtElection";
            this.txtElection.Size = new System.Drawing.Size(155, 21);
            this.txtElection.TabIndex = 1;
            // 
            // ElectionSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNoRows);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.txtElection);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElectionSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election Setup";
            this.Load += new System.EventHandler(this.ElectionSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newElectionSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyElectionSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRegisteredStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteElectionSetupToolStripMenuItem;
        private System.Windows.Forms.Label lblNoRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElection;
    }
}