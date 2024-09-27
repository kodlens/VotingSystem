namespace VotingSystem
{
    partial class CheckCandidateRequirementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckCandidateRequirementsForm));
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUploadedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblElectionType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnUpdateEligible = new System.Windows.Forms.Button();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.flx.Location = new System.Drawing.Point(14, 87);
            this.flx.Name = "flx";
            this.flx.Rows.DefaultSize = 22;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(926, 387);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFileToolStripMenuItem,
            this.modifyUploadedFileToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 70);
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.uploadFileToolStripMenuItem.Text = "Upload File";
            this.uploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // modifyUploadedFileToolStripMenuItem
            // 
            this.modifyUploadedFileToolStripMenuItem.Name = "modifyUploadedFileToolStripMenuItem";
            this.modifyUploadedFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modifyUploadedFileToolStripMenuItem.Text = "Modify Uploaded File";
            this.modifyUploadedFileToolStripMenuItem.Click += new System.EventHandler(this.modifyUploadedFileToolStripMenuItem_Click);
            // 
            // lblElectionType
            // 
            this.lblElectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionType.Location = new System.Drawing.Point(14, 9);
            this.lblElectionType.Name = "lblElectionType";
            this.lblElectionType.Size = new System.Drawing.Size(926, 38);
            this.lblElectionType.TabIndex = 16;
            this.lblElectionType.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(899, 28);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "label2";
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(12, 479);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(122, 38);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUpdateEligible
            // 
            this.btnUpdateEligible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEligible.Location = new System.Drawing.Point(140, 479);
            this.btnUpdateEligible.Name = "btnUpdateEligible";
            this.btnUpdateEligible.Size = new System.Drawing.Size(149, 38);
            this.btnUpdateEligible.TabIndex = 20;
            this.btnUpdateEligible.Text = "Mark as Completed";
            this.btnUpdateEligible.UseVisualStyleBackColor = true;
            this.btnUpdateEligible.Click += new System.EventHandler(this.btnUpdateEligible_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // CheckCandidateRequirementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 529);
            this.Controls.Add(this.btnUpdateEligible);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblElectionType);
            this.Controls.Add(this.flx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckCandidateRequirementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Requirements";
            this.Load += new System.EventHandler(this.CheckCandidateRequirementsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.Label lblElectionType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ToolStripMenuItem modifyUploadedFileToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateEligible;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}