﻿namespace SMARTLEARN.FrontEnd
{
    partial class FEsmallprofile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEsmallprofile));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnprofile = new Guna.UI2.WinForms.Guna2Button();
            this.btnchangepass = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnprofile);
            this.flowLayoutPanel1.Controls.Add(this.btnchangepass);
            this.flowLayoutPanel1.Controls.Add(this.btnlogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 132);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnprofile
            // 
            this.btnprofile.Animated = true;
            this.btnprofile.BorderRadius = 8;
            this.btnprofile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprofile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprofile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnprofile.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnprofile.ForeColor = System.Drawing.Color.White;
            this.btnprofile.Image = global::SMARTLEARN.Properties.Resources.account;
            this.btnprofile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprofile.Location = new System.Drawing.Point(3, 3);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(191, 35);
            this.btnprofile.TabIndex = 22;
            this.btnprofile.Text = "Profile";
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnchangepass
            // 
            this.btnchangepass.Animated = true;
            this.btnchangepass.BorderRadius = 8;
            this.btnchangepass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnchangepass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnchangepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnchangepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnchangepass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnchangepass.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangepass.ForeColor = System.Drawing.Color.White;
            this.btnchangepass.Image = global::SMARTLEARN.Properties.Resources.help_web_button;
            this.btnchangepass.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnchangepass.Location = new System.Drawing.Point(3, 44);
            this.btnchangepass.Name = "btnchangepass";
            this.btnchangepass.Size = new System.Drawing.Size(191, 35);
            this.btnchangepass.TabIndex = 21;
            this.btnchangepass.Text = "Change password";
            this.btnchangepass.Click += new System.EventHandler(this.btnchangepass_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Animated = true;
            this.btnlogout.BorderRadius = 8;
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnlogout.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = global::SMARTLEARN.Properties.Resources.logout;
            this.btnlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogout.Location = new System.Drawing.Point(3, 85);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(191, 35);
            this.btnlogout.TabIndex = 20;
            this.btnlogout.Text = "Log out";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.guna2Panel5.Location = new System.Drawing.Point(4, 139);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(191, 10);
            this.guna2Panel5.TabIndex = 24;
            // 
            // FEsmallprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(196, 156);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FEsmallprofile";
            this.ShowInTaskbar = false;
            this.Text = "FECourse";
            this.Load += new System.EventHandler(this.FEsmallprofile_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnprofile;
        private Guna.UI2.WinForms.Guna2Button btnchangepass;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
    }
}