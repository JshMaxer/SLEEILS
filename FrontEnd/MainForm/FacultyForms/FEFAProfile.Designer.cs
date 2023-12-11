namespace SMARTLEARN.FrontEnd.MainForm.FacultyForms
{
    partial class FEFAProfile
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
            this.Dragcontrol = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dragpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RoundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timerclose = new System.Windows.Forms.Timer(this.components);
            this.panelsmall = new Guna.UI2.WinForms.Guna2Panel();
            this.lblmobile = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblrole = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lbluserid = new System.Windows.Forms.Label();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dragpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dragcontrol
            // 
            this.Dragcontrol.DockForm = true;
            this.Dragcontrol.DockIndicatorTransparencyValue = 0.6D;
            this.Dragcontrol.TargetControl = this.dragpanel;
            this.Dragcontrol.UseTransparentDrag = true;
            // 
            // dragpanel
            // 
            this.dragpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.dragpanel.Controls.Add(this.label2);
            this.dragpanel.Location = new System.Drawing.Point(-5, -1);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(1114, 64);
            this.dragpanel.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Profile";
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HIDE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // timerclose
            // 
            this.timerclose.Enabled = true;
            this.timerclose.Tick += new System.EventHandler(this.timerclose_Tick);
            // 
            // panelsmall
            // 
            this.panelsmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelsmall.AutoSize = true;
            this.panelsmall.BackColor = System.Drawing.Color.Transparent;
            this.panelsmall.BorderRadius = 25;
            this.panelsmall.BorderThickness = 1;
            this.panelsmall.Location = new System.Drawing.Point(907, 63);
            this.panelsmall.Name = "panelsmall";
            this.panelsmall.Size = new System.Drawing.Size(202, 125);
            this.panelsmall.TabIndex = 34;
            this.panelsmall.Visible = false;
            // 
            // lblmobile
            // 
            this.lblmobile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblmobile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobile.Location = new System.Drawing.Point(10, 585);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(1083, 19);
            this.lblmobile.TabIndex = 37;
            this.lblmobile.Text = "Mobile Number";
            this.lblmobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblemail
            // 
            this.lblemail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblemail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(10, 550);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(1083, 19);
            this.lblemail.TabIndex = 38;
            this.lblemail.Text = "Email";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblrole
            // 
            this.lblrole.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblrole.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(10, 457);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(1082, 19);
            this.lblrole.TabIndex = 39;
            this.lblrole.Text = "ROLE";
            this.lblrole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2CirclePictureBox1.Image = global::SMARTLEARN.Properties.Resources.profile;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(394, 152);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(314, 285);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 36;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.lblname.Location = new System.Drawing.Point(12, 509);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(1078, 29);
            this.lblname.TabIndex = 35;
            this.lblname.Text = "Faculty Name";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldepartment
            // 
            this.lbldepartment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbldepartment.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(10, 615);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(1083, 19);
            this.lbldepartment.TabIndex = 37;
            this.lbldepartment.Text = "Department";
            this.lbldepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbluserid
            // 
            this.lbluserid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbluserid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(10, 481);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(1083, 19);
            this.lbluserid.TabIndex = 37;
            this.lbluserid.Text = "UserID";
            this.lbluserid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnback.Animated = true;
            this.btnback.AutoRoundedCorners = true;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BorderRadius = 14;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(12, 688);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.BorderRadius = 2;
            this.btnback.ShadowDecoration.Depth = 10;
            this.btnback.Size = new System.Drawing.Size(103, 30);
            this.btnback.TabIndex = 40;
            this.btnback.Text = "Back";
            this.btnback.UseTransparentBackground = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FEFAProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1107, 730);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblmobile);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.panelsmall);
            this.Controls.Add(this.dragpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(2160, 1230);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FEFAProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEFAProfile";
            this.Load += new System.EventHandler(this.FEFAProfile_Load);
            this.dragpanel.ResumeLayout(false);
            this.dragpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl Dragcontrol;
        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Timer timerclose;
        private Guna.UI2.WinForms.Guna2Panel dragpanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelsmall;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblrole;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lbluserid;
        public Guna.UI2.WinForms.Guna2Button btnback;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}