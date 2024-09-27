namespace VotingSystem
{
    partial class VotersMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VotersMainform));
            this.txtIDNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chagePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProgramcode = new VotingSystem.FlatComboBox();
            this.flxVoter = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblRows = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flxVoter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDNo
            // 
            this.txtIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNo.Location = new System.Drawing.Point(88, 20);
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.Size = new System.Drawing.Size(151, 21);
            this.txtIDNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Program:";
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Location = new System.Drawing.Point(565, 20);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(151, 21);
            this.txtfname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firstname:";
            // 
            // txtlname
            // 
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.Location = new System.Drawing.Point(333, 20);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(151, 21);
            this.txtlname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lastname:";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.chagePasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 120);
            // 
            // chagePasswordToolStripMenuItem
            // 
            this.chagePasswordToolStripMenuItem.Name = "chagePasswordToolStripMenuItem";
            this.chagePasswordToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.chagePasswordToolStripMenuItem.Text = "Chage Password";
            this.chagePasswordToolStripMenuItem.Click += new System.EventHandler(this.chagePasswordToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProgramcode);
            this.groupBox1.Controls.Add(this.txtIDNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSeach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cmbProgramcode
            // 
            this.cmbProgramcode.FormattingEnabled = true;
            this.cmbProgramcode.Location = new System.Drawing.Point(88, 47);
            this.cmbProgramcode.Name = "cmbProgramcode";
            this.cmbProgramcode.Size = new System.Drawing.Size(151, 23);
            this.cmbProgramcode.TabIndex = 4;
            // 
            // flxVoter
            // 
            this.flxVoter.AllowEditing = false;
            this.flxVoter.AutoGenerateColumns = false;
            this.flxVoter.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flxVoter.ColumnInfo = resources.GetString("flxVoter.ColumnInfo");
            this.flxVoter.ContextMenuStrip = this.contextMenuStrip1;
            this.flxVoter.ExtendLastCol = true;
            this.flxVoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flxVoter.Location = new System.Drawing.Point(12, 98);
            this.flxVoter.Name = "flxVoter";
            this.flxVoter.Rows.DefaultSize = 20;
            this.flxVoter.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flxVoter.Size = new System.Drawing.Size(858, 376);
            this.flxVoter.StyleInfo = resources.GetString("flxVoter.StyleInfo");
            this.flxVoter.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(826, 477);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(44, 25);
            this.lblRows.TabIndex = 10;
            this.lblRows.Text = "0000";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "No of Rows:";
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Image = global::VotingSystem.Properties.Resources.add_icon_24;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(319, 480);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUpload.Size = new System.Drawing.Size(121, 37);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "&Uploader";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::VotingSystem.Properties.Resources.Close_2_icon24x24;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(212, 480);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(101, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "&Delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::VotingSystem.Properties.Resources.Pencil_icon24x24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(115, 480);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Edit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VotingSystem.Properties.Resources.add_icon_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 480);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Add";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Image = global::VotingSystem.Properties.Resources.Start_Menu_Search_icon24x24;
            this.btnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeach.Location = new System.Drawing.Point(743, 14);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSeach.Size = new System.Drawing.Size(97, 39);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "Search";
            this.btnSeach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // VotersMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 529);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flxVoter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VotersMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voters List";
            this.Load += new System.EventHandler(this.StudentMainform_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flxVoter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid flxVoter;
        private FlatComboBox cmbProgramcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem chagePasswordToolStripMenuItem;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpload;
    }
}