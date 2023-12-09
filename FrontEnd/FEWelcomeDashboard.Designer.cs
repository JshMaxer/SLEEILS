namespace SMARTLEARN.FrontEnd
{
    partial class FEWelcomeDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnaddimage = new Guna.UI2.WinForms.Guna2Button();
            this.btnremoveimage = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnaddimagequotes = new Guna.UI2.WinForms.Guna2Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnremovequotes = new Guna.UI2.WinForms.Guna2Button();
            this.picturequotes = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureboxslide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picturequotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxslide)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Welcome";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 51);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(918, 10);
            this.guna2Separator1.TabIndex = 23;
            // 
            // btnaddimage
            // 
            this.btnaddimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddimage.AutoRoundedCorners = true;
            this.btnaddimage.BackColor = System.Drawing.Color.Transparent;
            this.btnaddimage.BorderRadius = 14;
            this.btnaddimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddimage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddimage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddimage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddimage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddimage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnaddimage.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddimage.ForeColor = System.Drawing.Color.White;
            this.btnaddimage.Location = new System.Drawing.Point(493, 581);
            this.btnaddimage.Name = "btnaddimage";
            this.btnaddimage.ShadowDecoration.Depth = 5;
            this.btnaddimage.ShadowDecoration.Enabled = true;
            this.btnaddimage.Size = new System.Drawing.Size(178, 30);
            this.btnaddimage.TabIndex = 26;
            this.btnaddimage.Text = "Add Image";
            this.btnaddimage.UseTransparentBackground = true;
            this.btnaddimage.Visible = false;
            this.btnaddimage.Click += new System.EventHandler(this.btnaddimage_Click);
            // 
            // btnremoveimage
            // 
            this.btnremoveimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremoveimage.AutoRoundedCorners = true;
            this.btnremoveimage.BackColor = System.Drawing.Color.Transparent;
            this.btnremoveimage.BorderRadius = 14;
            this.btnremoveimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremoveimage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnremoveimage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnremoveimage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnremoveimage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnremoveimage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnremoveimage.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveimage.ForeColor = System.Drawing.Color.White;
            this.btnremoveimage.Location = new System.Drawing.Point(9, 581);
            this.btnremoveimage.Name = "btnremoveimage";
            this.btnremoveimage.ShadowDecoration.Depth = 5;
            this.btnremoveimage.ShadowDecoration.Enabled = true;
            this.btnremoveimage.Size = new System.Drawing.Size(178, 30);
            this.btnremoveimage.TabIndex = 26;
            this.btnremoveimage.Text = "Remove Image";
            this.btnremoveimage.UseTransparentBackground = true;
            this.btnremoveimage.Visible = false;
            this.btnremoveimage.Click += new System.EventHandler(this.btnremoveimage_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            // 
            // btnaddimagequotes
            // 
            this.btnaddimagequotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddimagequotes.AutoRoundedCorners = true;
            this.btnaddimagequotes.BackColor = System.Drawing.Color.Transparent;
            this.btnaddimagequotes.BorderRadius = 11;
            this.btnaddimagequotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddimagequotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddimagequotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddimagequotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddimagequotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddimagequotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnaddimagequotes.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddimagequotes.ForeColor = System.Drawing.Color.White;
            this.btnaddimagequotes.Location = new System.Drawing.Point(831, 319);
            this.btnaddimagequotes.Name = "btnaddimagequotes";
            this.btnaddimagequotes.ShadowDecoration.Depth = 5;
            this.btnaddimagequotes.ShadowDecoration.Enabled = true;
            this.btnaddimagequotes.Size = new System.Drawing.Size(107, 24);
            this.btnaddimagequotes.TabIndex = 26;
            this.btnaddimagequotes.Text = "Add Image";
            this.btnaddimagequotes.UseTransparentBackground = true;
            this.btnaddimagequotes.Visible = false;
            this.btnaddimagequotes.Click += new System.EventHandler(this.btnaddimagequotes_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(696, 377);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.TabStop = false;
            // 
            // btnremovequotes
            // 
            this.btnremovequotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremovequotes.AutoRoundedCorners = true;
            this.btnremovequotes.BackColor = System.Drawing.Color.Transparent;
            this.btnremovequotes.BorderRadius = 11;
            this.btnremovequotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremovequotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnremovequotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnremovequotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnremovequotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnremovequotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnremovequotes.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovequotes.ForeColor = System.Drawing.Color.White;
            this.btnremovequotes.Location = new System.Drawing.Point(677, 319);
            this.btnremovequotes.Name = "btnremovequotes";
            this.btnremovequotes.ShadowDecoration.Depth = 5;
            this.btnremovequotes.ShadowDecoration.Enabled = true;
            this.btnremovequotes.Size = new System.Drawing.Size(107, 24);
            this.btnremovequotes.TabIndex = 26;
            this.btnremovequotes.Text = "Remove";
            this.btnremovequotes.UseTransparentBackground = true;
            this.btnremovequotes.Visible = false;
            this.btnremovequotes.Click += new System.EventHandler(this.btnremovequotes_Click);
            // 
            // picturequotes
            // 
            this.picturequotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturequotes.BorderRadius = 15;
            this.picturequotes.Image = global::SMARTLEARN.Properties.Resources.stock;
            this.picturequotes.ImageRotate = 0F;
            this.picturequotes.Location = new System.Drawing.Point(677, 76);
            this.picturequotes.Name = "picturequotes";
            this.picturequotes.Size = new System.Drawing.Size(265, 237);
            this.picturequotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturequotes.TabIndex = 25;
            this.picturequotes.TabStop = false;
            // 
            // pictureboxslide
            // 
            this.pictureboxslide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxslide.BorderRadius = 15;
            this.pictureboxslide.Image = global::SMARTLEARN.Properties.Resources.What_Family_Day_When_December_22_2023_800_AM___400_PM_Where_DHS_covered_court_;
            this.pictureboxslide.ImageRotate = 0F;
            this.pictureboxslide.Location = new System.Drawing.Point(9, 76);
            this.pictureboxslide.Name = "pictureboxslide";
            this.pictureboxslide.Size = new System.Drawing.Size(662, 505);
            this.pictureboxslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxslide.TabIndex = 25;
            this.pictureboxslide.TabStop = false;
            // 
            // MessageDialog1
            // 
            this.MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog1.Caption = "Smart Learn";
            this.MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageDialog1.Parent = this;
            this.MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageDialog1.Text = null;
            // 
            // FEWelcomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnremoveimage);
            this.Controls.Add(this.btnremovequotes);
            this.Controls.Add(this.btnaddimagequotes);
            this.Controls.Add(this.btnaddimage);
            this.Controls.Add(this.picturequotes);
            this.Controls.Add(this.pictureboxslide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEWelcomeDashboard";
            this.Text = "FEWelcomeDashboard";
            this.Load += new System.EventHandler(this.FEWelcomeDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturequotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxslide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureboxslide;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2Button btnaddimage;
        public Guna.UI2.WinForms.Guna2Button btnremoveimage;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox picturequotes;
        public Guna.UI2.WinForms.Guna2Button btnaddimagequotes;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public Guna.UI2.WinForms.Guna2Button btnremovequotes;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
    }
}