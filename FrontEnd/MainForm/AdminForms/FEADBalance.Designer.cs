namespace SMARTLEARN.FrontEnd.AdminForms
{
    partial class FEADBalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtfirstsemester = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsecondsemester = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.pbprofile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.TimerDisable = new System.Windows.Forms.Timer(this.components);
            this.DGVStudentlist = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Balance";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 51);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(937, 10);
            this.guna2Separator1.TabIndex = 22;
            // 
            // txtfirstsemester
            // 
            this.txtfirstsemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfirstsemester.Animated = true;
            this.txtfirstsemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfirstsemester.DefaultText = "";
            this.txtfirstsemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfirstsemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfirstsemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstsemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstsemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstsemester.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstsemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstsemester.Location = new System.Drawing.Point(384, 135);
            this.txtfirstsemester.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtfirstsemester.Name = "txtfirstsemester";
            this.txtfirstsemester.PasswordChar = '\0';
            this.txtfirstsemester.PlaceholderText = "000000";
            this.txtfirstsemester.SelectedText = "";
            this.txtfirstsemester.Size = new System.Drawing.Size(252, 36);
            this.txtfirstsemester.TabIndex = 0;
            this.txtfirstsemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstsemester_KeyPress);
            // 
            // txtsecondsemester
            // 
            this.txtsecondsemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsecondsemester.Animated = true;
            this.txtsecondsemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsecondsemester.DefaultText = "";
            this.txtsecondsemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsecondsemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsecondsemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsecondsemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsecondsemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsecondsemester.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsecondsemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsecondsemester.Location = new System.Drawing.Point(685, 135);
            this.txtsecondsemester.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtsecondsemester.Name = "txtsecondsemester";
            this.txtsecondsemester.PasswordChar = '\0';
            this.txtsecondsemester.PlaceholderText = "000000";
            this.txtsecondsemester.SelectedText = "";
            this.txtsecondsemester.Size = new System.Drawing.Size(252, 36);
            this.txtsecondsemester.TabIndex = 1;
            this.txtsecondsemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstsemester_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(424, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "First Semester";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(710, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Second Semester";
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnsave.Animated = true;
            this.btnsave.AutoRoundedCorners = true;
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BorderRadius = 17;
            this.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsave.Enabled = false;
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnsave.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(19, 563);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Depth = 10;
            this.btnsave.Size = new System.Drawing.Size(111, 37);
            this.btnsave.TabIndex = 36;
            this.btnsave.TabStop = false;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseTransparentBackground = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pbprofile
            // 
            this.pbprofile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbprofile.Image = global::SMARTLEARN.Properties.Resources._8_uw3G6L5m0JdAlk9__1_;
            this.pbprofile.ImageRotate = 0F;
            this.pbprofile.Location = new System.Drawing.Point(19, 67);
            this.pbprofile.Name = "pbprofile";
            this.pbprofile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbprofile.Size = new System.Drawing.Size(168, 157);
            this.pbprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbprofile.TabIndex = 37;
            this.pbprofile.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.DimGray;
            this.lblname.Location = new System.Drawing.Point(193, 142);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(166, 29);
            this.lblname.TabIndex = 35;
            this.lblname.Text = "Student Name";
            // 
            // TimerDisable
            // 
            this.TimerDisable.Enabled = true;
            this.TimerDisable.Tick += new System.EventHandler(this.TimerDisable_Tick);
            // 
            // DGVStudentlist
            // 
            this.DGVStudentlist.AllowUserToAddRows = false;
            this.DGVStudentlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStudentlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStudentlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVStudentlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStudentlist.ColumnHeadersHeight = 50;
            this.DGVStudentlist.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudentlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVStudentlist.EnableHeadersVisualStyles = true;
            this.DGVStudentlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.Location = new System.Drawing.Point(13, 230);
            this.DGVStudentlist.MultiSelect = false;
            this.DGVStudentlist.Name = "DGVStudentlist";
            this.DGVStudentlist.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudentlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVStudentlist.RowHeadersVisible = false;
            this.DGVStudentlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVStudentlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVStudentlist.Size = new System.Drawing.Size(920, 327);
            this.DGVStudentlist.TabIndex = 45;
            this.DGVStudentlist.TabStop = false;
            this.DGVStudentlist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVStudentlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVStudentlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVStudentlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVStudentlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudentlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVStudentlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStudentlist.ThemeStyle.HeaderStyle.Height = 50;
            this.DGVStudentlist.ThemeStyle.ReadOnly = true;
            this.DGVStudentlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVStudentlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVStudentlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudentlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVStudentlist.ThemeStyle.RowsStyle.Height = 22;
            this.DGVStudentlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVStudentlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVStudentlist.SelectionChanged += new System.EventHandler(this.DGVStudentlist_SelectionChanged);
            // 
            // FEADBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.DGVStudentlist);
            this.Controls.Add(this.pbprofile);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsecondsemester);
            this.Controls.Add(this.txtfirstsemester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEADBalance";
            this.Text = "FEADBalance";
            this.Load += new System.EventHandler(this.FEADBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtfirstsemester;
        private Guna.UI2.WinForms.Guna2TextBox txtsecondsemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbprofile;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Timer TimerDisable;
        private Guna.UI2.WinForms.Guna2DataGridView DGVStudentlist;
    }
}