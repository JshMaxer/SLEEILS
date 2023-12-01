namespace SMARTLEARN.FrontEnd.MainForm.FacultyForms
{
    partial class FEFAHandout
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
            this.btndownload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // lbhandouts
            // 
            this.lbhandouts.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.lbhandouts.FormattingEnabled = true;
            this.lbhandouts.ItemHeight = 23;
            this.lbhandouts.Location = new System.Drawing.Point(12, 12);
            this.lbhandouts.Name = "lbhandouts";
            this.lbhandouts.Size = new System.Drawing.Size(783, 487);
            this.lbhandouts.TabIndex = 0;
            // 
            // btndownload
            // 
            this.btndownload.Animated = true;
            this.btndownload.AnimatedGIF = true;
            this.btndownload.BorderRadius = 10;
            this.btndownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndownload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndownload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btndownload.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndownload.ForeColor = System.Drawing.Color.White;
            this.btndownload.Location = new System.Drawing.Point(290, 532);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(224, 49);
            this.btndownload.TabIndex = 41;
            this.btndownload.Text = "DOWNLOAD";
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // FEFAHandout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 624);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.lbhandouts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEFAHandout";
            this.Text = "FEFAHandout";
            this.Load += new System.EventHandler(this.FEFAHandout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbhandouts;
        private Guna.UI2.WinForms.Guna2GradientButton btndownload;
    }
}