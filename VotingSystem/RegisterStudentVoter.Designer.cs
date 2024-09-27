namespace VotingSystem
{
    partial class RegisterStudentVoter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudentVoter));
            this.flxStudent = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProgram = new VotingSystem.FlatComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNoRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // flxStudent
            // 
            this.flxStudent.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flxStudent.ColumnInfo = resources.GetString("flxStudent.ColumnInfo");
            this.flxStudent.ExtendLastCol = true;
            this.flxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flxStudent.Location = new System.Drawing.Point(12, 66);
            this.flxStudent.Name = "flxStudent";
            this.flxStudent.Rows.DefaultSize = 20;
            this.flxStudent.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.flxStudent.Size = new System.Drawing.Size(673, 343);
            this.flxStudent.StyleInfo = resources.GetString("flxStudent.StyleInfo");
            this.flxStudent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lastname:";
            // 
            // txtlname
            // 
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.Location = new System.Drawing.Point(104, 12);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(161, 21);
            this.txtlname.TabIndex = 3;
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Location = new System.Drawing.Point(104, 39);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(161, 21);
            this.txtfname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Firstname:";
            // 
            // cmbProgram
            // 
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Location = new System.Drawing.Point(374, 12);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(176, 23);
            this.cmbProgram.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Programs:";
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::VotingSystem.Properties.Resources.add_icon_24;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(552, 415);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSelect.Size = new System.Drawing.Size(139, 38);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Add Voter(s)";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(584, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNoRows
            // 
            this.lblNoRows.AutoSize = true;
            this.lblNoRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRows.Location = new System.Drawing.Point(12, 415);
            this.lblNoRows.Name = "lblNoRows";
            this.lblNoRows.Size = new System.Drawing.Size(39, 15);
            this.lblNoRows.TabIndex = 16;
            this.lblNoRows.Text = "####";
            // 
            // RegisterStudentVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 465);
            this.Controls.Add(this.lblNoRows);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProgram);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flxStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterStudentVoter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Unregistered Voters";
            this.Load += new System.EventHandler(this.RegisterStudentVoter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label2;
        private FlatComboBox cmbProgram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNoRows;
    }
}