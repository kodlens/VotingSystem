namespace VotingSystem
{
    partial class RequirementSetupMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequirementSetupMainform));
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteElectionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbElectionName = new VotingSystem.FlatComboBox();
            this.btnNewRequirement = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.flx.Location = new System.Drawing.Point(14, 68);
            this.flx.Name = "flx";
            this.flx.Rows.DefaultSize = 22;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(772, 409);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newElectionSetupToolStripMenuItem,
            this.modifyElectionSetupToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.deleteElectionSetupToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 92);
            // 
            // newElectionSetupToolStripMenuItem
            // 
            this.newElectionSetupToolStripMenuItem.Name = "newElectionSetupToolStripMenuItem";
            this.newElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.newElectionSetupToolStripMenuItem.Text = "New Requirement Setup";
            this.newElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.newElectionSetupToolStripMenuItem_Click);
            // 
            // modifyElectionSetupToolStripMenuItem
            // 
            this.modifyElectionSetupToolStripMenuItem.Name = "modifyElectionSetupToolStripMenuItem";
            this.modifyElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.modifyElectionSetupToolStripMenuItem.Text = "Modify Requirement Setup";
            this.modifyElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.modifyElectionSetupToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // deleteElectionSetupToolStripMenuItem
            // 
            this.deleteElectionSetupToolStripMenuItem.Name = "deleteElectionSetupToolStripMenuItem";
            this.deleteElectionSetupToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.deleteElectionSetupToolStripMenuItem.Text = "Delete Requirements";
            this.deleteElectionSetupToolStripMenuItem.Click += new System.EventHandler(this.deleteElectionSetupToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Election Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Location = new System.Drawing.Point(121, 41);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(309, 21);
            this.txtDesc.TabIndex = 18;
            // 
            // cmbElectionName
            // 
            this.cmbElectionName.FormattingEnabled = true;
            this.cmbElectionName.Location = new System.Drawing.Point(121, 12);
            this.cmbElectionName.Name = "cmbElectionName";
            this.cmbElectionName.Size = new System.Drawing.Size(204, 23);
            this.cmbElectionName.TabIndex = 15;
            // 
            // btnNewRequirement
            // 
            this.btnNewRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRequirement.Location = new System.Drawing.Point(14, 483);
            this.btnNewRequirement.Name = "btnNewRequirement";
            this.btnNewRequirement.Size = new System.Drawing.Size(101, 37);
            this.btnNewRequirement.TabIndex = 19;
            this.btnNewRequirement.Text = "New Setup";
            this.btnNewRequirement.UseVisualStyleBackColor = true;
            this.btnNewRequirement.Click += new System.EventHandler(this.btnNewRequirement_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(121, 483);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(101, 37);
            this.btnModify.TabIndex = 20;
            this.btnModify.Text = "Modify Setup";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(228, 483);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 37);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(335, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 37);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Setup";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RequirementSetupMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 536);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNewRequirement);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbElectionName);
            this.Controls.Add(this.flx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequirementSetupMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requirement Setup";
            this.Load += new System.EventHandler(this.RequirementSetupMainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newElectionSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyElectionSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteElectionSetupToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private FlatComboBox cmbElectionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnNewRequirement;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
    }
}