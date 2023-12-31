﻿namespace SMARTLEARN.FrontEnd
{
    partial class ProcessMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessMessage));
            this.RoundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblfirstmeeage = new System.Windows.Forms.Label();
            this.lblsecondmessage = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.loadingbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // lblfirstmeeage
            // 
            this.lblfirstmeeage.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstmeeage.Location = new System.Drawing.Point(11, 19);
            this.lblfirstmeeage.Name = "lblfirstmeeage";
            this.lblfirstmeeage.Size = new System.Drawing.Size(490, 90);
            this.lblfirstmeeage.TabIndex = 24;
            this.lblfirstmeeage.Text = "Faculty has been registered!";
            this.lblfirstmeeage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsecondmessage
            // 
            this.lblsecondmessage.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecondmessage.Location = new System.Drawing.Point(2, 116);
            this.lblsecondmessage.Name = "lblsecondmessage";
            this.lblsecondmessage.Size = new System.Drawing.Size(506, 45);
            this.lblsecondmessage.TabIndex = 25;
            this.lblsecondmessage.Text = "THANK YOU!";
            this.lblsecondmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.guna2Panel3.Location = new System.Drawing.Point(-8, -1);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(529, 10);
            this.guna2Panel3.TabIndex = 26;
            // 
            // loadingbar
            // 
            this.loadingbar.Animated = true;
            this.loadingbar.AnimationSpeed = 5F;
            this.loadingbar.BackColor = System.Drawing.Color.Transparent;
            this.loadingbar.FillColor = System.Drawing.Color.Transparent;
            this.loadingbar.FillThickness = 1;
            this.loadingbar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadingbar.ForeColor = System.Drawing.Color.Transparent;
            this.loadingbar.Location = new System.Drawing.Point(222, 174);
            this.loadingbar.Minimum = 0;
            this.loadingbar.Name = "loadingbar";
            this.loadingbar.ProgressColor = System.Drawing.Color.DarkViolet;
            this.loadingbar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.loadingbar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.loadingbar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.loadingbar.ProgressThickness = 10;
            this.loadingbar.ShadowDecoration.BorderRadius = 0;
            this.loadingbar.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.loadingbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.loadingbar.Size = new System.Drawing.Size(69, 69);
            this.loadingbar.TabIndex = 27;
            this.loadingbar.Text = "guna2CircleProgressBar1";
            this.loadingbar.UseTransparentBackground = true;
            this.loadingbar.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // ProcessMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(514, 260);
            this.Controls.Add(this.loadingbar);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.lblsecondmessage);
            this.Controls.Add(this.lblfirstmeeage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessMessage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProcessMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private System.Windows.Forms.Label lblsecondmessage;
        private System.Windows.Forms.Label lblfirstmeeage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        public Guna.UI2.WinForms.Guna2CircleProgressBar loadingbar;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}