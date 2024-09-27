namespace VotingSystem
{
    partial class UploadCandidateDocuments
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveDoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnScanDoc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbImageFormat = new VotingSystem.FlatComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(454, 343);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(211, 59);
            this.txtDesc.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Description";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(454, 297);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 21);
            this.txtTitle.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Title";
            // 
            // btnSaveDoc
            // 
            this.btnSaveDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDoc.Location = new System.Drawing.Point(231, 12);
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Size = new System.Drawing.Size(112, 33);
            this.btnSaveDoc.TabIndex = 28;
            this.btnSaveDoc.Text = "Save Documents";
            this.btnSaveDoc.UseVisualStyleBackColor = true;
            this.btnSaveDoc.Click += new System.EventHandler(this.btnSaveDoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Output Scanned Images";
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(451, 446);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(211, 21);
            this.txtoutput.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(451, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "Change output folder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Image Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select Scanner";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(450, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 94);
            this.listBox1.TabIndex = 20;
            // 
            // btnScanDoc
            // 
            this.btnScanDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanDoc.Location = new System.Drawing.Point(113, 12);
            this.btnScanDoc.Name = "btnScanDoc";
            this.btnScanDoc.Size = new System.Drawing.Size(112, 33);
            this.btnScanDoc.TabIndex = 19;
            this.btnScanDoc.Text = "Scan Document";
            this.btnScanDoc.UseVisualStyleBackColor = true;
            this.btnScanDoc.Click += new System.EventHandler(this.btnScanDoc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(454, 200);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(211, 21);
            this.txtfilename.TabIndex = 23;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(12, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 33);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse Files";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // cmbImageFormat
            // 
            this.cmbImageFormat.FormattingEnabled = true;
            this.cmbImageFormat.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "TIFF"});
            this.cmbImageFormat.Location = new System.Drawing.Point(454, 252);
            this.cmbImageFormat.Name = "cmbImageFormat";
            this.cmbImageFormat.Size = new System.Drawing.Size(211, 23);
            this.cmbImageFormat.TabIndex = 33;
            // 
            // UploadCandidateDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 599);
            this.Controls.Add(this.cmbImageFormat);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnScanDoc);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadCandidateDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadCandidateDocuments";
            this.Load += new System.EventHandler(this.UploadCandidateDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnScanDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatComboBox cmbImageFormat;
    }
}