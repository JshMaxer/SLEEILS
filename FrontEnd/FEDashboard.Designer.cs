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
            Guna.UI2.AnimatorNS.Animation animation24 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation23 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation22 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEDashboard));
            this.Dragcontrol = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dragpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnsmallprofile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnotification = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RoundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.btncourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnAssignments = new Guna.UI2.WinForms.Guna2Button();
            this.btnbalance = new Guna.UI2.WinForms.Guna2Button();
            this.btnschedule = new Guna.UI2.WinForms.Guna2Button();
            this.btnviewgrades = new Guna.UI2.WinForms.Guna2Button();
            this.btnstudentconfirmation = new Guna.UI2.WinForms.Guna2Button();
            this.btnfacultyregistration = new Guna.UI2.WinForms.Guna2Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.calenderofactivities = new System.Windows.Forms.MonthCalendar();
            this.lblname = new System.Windows.Forms.Label();
            this.panelsmall = new Guna.UI2.WinForms.Guna2Panel();
            this.timetoclose = new System.Windows.Forms.Timer(this.components);
            this.lblrole = new System.Windows.Forms.Label();
            this.btnmenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SidebarTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Dashboardtransition = new Guna.UI2.WinForms.Guna2Transition();
            this.LogoTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.Sidebartop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.paneldash = new Guna.UI2.WinForms.Guna2Panel();
            this.dragpanel.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.Sidebartop.SuspendLayout();
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
            this.dragpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.dragpanel.Controls.Add(this.btnsmallprofile);
            this.dragpanel.Controls.Add(this.btnotification);
            this.dragpanel.Controls.Add(this.label2);
            this.SidebarTransition.SetDecoration(this.dragpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.dragpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.dragpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dragpanel.Location = new System.Drawing.Point(-1, 0);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(1581, 64);
            this.dragpanel.TabIndex = 17;
            this.dragpanel.Click += new System.EventHandler(this.dragpanel_Click);
            // 
            // btnsmallprofile
            // 
            this.btnsmallprofile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsmallprofile.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SidebarTransition.SetDecoration(this.btnsmallprofile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.btnsmallprofile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnsmallprofile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnsmallprofile.HoverState.Image = global::SMARTLEARN.Properties.Resources.user__1_;
            this.btnsmallprofile.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnsmallprofile.Image = global::SMARTLEARN.Properties.Resources.user;
            this.btnsmallprofile.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnsmallprofile.ImageRotate = 0F;
            this.btnsmallprofile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnsmallprofile.Location = new System.Drawing.Point(1520, 16);
            this.btnsmallprofile.Name = "btnsmallprofile";
            this.btnsmallprofile.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsmallprofile.Size = new System.Drawing.Size(38, 29);
            this.btnsmallprofile.TabIndex = 19;
            this.btnsmallprofile.Click += new System.EventHandler(this.btnsmallprofile_Click);
            // 
            // btnotification
            // 
            this.btnotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnotification.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SidebarTransition.SetDecoration(this.btnotification, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.btnotification, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnotification, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnotification.HoverState.Image = global::SMARTLEARN.Properties.Resources.bell__1_;
            this.btnotification.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnotification.Image = global::SMARTLEARN.Properties.Resources.bell;
            this.btnotification.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnotification.ImageRotate = 0F;
            this.btnotification.ImageSize = new System.Drawing.Size(25, 25);
            this.btnotification.Location = new System.Drawing.Point(1476, 16);
            this.btnotification.Name = "btnotification";
            this.btnotification.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnotification.Size = new System.Drawing.Size(38, 29);
            this.btnotification.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Sidebar.Controls.Add(this.btnhome);
            this.Sidebar.Controls.Add(this.btncourse);
            this.Sidebar.Controls.Add(this.btnAssignments);
            this.Sidebar.Controls.Add(this.btnbalance);
            this.Sidebar.Controls.Add(this.btnschedule);
            this.Sidebar.Controls.Add(this.btnviewgrades);
            this.Sidebar.Controls.Add(this.btnstudentconfirmation);
            this.Sidebar.Controls.Add(this.btnfacultyregistration);
            this.LogoTransition.SetDecoration(this.Sidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.Sidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.Sidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sidebar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidebar.Location = new System.Drawing.Point(-1, 119);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(67, 783);
            this.Sidebar.TabIndex = 18;
            // 
            // btnhome
            // 
            this.btnhome.Animated = true;
            this.btnhome.BorderColor = System.Drawing.Color.White;
            this.btnhome.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btnhome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btnhome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnhome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhome.FillColor = System.Drawing.Color.Transparent;
            this.btnhome.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.HoverState.Image = global::SMARTLEARN.Properties.Resources.home__1_;
            this.btnhome.Image = global::SMARTLEARN.Properties.Resources.home;
            this.btnhome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnhome.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnhome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnhome.Location = new System.Drawing.Point(3, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(168, 92);
            this.btnhome.TabIndex = 19;
            this.btnhome.Text = "Home";
            this.btnhome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnhome.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btncourse
            // 
            this.btncourse.Animated = true;
            this.btncourse.BorderColor = System.Drawing.Color.White;
            this.btncourse.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btncourse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btncourse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btncourse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btncourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncourse.FillColor = System.Drawing.Color.Transparent;
            this.btncourse.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btncourse.ForeColor = System.Drawing.Color.White;
            this.btncourse.HoverState.Image = global::SMARTLEARN.Properties.Resources.learning__1_;
            this.btncourse.Image = global::SMARTLEARN.Properties.Resources.learning;
            this.btncourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncourse.ImageOffset = new System.Drawing.Point(8, 0);
            this.btncourse.ImageSize = new System.Drawing.Size(30, 30);
            this.btncourse.Location = new System.Drawing.Point(3, 101);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(168, 92);
            this.btncourse.TabIndex = 19;
            this.btncourse.Text = "Course";
            this.btncourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btncourse.TextOffset = new System.Drawing.Point(-15, 0);
            this.btncourse.Click += new System.EventHandler(this.btncourse_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.Animated = true;
            this.btnAssignments.BorderColor = System.Drawing.Color.White;
            this.btnAssignments.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btnAssignments, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btnAssignments, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAssignments, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAssignments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssignments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssignments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssignments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssignments.FillColor = System.Drawing.Color.Transparent;
            this.btnAssignments.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnAssignments.ForeColor = System.Drawing.Color.White;
            this.btnAssignments.HoverState.Image = global::SMARTLEARN.Properties.Resources.assignment__1_;
            this.btnAssignments.Image = global::SMARTLEARN.Properties.Resources.assignment;
            this.btnAssignments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAssignments.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnAssignments.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAssignments.Location = new System.Drawing.Point(3, 199);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(168, 92);
            this.btnAssignments.TabIndex = 19;
            this.btnAssignments.Text = "Assignments";
            this.btnAssignments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAssignments.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            // 
            // btnbalance
            // 
            this.btnbalance.Animated = true;
            this.btnbalance.BorderColor = System.Drawing.Color.White;
            this.btnbalance.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btnbalance, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btnbalance, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnbalance, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnbalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbalance.FillColor = System.Drawing.Color.Transparent;
            this.btnbalance.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnbalance.ForeColor = System.Drawing.Color.White;
            this.btnbalance.HoverState.Image = global::SMARTLEARN.Properties.Resources.bill__1_;
            this.btnbalance.Image = global::SMARTLEARN.Properties.Resources.bill;
            this.btnbalance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnbalance.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnbalance.ImageSize = new System.Drawing.Size(30, 30);
            this.btnbalance.Location = new System.Drawing.Point(3, 297);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(168, 92);
            this.btnbalance.TabIndex = 19;
            this.btnbalance.Text = "Balance";
            this.btnbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnbalance.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.Animated = true;
            this.btnschedule.BorderColor = System.Drawing.Color.White;
            this.btnschedule.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btnschedule, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btnschedule, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnschedule, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnschedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnschedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnschedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnschedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnschedule.FillColor = System.Drawing.Color.Transparent;
            this.btnschedule.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.ForeColor = System.Drawing.Color.White;
            this.btnschedule.HoverState.Image = global::SMARTLEARN.Properties.Resources.schedule__1_;
            this.btnschedule.Image = global::SMARTLEARN.Properties.Resources.schedule;
            this.btnschedule.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnschedule.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnschedule.ImageSize = new System.Drawing.Size(30, 30);
            this.btnschedule.Location = new System.Drawing.Point(3, 395);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(168, 92);
            this.btnschedule.TabIndex = 19;
            this.btnschedule.Text = "Schedule";
            this.btnschedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnschedule.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // btnviewgrades
            // 
            this.btnviewgrades.Animated = true;
            this.btnviewgrades.BorderColor = System.Drawing.Color.White;
            this.btnviewgrades.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btnviewgrades, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btnviewgrades, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnviewgrades, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnviewgrades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewgrades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewgrades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewgrades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewgrades.FillColor = System.Drawing.Color.Transparent;
            this.btnviewgrades.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnviewgrades.ForeColor = System.Drawing.Color.White;
            this.btnviewgrades.HoverState.Image = global::SMARTLEARN.Properties.Resources.exam__1_;
            this.btnviewgrades.Image = global::SMARTLEARN.Properties.Resources.exam;
            this.btnviewgrades.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnviewgrades.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnviewgrades.ImageSize = new System.Drawing.Size(30, 30);
            this.btnviewgrades.Location = new System.Drawing.Point(3, 493);
            this.btnviewgrades.Name = "btnviewgrades";
            this.btnviewgrades.Size = new System.Drawing.Size(168, 92);
            this.btnviewgrades.TabIndex = 19;
            this.btnviewgrades.Text = "Grades";
            this.btnviewgrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnviewgrades.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnviewgrades.Click += new System.EventHandler(this.btnviewgrades_Click);
            // 
            // btnstudentconfirmation
            // 
            this.btnstudentconfirmation.Animated = true;
            this.btnstudentconfirmation.BorderColor = System.Drawing.Color.White;
            this.btnstudentconfirmation.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btnstudentconfirmation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btnstudentconfirmation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnstudentconfirmation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnstudentconfirmation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentconfirmation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentconfirmation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstudentconfirmation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstudentconfirmation.FillColor = System.Drawing.Color.Transparent;
            this.btnstudentconfirmation.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnstudentconfirmation.ForeColor = System.Drawing.Color.White;
            this.btnstudentconfirmation.HoverState.Image = global::SMARTLEARN.Properties.Resources.search__1_;
            this.btnstudentconfirmation.Image = global::SMARTLEARN.Properties.Resources.search;
            this.btnstudentconfirmation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnstudentconfirmation.ImageOffset = new System.Drawing.Point(13, 0);
            this.btnstudentconfirmation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnstudentconfirmation.Location = new System.Drawing.Point(3, 591);
            this.btnstudentconfirmation.Name = "btnstudentconfirmation";
            this.btnstudentconfirmation.Size = new System.Drawing.Size(168, 92);
            this.btnstudentconfirmation.TabIndex = 19;
            this.btnstudentconfirmation.Text = "Student      Confirmation";
            this.btnstudentconfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnstudentconfirmation.TextOffset = new System.Drawing.Point(2, 0);
            this.btnstudentconfirmation.Click += new System.EventHandler(this.btnstudentconfirmation_Click);
            // 
            // btnfacultyregistration
            // 
            this.btnfacultyregistration.Animated = true;
            this.btnfacultyregistration.BorderColor = System.Drawing.Color.White;
            this.btnfacultyregistration.BorderRadius = 12;
            this.Dashboardtransition.SetDecoration(this.btnfacultyregistration, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.btnfacultyregistration, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnfacultyregistration, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnfacultyregistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfacultyregistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfacultyregistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfacultyregistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfacultyregistration.FillColor = System.Drawing.Color.Transparent;
            this.btnfacultyregistration.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnfacultyregistration.ForeColor = System.Drawing.Color.White;
            this.btnfacultyregistration.HoverState.Image = global::SMARTLEARN.Properties.Resources.profile2;
            this.btnfacultyregistration.Image = global::SMARTLEARN.Properties.Resources.profile1;
            this.btnfacultyregistration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnfacultyregistration.ImageOffset = new System.Drawing.Point(11, 0);
            this.btnfacultyregistration.ImageSize = new System.Drawing.Size(30, 30);
            this.btnfacultyregistration.Location = new System.Drawing.Point(3, 689);
            this.btnfacultyregistration.Name = "btnfacultyregistration";
            this.btnfacultyregistration.Size = new System.Drawing.Size(168, 92);
            this.btnfacultyregistration.TabIndex = 19;
            this.btnfacultyregistration.Text = "Faculty     Registration";
            this.btnfacultyregistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnfacultyregistration.Click += new System.EventHandler(this.btnfacultyregistration_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.lbltitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.lbltitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.lbltitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbltitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.lbltitle.Location = new System.Drawing.Point(72, 77);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(129, 29);
            this.lbltitle.TabIndex = 19;
            this.lbltitle.Text = "Dashboard";
            // 
            // calenderofactivities
            // 
            this.calenderofactivities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoTransition.SetDecoration(this.calenderofactivities, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.calenderofactivities, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.calenderofactivities, Guna.UI2.AnimatorNS.DecorationType.None);
            this.calenderofactivities.Location = new System.Drawing.Point(1328, 337);
            this.calenderofactivities.MaxDate = new System.DateTime(2024, 8, 15, 0, 0, 0, 0);
            this.calenderofactivities.MinDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.calenderofactivities.Name = "calenderofactivities";
            this.calenderofactivities.TabIndex = 20;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.lblname, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.lblname, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.lblname, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.lblname.Location = new System.Drawing.Point(1317, 277);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(248, 29);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Joshua Cambal";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelsmall
            // 
            this.panelsmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelsmall.AutoSize = true;
            this.panelsmall.BorderRadius = 25;
            this.panelsmall.BorderThickness = 1;
            this.SidebarTransition.SetDecoration(this.panelsmall, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.panelsmall, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panelsmall, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelsmall.Location = new System.Drawing.Point(1381, 64);
            this.panelsmall.Name = "panelsmall";
            this.panelsmall.Size = new System.Drawing.Size(202, 125);
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
            this.lblrole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoTransition.SetDecoration(this.lblrole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.lblrole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.lblrole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblrole.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(1311, 307);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(260, 19);
            this.lblrole.TabIndex = 26;
            this.lblrole.Text = "ADMIN";
            this.lblrole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmenu
            // 
            this.btnmenu.AnimatedGIF = true;
            this.btnmenu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SidebarTransition.SetDecoration(this.btnmenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.btnmenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnmenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmenu.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnmenu.Image = global::SMARTLEARN.Properties.Resources.main_menu;
            this.btnmenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnmenu.ImageRotate = 0F;
            this.btnmenu.ImageSize = new System.Drawing.Size(25, 25);
            this.btnmenu.Location = new System.Drawing.Point(18, 17);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.PressedState.ImageRotate = 360F;
            this.btnmenu.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnmenu.Size = new System.Drawing.Size(38, 29);
            this.btnmenu.TabIndex = 19;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.SidebarTransition.Cursor = null;
            animation24.AnimateOnlyDifferences = true;
            animation24.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.BlindCoeff")));
            animation24.LeafCoeff = 0F;
            animation24.MaxTime = 1F;
            animation24.MinTime = 0F;
            animation24.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.MosaicCoeff")));
            animation24.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation24.MosaicShift")));
            animation24.MosaicSize = 0;
            animation24.Padding = new System.Windows.Forms.Padding(0);
            animation24.RotateCoeff = 0F;
            animation24.RotateLimit = 0F;
            animation24.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.ScaleCoeff")));
            animation24.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.SlideCoeff")));
            animation24.TimeCoeff = 0F;
            animation24.TransparencyCoeff = 0F;
            this.SidebarTransition.DefaultAnimation = animation24;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SidebarTransition.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.Image = global::SMARTLEARN.Properties.Resources.profile;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1328, 81);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(227, 196);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 21;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Dashboardtransition
            // 
            this.Dashboardtransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.Dashboardtransition.Cursor = null;
            animation23.AnimateOnlyDifferences = true;
            animation23.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.BlindCoeff")));
            animation23.LeafCoeff = 0F;
            animation23.MaxTime = 1F;
            animation23.MinTime = 0F;
            animation23.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.MosaicCoeff")));
            animation23.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation23.MosaicShift")));
            animation23.MosaicSize = 0;
            animation23.Padding = new System.Windows.Forms.Padding(0);
            animation23.RotateCoeff = 0F;
            animation23.RotateLimit = 0F;
            animation23.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.ScaleCoeff")));
            animation23.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.SlideCoeff")));
            animation23.TimeCoeff = 0F;
            animation23.TransparencyCoeff = 0F;
            this.Dashboardtransition.DefaultAnimation = animation23;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Rotate;
            this.LogoTransition.Cursor = null;
            animation22.AnimateOnlyDifferences = true;
            animation22.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.BlindCoeff")));
            animation22.LeafCoeff = 0F;
            animation22.MaxTime = 1F;
            animation22.MinTime = 0F;
            animation22.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.MosaicCoeff")));
            animation22.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation22.MosaicShift")));
            animation22.MosaicSize = 0;
            animation22.Padding = new System.Windows.Forms.Padding(50);
            animation22.RotateCoeff = 1F;
            animation22.RotateLimit = 0F;
            animation22.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.ScaleCoeff")));
            animation22.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.SlideCoeff")));
            animation22.TimeCoeff = 0F;
            animation22.TransparencyCoeff = 1F;
            this.LogoTransition.DefaultAnimation = animation22;
            // 
            // Sidebartop
            // 
            this.Sidebartop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Sidebartop.Controls.Add(this.pictureBox1);
            this.Sidebartop.Controls.Add(this.btnmenu);
            this.SidebarTransition.SetDecoration(this.Sidebartop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.Sidebartop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Sidebartop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sidebartop.Location = new System.Drawing.Point(-1, 64);
            this.Sidebartop.Name = "Sidebartop";
            this.Sidebartop.Size = new System.Drawing.Size(67, 57);
            this.Sidebartop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.LogoTransition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::SMARTLEARN.Properties.Resources._8_uw3G6L5m0JdAlk9__1_;
            this.pictureBox1.Location = new System.Drawing.Point(116, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ResizeForm1
            // 
            this.guna2ResizeForm1.TargetForm = this;
            // 
            // paneldash
            // 
            this.paneldash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paneldash.BorderRadius = 12;
            this.SidebarTransition.SetDecoration(this.paneldash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this.paneldash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.paneldash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.paneldash.Location = new System.Drawing.Point(73, 116);
            this.paneldash.Name = "paneldash";
            this.paneldash.Size = new System.Drawing.Size(1230, 783);
            this.paneldash.TabIndex = 19;
            this.paneldash.Click += new System.EventHandler(this.paneldash_Click);
            // 
            // FEDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1573, 906);
            this.ControlBox = false;
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.Sidebartop);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.panelsmall);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.calenderofactivities);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.paneldash);
            this.Controls.Add(this.dragpanel);
            this.LogoTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboardtransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.Sidebartop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lbltitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.MonthCalendar calenderofactivities;
        private System.Windows.Forms.Label lblname;
        private Guna.UI2.WinForms.Guna2Button btnbalance;
        private Guna.UI2.WinForms.Guna2Button btnschedule;
        private Guna.UI2.WinForms.Guna2Button btnviewgrades;
        private Guna.UI2.WinForms.Guna2ImageButton btnotification;
        private Guna.UI2.WinForms.Guna2ImageButton btnsmallprofile;
        private Guna.UI2.WinForms.Guna2Panel panelsmall;
        private System.Windows.Forms.Timer timetoclose;
        private System.Windows.Forms.Label lblrole;
        private Guna.UI2.WinForms.Guna2Button btnstudentconfirmation;
        private Guna.UI2.WinForms.Guna2Button btnfacultyregistration;
        private Guna.UI2.WinForms.Guna2ImageButton btnmenu;
        private Guna.UI2.WinForms.Guna2Transition SidebarTransition;
        private Guna.UI2.WinForms.Guna2Transition Dashboardtransition;
        private Guna.UI2.WinForms.Guna2Transition LogoTransition;
        private Guna.UI2.WinForms.Guna2Button btnAssignments;
        private System.Windows.Forms.Panel Sidebartop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2Panel paneldash;
    }
}