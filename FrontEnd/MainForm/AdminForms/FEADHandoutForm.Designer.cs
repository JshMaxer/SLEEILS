﻿namespace SMARTLEARN.FrontEnd.MainForm.AdminForms
{
    partial class FEADHandoutForm
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
            this.lbhandouts = new System.Windows.Forms.ListBox();
            this.btnuploadhandout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btndelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // lbhandouts
            // 
            this.lbhandouts.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhandouts.FormattingEnabled = true;
            this.lbhandouts.ItemHeight = 23;
            this.lbhandouts.Location = new System.Drawing.Point(12, 10);
            this.lbhandouts.Name = "lbhandouts";
            this.lbhandouts.Size = new System.Drawing.Size(783, 510);
            this.lbhandouts.TabIndex = 0;
            // 
            // btnuploadhandout
            // 
            this.btnuploadhandout.Animated = true;
            this.btnuploadhandout.AnimatedGIF = true;
            this.btnuploadhandout.BorderRadius = 10;
            this.btnuploadhandout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnuploadhandout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnuploadhandout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnuploadhandout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnuploadhandout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnuploadhandout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnuploadhandout.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuploadhandout.ForeColor = System.Drawing.Color.White;
            this.btnuploadhandout.Location = new System.Drawing.Point(196, 553);
            this.btnuploadhandout.Name = "btnuploadhandout";
            this.btnuploadhandout.Size = new System.Drawing.Size(168, 42);
            this.btnuploadhandout.TabIndex = 41;
            this.btnuploadhandout.Text = "UPLOAD";
            this.btnuploadhandout.Click += new System.EventHandler(this.btnuploadhandout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btndelete
            // 
            this.btndelete.Animated = true;
            this.btndelete.AnimatedGIF = true;
            this.btndelete.BorderRadius = 10;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btndelete.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(380, 553);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(168, 42);
            this.btndelete.TabIndex = 41;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FEADHandoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 624);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnuploadhandout);
            this.Controls.Add(this.lbhandouts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEADHandoutForm";
            this.Text = "FEADHandoutForm";
            this.Load += new System.EventHandler(this.FEADHandoutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbhandouts;
        private Guna.UI2.WinForms.Guna2GradientButton btnuploadhandout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2GradientButton btndelete;
    }
}