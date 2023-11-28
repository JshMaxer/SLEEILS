namespace SMARTLEARN.FrontEnd
{
    partial class FEHome
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
            this.RoundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnshowlog = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.timertoshow = new System.Windows.Forms.Timer(this.components);
            this.timerbeforeexit = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timertoclose = new System.Windows.Forms.Timer(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dragcontrol
            // 
            this.Dragcontrol.DockForm = true;
            this.Dragcontrol.DockIndicatorTransparencyValue = 0.6D;
            this.Dragcontrol.TargetControl = this;
            this.Dragcontrol.UseTransparentDrag = true;
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.btnshowlog);
            this.guna2Panel1.Location = new System.Drawing.Point(-20, -8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1148, 86);
            this.guna2Panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.guna2Panel3.Location = new System.Drawing.Point(20, 8);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1107, 10);
            this.guna2Panel3.TabIndex = 14;
            // 
            // btnshowlog
            // 
            this.btnshowlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnshowlog.Animated = true;
            this.btnshowlog.AutoRoundedCorners = true;
            this.btnshowlog.BackColor = System.Drawing.Color.Transparent;
            this.btnshowlog.BorderRadius = 16;
            this.btnshowlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnshowlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnshowlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnshowlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnshowlog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnshowlog.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowlog.ForeColor = System.Drawing.Color.White;
            this.btnshowlog.Location = new System.Drawing.Point(1003, 33);
            this.btnshowlog.Name = "btnshowlog";
            this.btnshowlog.ShadowDecoration.Depth = 5;
            this.btnshowlog.ShadowDecoration.Enabled = true;
            this.btnshowlog.Size = new System.Drawing.Size(96, 34);
            this.btnshowlog.TabIndex = 14;
            this.btnshowlog.Text = "Log in";
            this.btnshowlog.Click += new System.EventHandler(this.btnshowlog_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexit.AutoRoundedCorners = true;
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderRadius = 14;
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.Enabled = false;
            this.btnexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(12, 688);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Depth = 10;
            this.btnexit.Size = new System.Drawing.Size(103, 30);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseTransparentBackground = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // timertoshow
            // 
            this.timertoshow.Enabled = true;
            this.timertoshow.Tick += new System.EventHandler(this.timertoshow_Tick);
            // 
            // timerbeforeexit
            // 
            this.timerbeforeexit.Enabled = true;
            this.timerbeforeexit.Interval = 7000;
            this.timerbeforeexit.Tick += new System.EventHandler(this.timerbeforeexit_Tick);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // timertoclose
            // 
            this.timertoclose.Enabled = true;
            this.timertoclose.Tick += new System.EventHandler(this.timertoclose_Tick);
            // 
            // guna2ResizeForm1
            // 
            this.guna2ResizeForm1.TargetForm = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Image = global::SMARTLEARN.Properties.Resources.resize;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1074, 698);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(21, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FEHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 730);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2160, 1230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FEHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FEHome_Load);
            this.DoubleClick += new System.EventHandler(this.FEHome_DoubleClick);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl Dragcontrol;
        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnshowlog;
        public Guna.UI2.WinForms.Guna2Button btnexit;
        private System.Windows.Forms.Timer timertoshow;
        private System.Windows.Forms.Timer timerbeforeexit;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Timer timertoclose;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}