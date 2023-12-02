namespace SMARTLEARN.FrontEnd
{
    partial class FEADRegisterAdmin
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
            this.RoundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.requiredfields = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtfirstid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuserid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbdepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dateofbirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtlname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmobilenum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtfname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnnext = new Guna.UI2.WinForms.Guna2Button();
            this.timertoproceed = new System.Windows.Forms.Timer(this.components);
            this.timertoreset = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.requiredfields.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // requiredfields
            // 
            this.requiredfields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.requiredfields.BorderRadius = 8;
            this.requiredfields.Controls.Add(this.txtfirstid);
            this.requiredfields.Controls.Add(this.txtuserid);
            this.requiredfields.Controls.Add(this.txtpassword);
            this.requiredfields.Controls.Add(this.label4);
            this.requiredfields.Controls.Add(this.label6);
            this.requiredfields.Controls.Add(this.label5);
            this.requiredfields.Controls.Add(this.label1);
            this.requiredfields.Controls.Add(this.cbgender);
            this.requiredfields.Controls.Add(this.cbdepartment);
            this.requiredfields.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.requiredfields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.requiredfields.Location = new System.Drawing.Point(19, 67);
            this.requiredfields.Name = "requiredfields";
            this.requiredfields.Size = new System.Drawing.Size(914, 216);
            this.requiredfields.TabIndex = 18;
            this.requiredfields.Text = "Role";
            // 
            // txtfirstid
            // 
            this.txtfirstid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtfirstid.Animated = true;
            this.txtfirstid.BorderRadius = 8;
            this.txtfirstid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfirstid.DefaultText = "";
            this.txtfirstid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfirstid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfirstid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstid.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.txtfirstid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtfirstid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstid.Location = new System.Drawing.Point(150, 47);
            this.txtfirstid.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtfirstid.MaxLength = 6;
            this.txtfirstid.Name = "txtfirstid";
            this.txtfirstid.PasswordChar = '\0';
            this.txtfirstid.PlaceholderText = "03XXXX";
            this.txtfirstid.SelectedText = "";
            this.txtfirstid.Size = new System.Drawing.Size(115, 36);
            this.txtfirstid.TabIndex = 0;
            this.txtfirstid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobilenum_KeyPress);
            // 
            // txtuserid
            // 
            this.txtuserid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtuserid.Animated = true;
            this.txtuserid.BorderRadius = 8;
            this.txtuserid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuserid.DefaultText = "";
            this.txtuserid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuserid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuserid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuserid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuserid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuserid.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.txtuserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtuserid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuserid.Location = new System.Drawing.Point(271, 47);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtuserid.MaxLength = 6;
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.PasswordChar = '\0';
            this.txtuserid.PlaceholderText = "XXXXXX";
            this.txtuserid.ReadOnly = true;
            this.txtuserid.SelectedText = "";
            this.txtuserid.Size = new System.Drawing.Size(115, 36);
            this.txtuserid.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpassword.Animated = true;
            this.txtpassword.BorderRadius = 8;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(150, 173);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtpassword.PlaceholderText = "Create account password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(759, 36);
            this.txtpassword.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gender";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Department";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            // 
            // cbgender
            // 
            this.cbgender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbgender.BackColor = System.Drawing.Color.Transparent;
            this.cbgender.BorderRadius = 8;
            this.cbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbgender.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.cbgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbgender.ItemHeight = 30;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(150, 89);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(236, 36);
            this.cbgender.TabIndex = 1;
            // 
            // cbdepartment
            // 
            this.cbdepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbdepartment.BackColor = System.Drawing.Color.Transparent;
            this.cbdepartment.BorderRadius = 8;
            this.cbdepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdepartment.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbdepartment.ItemHeight = 30;
            this.cbdepartment.Items.AddRange(new object[] {
            "Information Communication Technology (ICT)"});
            this.cbdepartment.Location = new System.Drawing.Point(150, 131);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(236, 36);
            this.cbdepartment.TabIndex = 2;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderRadius = 8;
            this.guna2GroupBox1.Controls.Add(this.dateofbirth);
            this.guna2GroupBox1.Controls.Add(this.txtlname);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.txtmobilenum);
            this.guna2GroupBox1.Controls.Add(this.txtemail);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.txtmname);
            this.guna2GroupBox1.Controls.Add(this.txtfname);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(19, 289);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(914, 252);
            this.guna2GroupBox1.TabIndex = 18;
            this.guna2GroupBox1.Text = "Personal Information";
            // 
            // dateofbirth
            // 
            this.dateofbirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateofbirth.Animated = true;
            this.dateofbirth.BorderRadius = 8;
            this.dateofbirth.Checked = true;
            this.dateofbirth.FillColor = System.Drawing.Color.White;
            this.dateofbirth.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateofbirth.Location = new System.Drawing.Point(544, 173);
            this.dateofbirth.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dateofbirth.MinDate = new System.DateTime(1940, 12, 31, 0, 0, 0, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(273, 36);
            this.dateofbirth.TabIndex = 9;
            this.dateofbirth.Value = new System.DateTime(2003, 6, 22, 0, 0, 0, 0);
            // 
            // txtlname
            // 
            this.txtlname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlname.Animated = true;
            this.txtlname.BorderRadius = 8;
            this.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlname.DefaultText = "";
            this.txtlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlname.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtlname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlname.Location = new System.Drawing.Point(150, 146);
            this.txtlname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtlname.MaxLength = 50;
            this.txtlname.Name = "txtlname";
            this.txtlname.PasswordChar = '\0';
            this.txtlname.PlaceholderText = "Last Name";
            this.txtlname.SelectedText = "";
            this.txtlname.Size = new System.Drawing.Size(273, 36);
            this.txtlname.TabIndex = 6;
            this.txtlname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfname_KeyPress_1);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Last Name";
            // 
            // txtmobilenum
            // 
            this.txtmobilenum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmobilenum.Animated = true;
            this.txtmobilenum.BorderRadius = 8;
            this.txtmobilenum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmobilenum.DefaultText = "";
            this.txtmobilenum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmobilenum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmobilenum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmobilenum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmobilenum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmobilenum.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtmobilenum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtmobilenum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmobilenum.Location = new System.Drawing.Point(150, 191);
            this.txtmobilenum.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtmobilenum.MaxLength = 11;
            this.txtmobilenum.Name = "txtmobilenum";
            this.txtmobilenum.PasswordChar = '\0';
            this.txtmobilenum.PlaceholderText = "09XXxxxxxx";
            this.txtmobilenum.SelectedText = "";
            this.txtmobilenum.Size = new System.Drawing.Size(273, 36);
            this.txtmobilenum.TabIndex = 8;
            this.txtmobilenum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobilenum_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Animated = true;
            this.txtemail.BorderRadius = 8;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(544, 82);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "sleeils@gmai.com";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(346, 36);
            this.txtemail.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mobile number";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "First Name";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email address";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Birthdate";
            // 
            // txtmname
            // 
            this.txtmname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmname.Animated = true;
            this.txtmname.BorderRadius = 8;
            this.txtmname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmname.DefaultText = "";
            this.txtmname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmname.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtmname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtmname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmname.Location = new System.Drawing.Point(150, 102);
            this.txtmname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtmname.MaxLength = 50;
            this.txtmname.Name = "txtmname";
            this.txtmname.PasswordChar = '\0';
            this.txtmname.PlaceholderText = "Middle Name";
            this.txtmname.SelectedText = "";
            this.txtmname.Size = new System.Drawing.Size(273, 36);
            this.txtmname.TabIndex = 5;
            this.txtmname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfname_KeyPress_1);
            // 
            // txtfname
            // 
            this.txtfname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfname.Animated = true;
            this.txtfname.BorderRadius = 8;
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.DefaultText = "";
            this.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfname.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtfname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfname.Location = new System.Drawing.Point(150, 57);
            this.txtfname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtfname.MaxLength = 50;
            this.txtfname.Name = "txtfname";
            this.txtfname.PasswordChar = '\0';
            this.txtfname.PlaceholderText = "First Name";
            this.txtfname.SelectedText = "";
            this.txtfname.Size = new System.Drawing.Size(273, 36);
            this.txtfname.TabIndex = 4;
            this.txtfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfname_KeyPress_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Middle Name";
            // 
            // btnnext
            // 
            this.btnnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnnext.Animated = true;
            this.btnnext.AutoRoundedCorners = true;
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.BorderRadius = 24;
            this.btnnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnnext.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(19, 547);
            this.btnnext.Name = "btnnext";
            this.btnnext.ShadowDecoration.Depth = 5;
            this.btnnext.ShadowDecoration.Enabled = true;
            this.btnnext.Size = new System.Drawing.Size(136, 51);
            this.btnnext.TabIndex = 11;
            this.btnnext.Text = "Next";
            this.btnnext.UseTransparentBackground = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // timertoproceed
            // 
            this.timertoproceed.Enabled = true;
            this.timertoproceed.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timertoreset
            // 
            this.timertoreset.Enabled = true;
            this.timertoreset.Interval = 1;
            this.timertoreset.Tick += new System.EventHandler(this.timertoclose_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.label13.Location = new System.Drawing.Point(14, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "Faculty Registration";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 51);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(940, 10);
            this.guna2Separator1.TabIndex = 24;
            // 
            // FEADRegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.requiredfields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEADRegisterAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FERegisterAdmin";
            this.Load += new System.EventHandler(this.FERegisterAdmin_Load);
            this.requiredfields.ResumeLayout(false);
            this.requiredfields.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private Guna.UI2.WinForms.Guna2GroupBox requiredfields;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbgender;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbdepartment;
        private Guna.UI2.WinForms.Guna2TextBox txtuserid;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtfname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtlname;
        private Guna.UI2.WinForms.Guna2TextBox txtmname;
        private Guna.UI2.WinForms.Guna2TextBox txtmobilenum;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateofbirth;
        public Guna.UI2.WinForms.Guna2Button btnnext;
        private System.Windows.Forms.Timer timertoproceed;
        private System.Windows.Forms.Timer timertoreset;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtfirstid;
    }
}