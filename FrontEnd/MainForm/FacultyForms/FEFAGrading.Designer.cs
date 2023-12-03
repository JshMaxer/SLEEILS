namespace SMARTLEARN.FrontEnd.MainForm.FacultyForms
{
    partial class FEFAGrading
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
            this.RoundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbschoolyear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dragpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblfirstsem = new System.Windows.Forms.Label();
            this.lblsecondsem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudentfirst = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstudentsecond = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstudentaverage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.DGVStudentlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dragpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // cbschoolyear
            // 
            this.cbschoolyear.BackColor = System.Drawing.Color.Transparent;
            this.cbschoolyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbschoolyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbschoolyear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbschoolyear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbschoolyear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbschoolyear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbschoolyear.ItemHeight = 30;
            this.cbschoolyear.Location = new System.Drawing.Point(13, 97);
            this.cbschoolyear.Name = "cbschoolyear";
            this.cbschoolyear.Size = new System.Drawing.Size(189, 36);
            this.cbschoolyear.TabIndex = 20;
            this.cbschoolyear.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "School year";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // dragpanel
            // 
            this.dragpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.dragpanel.Controls.Add(this.label2);
            this.dragpanel.Location = new System.Drawing.Point(-5, -1);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(807, 64);
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
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Grading";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(706, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Semester";
            // 
            // lblfirstsem
            // 
            this.lblfirstsem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblfirstsem.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstsem.Location = new System.Drawing.Point(516, 245);
            this.lblfirstsem.Name = "lblfirstsem";
            this.lblfirstsem.Size = new System.Drawing.Size(251, 25);
            this.lblfirstsem.TabIndex = 21;
            this.lblfirstsem.Text = "1st Quarter";
            this.lblfirstsem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsecondsem
            // 
            this.lblsecondsem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblsecondsem.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecondsem.Location = new System.Drawing.Point(513, 333);
            this.lblsecondsem.Name = "lblsecondsem";
            this.lblsecondsem.Size = new System.Drawing.Size(256, 25);
            this.lblsecondsem.TabIndex = 21;
            this.lblsecondsem.Text = "2nd Quarter";
            this.lblsecondsem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Average";
            // 
            // cbsemester
            // 
            this.cbsemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbsemester.BackColor = System.Drawing.Color.Transparent;
            this.cbsemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbsemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbsemester.ItemHeight = 30;
            this.cbsemester.Items.AddRange(new object[] {
            "1st Sem",
            "2nd Sem"});
            this.cbsemester.Location = new System.Drawing.Point(596, 97);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(189, 36);
            this.cbsemester.TabIndex = 20;
            this.cbsemester.TabStop = false;
            this.cbsemester.SelectedIndexChanged += new System.EventHandler(this.cbsemester_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "List of students";
            // 
            // txtstudentfirst
            // 
            this.txtstudentfirst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtstudentfirst.Animated = true;
            this.txtstudentfirst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentfirst.DefaultText = "";
            this.txtstudentfirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstudentfirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstudentfirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentfirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentfirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentfirst.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentfirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentfirst.Location = new System.Drawing.Point(516, 290);
            this.txtstudentfirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstudentfirst.Name = "txtstudentfirst";
            this.txtstudentfirst.PasswordChar = '\0';
            this.txtstudentfirst.PlaceholderText = "";
            this.txtstudentfirst.SelectedText = "";
            this.txtstudentfirst.Size = new System.Drawing.Size(251, 39);
            this.txtstudentfirst.TabIndex = 23;
            this.txtstudentfirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstudentfirst.TextChanged += new System.EventHandler(this.txtstudentfirst_TextChanged);
            this.txtstudentfirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentfirst_KeyPress);
            // 
            // txtstudentsecond
            // 
            this.txtstudentsecond.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtstudentsecond.Animated = true;
            this.txtstudentsecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentsecond.DefaultText = "";
            this.txtstudentsecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstudentsecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstudentsecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentsecond.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentsecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentsecond.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentsecond.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentsecond.Location = new System.Drawing.Point(516, 380);
            this.txtstudentsecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstudentsecond.Name = "txtstudentsecond";
            this.txtstudentsecond.PasswordChar = '\0';
            this.txtstudentsecond.PlaceholderText = "";
            this.txtstudentsecond.SelectedText = "";
            this.txtstudentsecond.Size = new System.Drawing.Size(251, 39);
            this.txtstudentsecond.TabIndex = 23;
            this.txtstudentsecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstudentsecond.TextChanged += new System.EventHandler(this.txtstudentsecond_TextChanged);
            this.txtstudentsecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentfirst_KeyPress);
            // 
            // txtstudentaverage
            // 
            this.txtstudentaverage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtstudentaverage.Animated = true;
            this.txtstudentaverage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentaverage.DefaultText = "";
            this.txtstudentaverage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstudentaverage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstudentaverage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentaverage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentaverage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentaverage.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentaverage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentaverage.Location = new System.Drawing.Point(546, 474);
            this.txtstudentaverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstudentaverage.Name = "txtstudentaverage";
            this.txtstudentaverage.PasswordChar = '\0';
            this.txtstudentaverage.PlaceholderText = "";
            this.txtstudentaverage.ReadOnly = true;
            this.txtstudentaverage.SelectedText = "";
            this.txtstudentaverage.Size = new System.Drawing.Size(190, 39);
            this.txtstudentaverage.TabIndex = 23;
            this.txtstudentaverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Animated = true;
            this.btncancel.AutoRoundedCorners = true;
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.BorderRadius = 14;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btncancel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(651, 603);
            this.btncancel.Name = "btncancel";
            this.btncancel.ShadowDecoration.BorderRadius = 2;
            this.btncancel.ShadowDecoration.Depth = 10;
            this.btncancel.Size = new System.Drawing.Size(103, 30);
            this.btncancel.TabIndex = 35;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseTransparentBackground = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Animated = true;
            this.btnsave.AutoRoundedCorners = true;
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BorderRadius = 14;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnsave.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(542, 603);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.BorderRadius = 2;
            this.btnsave.ShadowDecoration.Depth = 10;
            this.btnsave.Size = new System.Drawing.Size(103, 30);
            this.btnsave.TabIndex = 35;
            this.btnsave.Text = "Save";
            this.btnsave.UseTransparentBackground = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
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
            this.DGVStudentlist.Location = new System.Drawing.Point(13, 207);
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
            this.DGVStudentlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVStudentlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVStudentlist.Size = new System.Drawing.Size(481, 426);
            this.DGVStudentlist.TabIndex = 46;
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
            // 
            // FEFAGrading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.DGVStudentlist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtstudentaverage);
            this.Controls.Add(this.txtstudentsecond);
            this.Controls.Add(this.txtstudentfirst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblsecondsem);
            this.Controls.Add(this.lblfirstsem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.cbschoolyear);
            this.Controls.Add(this.dragpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(2160, 1230);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FEFAGrading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEGrading";
            this.Load += new System.EventHandler(this.FEGrading_Load);
            this.dragpanel.ResumeLayout(false);
            this.dragpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        public Guna.UI2.WinForms.Guna2Button btnsave;
        public Guna.UI2.WinForms.Guna2Button btncancel;
        private Guna.UI2.WinForms.Guna2TextBox txtstudentaverage;
        private Guna.UI2.WinForms.Guna2TextBox txtstudentsecond;
        private Guna.UI2.WinForms.Guna2TextBox txtstudentfirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsecondsem;
        private System.Windows.Forms.Label lblfirstsem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbsemester;
        private Guna.UI2.WinForms.Guna2ComboBox cbschoolyear;
        private Guna.UI2.WinForms.Guna2Panel dragpanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVStudentlist;
    }
}