namespace VotingSystem
{
    partial class ProgramsAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbInstitute = new VotingSystem.FlatComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Location = new System.Drawing.Point(132, 82);
            this.txtDesc.MaxLength = 70;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(201, 52);
            this.txtDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Program Title:";
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(132, 55);
            this.txtCode.MaxLength = 30;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(201, 21);
            this.txtCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Program Code:";
            // 
            // txtMajor
            // 
            this.txtMajor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMajor.Location = new System.Drawing.Point(132, 140);
            this.txtMajor.MaxLength = 70;
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(201, 21);
            this.txtMajor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Major:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(258, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Save";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbInstitute
            // 
            this.cmbInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInstitute.FormattingEnabled = true;
            this.cmbInstitute.Location = new System.Drawing.Point(132, 26);
            this.cmbInstitute.Name = "cmbInstitute";
            this.cmbInstitute.Size = new System.Drawing.Size(201, 23);
            this.cmbInstitute.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(73, 29);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 15);
            this.label32.TabIndex = 35;
            this.label32.Text = "Institute:";
            // 
            // ProgramsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 234);
            this.Controls.Add(this.cmbInstitute);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Programs";
            this.Load += new System.EventHandler(this.ProgramsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private FlatComboBox cmbInstitute;
        private System.Windows.Forms.Label label32;
    }
}