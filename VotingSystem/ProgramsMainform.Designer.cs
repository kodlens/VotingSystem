namespace VotingSystem
{
    partial class ProgramsMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramsMainform));
            this.flxPrograms = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flxPrograms)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flxPrograms
            // 
            this.flxPrograms.AllowEditing = false;
            this.flxPrograms.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flxPrograms.ColumnInfo = resources.GetString("flxPrograms.ColumnInfo");
            this.flxPrograms.ContextMenuStrip = this.contextMenuStrip1;
            this.flxPrograms.ExtendLastCol = true;
            this.flxPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flxPrograms.Location = new System.Drawing.Point(21, 63);
            this.flxPrograms.Name = "flxPrograms";
            this.flxPrograms.Rows.DefaultSize = 20;
            this.flxPrograms.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flxPrograms.Size = new System.Drawing.Size(724, 369);
            this.flxPrograms.StyleInfo = resources.GetString("flxPrograms.StyleInfo");
            this.flxPrograms.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newElectionSetupToolStripMenuItem,
            this.modifyElectionSetupToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.deleteElectionSetupToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 92);
            // 
            // newElectionSetupToolStripMenuItem
            // 
            this.newElectionSetupToolStripMenuItem.Name = "newElectionSetupToolStripMenuItem";
            this.newElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.newElectionSetupToolStripMenuItem.Text = "Add";
            this.newElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.newElectionSetupToolStripMenuItem_Click);
            // 
            // modifyElectionSetupToolStripMenuItem
            // 
            this.modifyElectionSetupToolStripMenuItem.Name = "modifyElectionSetupToolStripMenuItem";
            this.modifyElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.modifyElectionSetupToolStripMenuItem.Text = "Edit";
            this.modifyElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.modifyElectionSetupToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // deleteElectionSetupToolStripMenuItem
            // 
            this.deleteElectionSetupToolStripMenuItem.Name = "deleteElectionSetupToolStripMenuItem";
            this.deleteElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteElectionSetupToolStripMenuItem.Text = "Delete";
            this.deleteElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.deleteElectionSetupToolStripMenuItem_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(116, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(201, 21);
            this.txtCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Program Code:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(116, 36);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(201, 21);
            this.txtDesc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Program Title:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(670, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ProgramsMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 444);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flxPrograms);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramsMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.ProgramsMainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flxPrograms)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flxPrograms;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newElectionSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyElectionSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteElectionSetupToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
    }
}