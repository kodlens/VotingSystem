namespace VotingSystem
{
    partial class PositionAdd
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
            this.btnNewClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewClear
            // 
            this.btnNewClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClear.Location = new System.Drawing.Point(74, 57);
            this.btnNewClear.Name = "btnNewClear";
            this.btnNewClear.Size = new System.Drawing.Size(86, 29);
            this.btnNewClear.TabIndex = 7;
            this.btnNewClear.Text = "New/Clear";
            this.btnNewClear.UseVisualStyleBackColor = true;
            this.btnNewClear.Click += new System.EventHandler(this.btnNewClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Position:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(166, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPos
            // 
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPos.Location = new System.Drawing.Point(74, 28);
            this.txtPos.MaxLength = 50;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(167, 21);
            this.txtPos.TabIndex = 4;
            // 
            // PositionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 117);
            this.Controls.Add(this.btnNewClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPos);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PositionAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Modify Position";
            this.Load += new System.EventHandler(this.PositionAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPos;
    }
}