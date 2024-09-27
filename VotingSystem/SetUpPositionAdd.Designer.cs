namespace VotingSystem
{
    partial class SetUpPositionAdd
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
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.txtNoVotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbElection = new VotingSystem.FlatComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCanvote = new VotingSystem.FlatComboBox();
            this.SuspendLayout();
            // 
            // txtPosition
            // 
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPosition.Location = new System.Drawing.Point(106, 50);
            this.txtPosition.MaxLength = 30;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(223, 21);
            this.txtPosition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(234, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Location = new System.Drawing.Point(106, 77);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(223, 48);
            this.txtDescription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Election:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Order:";
            // 
            // txtorder
            // 
            this.txtorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtorder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtorder.Location = new System.Drawing.Point(106, 131);
            this.txtorder.MaxLength = 2;
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(95, 21);
            this.txtorder.TabIndex = 3;
            // 
            // txtNoVotes
            // 
            this.txtNoVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoVotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoVotes.Location = new System.Drawing.Point(106, 158);
            this.txtNoVotes.MaxLength = 2;
            this.txtNoVotes.Name = "txtNoVotes";
            this.txtNoVotes.Size = new System.Drawing.Size(95, 21);
            this.txtNoVotes.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "# of Winner(s):";
            // 
            // cmbElection
            // 
            this.cmbElection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbElection.FormattingEnabled = true;
            this.cmbElection.Location = new System.Drawing.Point(106, 21);
            this.cmbElection.Name = "cmbElection";
            this.cmbElection.Size = new System.Drawing.Size(178, 23);
            this.cmbElection.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Can Vote:";
            // 
            // cmbCanvote
            // 
            this.cmbCanvote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanvote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCanvote.FormattingEnabled = true;
            this.cmbCanvote.Items.AddRange(new object[] {
            "ALL",
            "INSTITUTE"});
            this.cmbCanvote.Location = new System.Drawing.Point(106, 185);
            this.cmbCanvote.Name = "cmbCanvote";
            this.cmbCanvote.Size = new System.Drawing.Size(178, 23);
            this.cmbCanvote.TabIndex = 5;
            // 
            // SetUpPositionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 295);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCanvote);
            this.Controls.Add(this.txtNoVotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtorder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbElection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosition);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetUpPositionAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Position";
            this.Load += new System.EventHandler(this.SetUpPositionAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private FlatComboBox cmbElection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.TextBox txtNoVotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FlatComboBox cmbCanvote;
    }
}