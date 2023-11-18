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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.paneldash = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.calenderofactivities = new System.Windows.Forms.MonthCalendar();
            this.lblname = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelsmall = new Guna.UI2.WinForms.Guna2Panel();
            this.timetoclose = new System.Windows.Forms.Timer(this.components);
            this.lblrole = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.btncourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnbalance = new Guna.UI2.WinForms.Guna2Button();
            this.btnschedule = new Guna.UI2.WinForms.Guna2Button();
            this.btnviewgrades = new Guna.UI2.WinForms.Guna2Button();
            this.btnstudentconfirmation = new Guna.UI2.WinForms.Guna2Button();
            this.btnsmallprofile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnotification = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dragpanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.dragpanel.Controls.Add(this.btnsmallprofile);
            this.dragpanel.Controls.Add(this.btnotification);
            this.dragpanel.Controls.Add(this.label2);
            this.dragpanel.Location = new System.Drawing.Point(-1, 0);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(1579, 64);
            this.dragpanel.TabIndex = 17;
            this.dragpanel.Click += new System.EventHandler(this.dragpanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Home";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnhome);
            this.flowLayoutPanel1.Controls.Add(this.btncourse);
            this.flowLayoutPanel1.Controls.Add(this.btnbalance);
            this.flowLayoutPanel1.Controls.Add(this.btnschedule);
            this.flowLayoutPanel1.Controls.Add(this.btnviewgrades);
            this.flowLayoutPanel1.Controls.Add(this.btnstudentconfirmation);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(139, 837);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // paneldash
            // 
            this.paneldash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paneldash.BorderRadius = 12;
            this.paneldash.BorderThickness = 2;
            this.paneldash.Location = new System.Drawing.Point(144, 116);
            this.paneldash.Name = "paneldash";
            this.paneldash.Size = new System.Drawing.Size(1150, 769);
            this.paneldash.TabIndex = 19;
            this.paneldash.Click += new System.EventHandler(this.paneldash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(149, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dashboard";
            // 
            // calenderofactivities
            // 
            this.calenderofactivities.Location = new System.Drawing.Point(1318, 333);
            this.calenderofactivities.MaxDate = new System.DateTime(2024, 8, 15, 0, 0, 0, 0);
            this.calenderofactivities.MinDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.calenderofactivities.Name = "calenderofactivities";
            this.calenderofactivities.TabIndex = 20;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.lblname.Location = new System.Drawing.Point(1343, 273);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(177, 29);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Joshua Cambal";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(5, 283);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(253, 38);
            this.guna2TextBox1.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 225);
            this.listBox1.TabIndex = 23;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Separator2);
            this.guna2Panel2.Controls.Add(this.guna2TextBox1);
            this.guna2Panel2.Controls.Add(this.listBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(1300, 548);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(261, 326);
            this.guna2Panel2.TabIndex = 24;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderRadius = 12;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Location = new System.Drawing.Point(4, 6);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(253, 38);
            this.guna2Panel4.TabIndex = 25;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(5, 44);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(253, 10);
            this.guna2Separator2.TabIndex = 20;
            // 
            // panelsmall
            // 
            this.panelsmall.AutoSize = true;
            this.panelsmall.BorderRadius = 25;
            this.panelsmall.BorderThickness = 1;
            this.panelsmall.Location = new System.Drawing.Point(1379, 64);
            this.panelsmall.Name = "panelsmall";
            this.panelsmall.Size = new System.Drawing.Size(187, 100);
            this.panelsmall.TabIndex = 25;
            this.panelsmall.Visible = false;
            // 
            // timetoclose
            // 
            this.timetoclose.Enabled = true;
            this.timetoclose.Tick += new System.EventHandler(this.timetoclose_Tick);
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(1399, 305);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(57, 19);
            this.lblrole.TabIndex = 26;
            this.lblrole.Text = "ADMIN";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::SMARTLEARN.Properties.Resources.account;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1318, 77);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(227, 196);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 21;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMARTLEARN.Properties.Resources._8_uw3G6L5m0JdAlk9__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnhome
            // 
            this.btnhome.Animated = true;
            this.btnhome.BorderColor = System.Drawing.Color.White;
            this.btnhome.BorderRadius = 12;
            this.btnhome.BorderThickness = 1;
            this.btnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhome.FillColor = System.Drawing.Color.Transparent;
            this.btnhome.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.HoverState.Image = global::SMARTLEARN.Properties.Resources.home__1_;
            this.btnhome.Image = global::SMARTLEARN.Properties.Resources.home;
            this.btnhome.ImageOffset = new System.Drawing.Point(14, -10);
            this.btnhome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnhome.Location = new System.Drawing.Point(3, 72);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(131, 92);
            this.btnhome.TabIndex = 19;
            this.btnhome.Text = "Home";
            this.btnhome.TextOffset = new System.Drawing.Point(-8, 30);
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btncourse
            // 
            this.btncourse.Animated = true;
            this.btncourse.BorderColor = System.Drawing.Color.White;
            this.btncourse.BorderRadius = 12;
            this.btncourse.BorderThickness = 1;
            this.btncourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncourse.FillColor = System.Drawing.Color.Transparent;
            this.btncourse.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncourse.ForeColor = System.Drawing.Color.White;
            this.btncourse.HoverState.Image = global::SMARTLEARN.Properties.Resources.learning__1_;
            this.btncourse.Image = global::SMARTLEARN.Properties.Resources.learning;
            this.btncourse.ImageOffset = new System.Drawing.Point(16, -10);
            this.btncourse.ImageSize = new System.Drawing.Size(30, 30);
            this.btncourse.Location = new System.Drawing.Point(3, 170);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(131, 92);
            this.btncourse.TabIndex = 19;
            this.btncourse.Text = "Course";
            this.btncourse.TextOffset = new System.Drawing.Point(-12, 30);
            this.btncourse.Click += new System.EventHandler(this.btncourse_Click);
            // 
            // btnbalance
            // 
            this.btnbalance.Animated = true;
            this.btnbalance.BorderColor = System.Drawing.Color.White;
            this.btnbalance.BorderRadius = 12;
            this.btnbalance.BorderThickness = 1;
            this.btnbalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbalance.FillColor = System.Drawing.Color.Transparent;
            this.btnbalance.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnbalance.ForeColor = System.Drawing.Color.White;
            this.btnbalance.HoverState.Image = global::SMARTLEARN.Properties.Resources.bill__1_;
            this.btnbalance.Image = global::SMARTLEARN.Properties.Resources.bill;
            this.btnbalance.ImageOffset = new System.Drawing.Point(18, -10);
            this.btnbalance.ImageSize = new System.Drawing.Size(30, 30);
            this.btnbalance.Location = new System.Drawing.Point(3, 268);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(131, 92);
            this.btnbalance.TabIndex = 19;
            this.btnbalance.Text = "Balance";
            this.btnbalance.TextOffset = new System.Drawing.Point(-12, 30);
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.Animated = true;
            this.btnschedule.BorderColor = System.Drawing.Color.White;
            this.btnschedule.BorderRadius = 12;
            this.btnschedule.BorderThickness = 1;
            this.btnschedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnschedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnschedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnschedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnschedule.FillColor = System.Drawing.Color.Transparent;
            this.btnschedule.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.ForeColor = System.Drawing.Color.White;
            this.btnschedule.HoverState.Image = global::SMARTLEARN.Properties.Resources.schedule__1_;
            this.btnschedule.Image = global::SMARTLEARN.Properties.Resources.schedule;
            this.btnschedule.ImageOffset = new System.Drawing.Point(18, -10);
            this.btnschedule.ImageSize = new System.Drawing.Size(30, 30);
            this.btnschedule.Location = new System.Drawing.Point(3, 366);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(131, 92);
            this.btnschedule.TabIndex = 19;
            this.btnschedule.Text = "Schedule";
            this.btnschedule.TextOffset = new System.Drawing.Point(-12, 30);
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // btnviewgrades
            // 
            this.btnviewgrades.Animated = true;
            this.btnviewgrades.BorderColor = System.Drawing.Color.White;
            this.btnviewgrades.BorderRadius = 12;
            this.btnviewgrades.BorderThickness = 1;
            this.btnviewgrades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewgrades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewgrades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewgrades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewgrades.FillColor = System.Drawing.Color.Transparent;
            this.btnviewgrades.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewgrades.ForeColor = System.Drawing.Color.White;
            this.btnviewgrades.HoverState.Image = global::SMARTLEARN.Properties.Resources.exam__1_;
            this.btnviewgrades.Image = global::SMARTLEARN.Properties.Resources.exam;
            this.btnviewgrades.ImageOffset = new System.Drawing.Point(25, -10);
            this.btnviewgrades.ImageSize = new System.Drawing.Size(30, 30);
            this.btnviewgrades.Location = new System.Drawing.Point(3, 464);
            this.btnviewgrades.Name = "btnviewgrades";
            this.btnviewgrades.Size = new System.Drawing.Size(131, 92);
            this.btnviewgrades.TabIndex = 19;
            this.btnviewgrades.Text = "View Grades";
            this.btnviewgrades.TextOffset = new System.Drawing.Point(-12, 30);
            this.btnviewgrades.Click += new System.EventHandler(this.btnviewgrades_Click);
            // 
            // btnstudentconfirmation
            // 
            this.btnstudentconfirmation.Animated = true;
            this.btnstudentconfirmation.BorderColor = System.Drawing.Color.White;
            this.btnstudentconfirmation.BorderRadius = 12;
            this.btnstudentconfirmation.BorderThickness = 1;
            this.btnstudentconfirmation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentconfirmation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentconfirmation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstudentconfirmation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstudentconfirmation.FillColor = System.Drawing.Color.Transparent;
            this.btnstudentconfirmation.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnstudentconfirmation.ForeColor = System.Drawing.Color.White;
            this.btnstudentconfirmation.HoverState.Image = global::SMARTLEARN.Properties.Resources.search__1_;
            this.btnstudentconfirmation.Image = global::SMARTLEARN.Properties.Resources.search;
            this.btnstudentconfirmation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnstudentconfirmation.Location = new System.Drawing.Point(3, 562);
            this.btnstudentconfirmation.Name = "btnstudentconfirmation";
            this.btnstudentconfirmation.Size = new System.Drawing.Size(131, 92);
            this.btnstudentconfirmation.TabIndex = 19;
            this.btnstudentconfirmation.Text = "Student Confirmation";
            this.btnstudentconfirmation.Click += new System.EventHandler(this.btnstudentconfirmation_Click);
            // 
            // btnsmallprofile
            // 
            this.btnsmallprofile.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnsmallprofile.HoverState.Image = global::SMARTLEARN.Properties.Resources.user__1_;
            this.btnsmallprofile.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnsmallprofile.Image = global::SMARTLEARN.Properties.Resources.user;
            this.btnsmallprofile.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnsmallprofile.ImageRotate = 0F;
            this.btnsmallprofile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnsmallprofile.Location = new System.Drawing.Point(1508, 16);
            this.btnsmallprofile.Name = "btnsmallprofile";
            this.btnsmallprofile.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsmallprofile.Size = new System.Drawing.Size(38, 29);
            this.btnsmallprofile.TabIndex = 19;
            this.btnsmallprofile.Click += new System.EventHandler(this.btnsmallprofile_Click);
            // 
            // btnotification
            // 
            this.btnotification.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnotification.HoverState.Image = global::SMARTLEARN.Properties.Resources.bell__1_;
            this.btnotification.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnotification.Image = global::SMARTLEARN.Properties.Resources.bell;
            this.btnotification.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnotification.ImageRotate = 0F;
            this.btnotification.ImageSize = new System.Drawing.Size(25, 25);
            this.btnotification.Location = new System.Drawing.Point(1464, 16);
            this.btnotification.Name = "btnotification";
            this.btnotification.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnotification.Size = new System.Drawing.Size(38, 29);
            this.btnotification.TabIndex = 19;
            // 
            // FEDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1573, 897);
            this.ControlBox = false;
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.panelsmall);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.calenderofactivities);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paneldash);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dragpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEDashboard";
            this.Load += new System.EventHandler(this.FEDashboard_Load);
            this.dragpanel.ResumeLayout(false);
            this.dragpanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl Dragcontrol;
        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Button btncourse;
        private Guna.UI2.WinForms.Guna2Panel paneldash;
        private Guna.UI2.WinForms.Guna2Panel dragpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.MonthCalendar calenderofactivities;
        private System.Windows.Forms.Label lblname;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button btnbalance;
        private Guna.UI2.WinForms.Guna2Button btnschedule;
        private Guna.UI2.WinForms.Guna2Button btnviewgrades;
        private Guna.UI2.WinForms.Guna2ImageButton btnotification;
        private Guna.UI2.WinForms.Guna2ImageButton btnsmallprofile;
        private Guna.UI2.WinForms.Guna2Panel panelsmall;
        private System.Windows.Forms.Timer timetoclose;
        private System.Windows.Forms.Label lblrole;
        private Guna.UI2.WinForms.Guna2Button btnstudentconfirmation;
    }
}