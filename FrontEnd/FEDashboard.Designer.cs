namespace SMARTLEARN.FrontEnd
{
    partial class FEDashboard
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
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelsmall = new Guna.UI2.WinForms.Guna2Panel();
            this.timetoclose = new System.Windows.Forms.Timer(this.components);
            this.paneldash = new Guna.UI2.WinForms.Guna2Panel();
            this.Helpforbutton = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.btncourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnschedule = new Guna.UI2.WinForms.Guna2Button();
            this.btnviewgrades = new Guna.UI2.WinForms.Guna2Button();
            this.btnstudentregistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnfacultyregistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnbalance = new Guna.UI2.WinForms.Guna2Button();
            this.btnstudentgrades = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnforum = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnsmallprofile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dragpanel.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.dragpanel.Controls.Add(this.guna2CirclePictureBox1);
            this.dragpanel.Controls.Add(this.btnsmallprofile);
            this.dragpanel.Controls.Add(this.label2);
            this.dragpanel.Location = new System.Drawing.Point(-1, 0);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(1059, 64);
            this.dragpanel.TabIndex = 17;
            this.dragpanel.Click += new System.EventHandler(this.dragpanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Smart Learn";
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar.Controls.Add(this.btnhome);
            this.Sidebar.Controls.Add(this.btncourse);
            this.Sidebar.Controls.Add(this.btnschedule);
            this.Sidebar.Controls.Add(this.btnviewgrades);
            this.Sidebar.Controls.Add(this.btnforum);
            this.Sidebar.Controls.Add(this.btnstudentregistration);
            this.Sidebar.Controls.Add(this.btnfacultyregistration);
            this.Sidebar.Controls.Add(this.btnbalance);
            this.Sidebar.Controls.Add(this.btnstudentgrades);
            this.Sidebar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidebar.Location = new System.Drawing.Point(3, 4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(64, 693);
            this.Sidebar.TabIndex = 18;
            // 
            // panelsmall
            // 
            this.panelsmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelsmall.AutoSize = true;
            this.panelsmall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelsmall.BackColor = System.Drawing.Color.Transparent;
            this.panelsmall.BorderRadius = 25;
            this.panelsmall.BorderThickness = 1;
            this.panelsmall.Location = new System.Drawing.Point(1058, 66);
            this.panelsmall.Name = "panelsmall";
            this.panelsmall.Size = new System.Drawing.Size(0, 0);
            this.panelsmall.TabIndex = 25;
            this.panelsmall.Visible = false;
            // 
            // timetoclose
            // 
            this.timetoclose.Enabled = true;
            this.timetoclose.Tick += new System.EventHandler(this.timetoclose_Tick);
            // 
            // paneldash
            // 
            this.paneldash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paneldash.BorderRadius = 12;
            this.paneldash.Location = new System.Drawing.Point(101, 69);
            this.paneldash.Name = "paneldash";
            this.paneldash.Size = new System.Drawing.Size(945, 610);
            this.paneldash.TabIndex = 19;
            this.paneldash.Click += new System.EventHandler(this.paneldash_Click);
            // 
            // Helpforbutton
            // 
            this.Helpforbutton.AllowLinksHandling = true;
            this.Helpforbutton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpforbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Helpforbutton.MaximumSize = new System.Drawing.Size(0, 0);
            this.Helpforbutton.TitleFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpforbutton.ToolTipTitle = "What\'s this?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.Sidebar);
            this.guna2Panel1.Location = new System.Drawing.Point(6, 79);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(89, 600);
            this.guna2Panel1.TabIndex = 28;
            // 
            // btnhome
            // 
            this.btnhome.Animated = true;
            this.btnhome.BorderColor = System.Drawing.Color.White;
            this.btnhome.BorderRadius = 12;
            this.btnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhome.FillColor = System.Drawing.Color.Transparent;
            this.btnhome.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.HoverState.Image = global::SMARTLEARN.Properties.Resources.home__1_;
            this.btnhome.Image = global::SMARTLEARN.Properties.Resources.home;
            this.btnhome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnhome.Location = new System.Drawing.Point(3, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(64, 92);
            this.btnhome.TabIndex = 19;
            this.btnhome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnhome.TextOffset = new System.Drawing.Point(-15, 0);
            this.Helpforbutton.SetToolTip(this.btnhome, "Home");
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btncourse
            // 
            this.btncourse.Animated = true;
            this.btncourse.BorderColor = System.Drawing.Color.White;
            this.btncourse.BorderRadius = 12;
            this.btncourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncourse.FillColor = System.Drawing.Color.Transparent;
            this.btncourse.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btncourse.ForeColor = System.Drawing.Color.White;
            this.btncourse.HoverState.Image = global::SMARTLEARN.Properties.Resources.learning__1_;
            this.btncourse.Image = global::SMARTLEARN.Properties.Resources.learning;
            this.btncourse.ImageSize = new System.Drawing.Size(30, 30);
            this.btncourse.Location = new System.Drawing.Point(3, 101);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(64, 92);
            this.btncourse.TabIndex = 19;
            this.btncourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btncourse.TextOffset = new System.Drawing.Point(-15, 0);
            this.Helpforbutton.SetToolTip(this.btncourse, "Course");
            this.btncourse.Click += new System.EventHandler(this.btncourse_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.Animated = true;
            this.btnschedule.BorderColor = System.Drawing.Color.White;
            this.btnschedule.BorderRadius = 12;
            this.btnschedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnschedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnschedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnschedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnschedule.FillColor = System.Drawing.Color.Transparent;
            this.btnschedule.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.ForeColor = System.Drawing.Color.White;
            this.btnschedule.HoverState.Image = global::SMARTLEARN.Properties.Resources.schedule__1_;
            this.btnschedule.Image = global::SMARTLEARN.Properties.Resources.schedule;
            this.btnschedule.ImageSize = new System.Drawing.Size(30, 30);
            this.btnschedule.Location = new System.Drawing.Point(3, 199);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(64, 92);
            this.btnschedule.TabIndex = 19;
            this.btnschedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnschedule.TextOffset = new System.Drawing.Point(-5, 0);
            this.Helpforbutton.SetToolTip(this.btnschedule, "Schedule");
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // btnviewgrades
            // 
            this.btnviewgrades.Animated = true;
            this.btnviewgrades.BorderColor = System.Drawing.Color.White;
            this.btnviewgrades.BorderRadius = 12;
            this.btnviewgrades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewgrades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewgrades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewgrades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewgrades.FillColor = System.Drawing.Color.Transparent;
            this.btnviewgrades.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnviewgrades.ForeColor = System.Drawing.Color.White;
            this.btnviewgrades.HoverState.Image = global::SMARTLEARN.Properties.Resources.exam__1_;
            this.btnviewgrades.Image = global::SMARTLEARN.Properties.Resources.exam;
            this.btnviewgrades.ImageSize = new System.Drawing.Size(30, 30);
            this.btnviewgrades.Location = new System.Drawing.Point(3, 297);
            this.btnviewgrades.Name = "btnviewgrades";
            this.btnviewgrades.Size = new System.Drawing.Size(64, 92);
            this.btnviewgrades.TabIndex = 19;
            this.btnviewgrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnviewgrades.TextOffset = new System.Drawing.Point(-10, 0);
            this.Helpforbutton.SetToolTip(this.btnviewgrades, "Grades");
            this.btnviewgrades.Click += new System.EventHandler(this.btnviewgrades_Click);
            // 
            // btnstudentregistration
            // 
            this.btnstudentregistration.Animated = true;
            this.btnstudentregistration.BorderColor = System.Drawing.Color.White;
            this.btnstudentregistration.BorderRadius = 12;
            this.btnstudentregistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentregistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentregistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstudentregistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstudentregistration.FillColor = System.Drawing.Color.Transparent;
            this.btnstudentregistration.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnstudentregistration.ForeColor = System.Drawing.Color.White;
            this.btnstudentregistration.HoverState.Image = global::SMARTLEARN.Properties.Resources.online_registration__1_;
            this.btnstudentregistration.Image = global::SMARTLEARN.Properties.Resources.online_registration;
            this.btnstudentregistration.ImageSize = new System.Drawing.Size(30, 30);
            this.btnstudentregistration.Location = new System.Drawing.Point(3, 493);
            this.btnstudentregistration.Name = "btnstudentregistration";
            this.btnstudentregistration.Size = new System.Drawing.Size(64, 92);
            this.btnstudentregistration.TabIndex = 19;
            this.btnstudentregistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnstudentregistration.TextOffset = new System.Drawing.Point(2, 0);
            this.Helpforbutton.SetToolTip(this.btnstudentregistration, "Student Registration");
            this.btnstudentregistration.Click += new System.EventHandler(this.btnstudentconfirmation_Click);
            // 
            // btnfacultyregistration
            // 
            this.btnfacultyregistration.Animated = true;
            this.btnfacultyregistration.BorderColor = System.Drawing.Color.White;
            this.btnfacultyregistration.BorderRadius = 12;
            this.btnfacultyregistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfacultyregistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfacultyregistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfacultyregistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfacultyregistration.FillColor = System.Drawing.Color.Transparent;
            this.btnfacultyregistration.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnfacultyregistration.ForeColor = System.Drawing.Color.White;
            this.btnfacultyregistration.HoverState.Image = global::SMARTLEARN.Properties.Resources.profile2;
            this.btnfacultyregistration.Image = global::SMARTLEARN.Properties.Resources.profile1;
            this.btnfacultyregistration.ImageSize = new System.Drawing.Size(30, 30);
            this.btnfacultyregistration.Location = new System.Drawing.Point(3, 591);
            this.btnfacultyregistration.Name = "btnfacultyregistration";
            this.btnfacultyregistration.Size = new System.Drawing.Size(64, 92);
            this.btnfacultyregistration.TabIndex = 19;
            this.btnfacultyregistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Helpforbutton.SetToolTip(this.btnfacultyregistration, "Faculty Registration");
            this.btnfacultyregistration.Click += new System.EventHandler(this.btnfacultyregistration_Click);
            // 
            // btnbalance
            // 
            this.btnbalance.Animated = true;
            this.btnbalance.BorderColor = System.Drawing.Color.White;
            this.btnbalance.BorderRadius = 12;
            this.btnbalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbalance.FillColor = System.Drawing.Color.Transparent;
            this.btnbalance.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnbalance.ForeColor = System.Drawing.Color.White;
            this.btnbalance.HoverState.Image = global::SMARTLEARN.Properties.Resources.bill__1_;
            this.btnbalance.Image = global::SMARTLEARN.Properties.Resources.bill;
            this.btnbalance.ImageSize = new System.Drawing.Size(30, 30);
            this.btnbalance.Location = new System.Drawing.Point(3, 689);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(64, 92);
            this.btnbalance.TabIndex = 19;
            this.btnbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Helpforbutton.SetToolTip(this.btnbalance, "Balance");
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // btnstudentgrades
            // 
            this.btnstudentgrades.Animated = true;
            this.btnstudentgrades.BorderColor = System.Drawing.Color.White;
            this.btnstudentgrades.BorderRadius = 12;
            this.btnstudentgrades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentgrades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentgrades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstudentgrades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstudentgrades.FillColor = System.Drawing.Color.Transparent;
            this.btnstudentgrades.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnstudentgrades.ForeColor = System.Drawing.Color.White;
            this.btnstudentgrades.HoverState.Image = global::SMARTLEARN.Properties.Resources.assignment__1_;
            this.btnstudentgrades.Image = global::SMARTLEARN.Properties.Resources.assignment;
            this.btnstudentgrades.ImageSize = new System.Drawing.Size(30, 30);
            this.btnstudentgrades.Location = new System.Drawing.Point(3, 787);
            this.btnstudentgrades.Name = "btnstudentgrades";
            this.btnstudentgrades.Size = new System.Drawing.Size(64, 92);
            this.btnstudentgrades.TabIndex = 19;
            this.btnstudentgrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnstudentgrades.Click += new System.EventHandler(this.btnstudentgrades_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Image = global::SMARTLEARN.Properties.Resources.resize;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1025, 995);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(21, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 27;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnforum
            // 
            this.btnforum.Animated = true;
            this.btnforum.BorderColor = System.Drawing.Color.White;
            this.btnforum.BorderRadius = 12;
            this.btnforum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnforum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnforum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnforum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnforum.FillColor = System.Drawing.Color.Transparent;
            this.btnforum.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnforum.ForeColor = System.Drawing.Color.White;
            this.btnforum.HoverState.Image = global::SMARTLEARN.Properties.Resources.discussion__1_;
            this.btnforum.Image = global::SMARTLEARN.Properties.Resources.discussion;
            this.btnforum.ImageSize = new System.Drawing.Size(30, 30);
            this.btnforum.Location = new System.Drawing.Point(3, 395);
            this.btnforum.Name = "btnforum";
            this.btnforum.Size = new System.Drawing.Size(64, 92);
            this.btnforum.TabIndex = 19;
            this.btnforum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnforum.TextOffset = new System.Drawing.Point(-15, 0);
            this.Helpforbutton.SetToolTip(this.btnforum, "Forum");
            this.btnforum.Click += new System.EventHandler(this.btnforum_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::SMARTLEARN.Properties.Resources._8_uw3G6L5m0JdAlk9__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(7, 7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(52, 49);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 28;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnsmallprofile
            // 
            this.btnsmallprofile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsmallprofile.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnsmallprofile.HoverState.Image = global::SMARTLEARN.Properties.Resources.user__1_;
            this.btnsmallprofile.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnsmallprofile.Image = global::SMARTLEARN.Properties.Resources.user;
            this.btnsmallprofile.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnsmallprofile.ImageRotate = 0F;
            this.btnsmallprofile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnsmallprofile.Location = new System.Drawing.Point(1009, 16);
            this.btnsmallprofile.Name = "btnsmallprofile";
            this.btnsmallprofile.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsmallprofile.Size = new System.Drawing.Size(38, 29);
            this.btnsmallprofile.TabIndex = 19;
            this.Helpforbutton.SetToolTip(this.btnsmallprofile, "Profile");
            this.btnsmallprofile.Click += new System.EventHandler(this.btnsmallprofile_Click);
            // 
            // FEDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 691);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panelsmall);
            this.Controls.Add(this.paneldash);
            this.Controls.Add(this.dragpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(2160, 1230);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FEDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEDashboard";
            this.Load += new System.EventHandler(this.FEDashboard_Load);
            this.dragpanel.ResumeLayout(false);
            this.dragpanel.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl Dragcontrol;
        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Button btncourse;
        private Guna.UI2.WinForms.Guna2Panel dragpanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnschedule;
        private Guna.UI2.WinForms.Guna2Button btnviewgrades;
        private Guna.UI2.WinForms.Guna2Panel panelsmall;
        private System.Windows.Forms.Timer timetoclose;
        private Guna.UI2.WinForms.Guna2Button btnstudentregistration;
        private Guna.UI2.WinForms.Guna2Button btnfacultyregistration;
        private Guna.UI2.WinForms.Guna2Panel paneldash;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip Helpforbutton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnbalance;
        private Guna.UI2.WinForms.Guna2Button btnstudentgrades;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnsmallprofile;
        private Guna.UI2.WinForms.Guna2Button btnforum;
    }
}