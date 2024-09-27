namespace VotingSystem
{
    partial class VotersUploaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VotersUploaderForm));
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCheckID = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolBtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolBtnClose = new System.Windows.Forms.ToolStripButton();
            this.sheetNo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.c1XLBook1 = new C1.C1Excel.C1XLBook();
            this.lblNoRows = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetNo)).BeginInit();
            this.SuspendLayout();
            // 
            // flx
            // 
            this.flx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flx.ColumnInfo = resources.GetString("flx.ColumnInfo");
            this.flx.ExtendLastCol = true;
            this.flx.Location = new System.Drawing.Point(12, 54);
            this.flx.Name = "flx";
            this.flx.Rows.Count = 1;
            this.flx.Rows.DefaultSize = 19;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.flx.Size = new System.Drawing.Size(1080, 460);
            this.flx.TabIndex = 22;
            this.flx.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolBtnCheckID,
            this.toolStripButton2,
            this.toolBtnClear,
            this.toolBtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1104, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton1.Text = "Load Excel";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolBtnCheckID
            // 
            this.toolBtnCheckID.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtnCheckID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCheckID.Name = "toolBtnCheckID";
            this.toolBtnCheckID.Size = new System.Drawing.Size(58, 22);
            this.toolBtnCheckID.Text = "Check ID";
            this.toolBtnCheckID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnCheckID.Click += new System.EventHandler(this.toolBtnCheckID_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton2.Text = "Upload";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolBtnClear
            // 
            this.toolBtnClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnClear.Name = "toolBtnClear";
            this.toolBtnClear.Size = new System.Drawing.Size(38, 22);
            this.toolBtnClear.Text = "Clear";
            this.toolBtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnClear.Click += new System.EventHandler(this.toolBtnClear_Click);
            // 
            // toolBtnClose
            // 
            this.toolBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnClose.Name = "toolBtnClose";
            this.toolBtnClose.Size = new System.Drawing.Size(40, 22);
            this.toolBtnClose.Text = "Close";
            this.toolBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sheetNo
            // 
            this.sheetNo.Location = new System.Drawing.Point(53, 28);
            this.sheetNo.Name = "sheetNo";
            this.sheetNo.Size = new System.Drawing.Size(107, 20);
            this.sheetNo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sheet:";
            // 
            // lblNoRows
            // 
            this.lblNoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoRows.AutoSize = true;
            this.lblNoRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRows.Location = new System.Drawing.Point(9, 527);
            this.lblNoRows.Name = "lblNoRows";
            this.lblNoRows.Size = new System.Drawing.Size(0, 13);
            this.lblNoRows.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VotersUploaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flx);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sheetNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VotersUploaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voters Uploader";
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolBtnCheckID;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolBtnClear;
        private System.Windows.Forms.ToolStripButton toolBtnClose;
        private System.Windows.Forms.NumericUpDown sheetNo;
        private System.Windows.Forms.Label label1;
        private C1.C1Excel.C1XLBook c1XLBook1;
        private System.Windows.Forms.Label lblNoRows;
        private System.Windows.Forms.Button button1;
    }
}