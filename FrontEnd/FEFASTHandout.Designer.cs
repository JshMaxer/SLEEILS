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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEFAHandout));
            this.lbhandouts = new System.Windows.Forms.ListBox();
            this.btndownload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Helpforbutton = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.SuspendLayout();
            // 
            // lbhandouts
            // 
            this.lbhandouts.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.lbhandouts.FormattingEnabled = true;
            this.lbhandouts.ItemHeight = 23;
            this.lbhandouts.Location = new System.Drawing.Point(12, 12);
            this.lbhandouts.Name = "lbhandouts";
            this.lbhandouts.Size = new System.Drawing.Size(564, 372);
            this.lbhandouts.TabIndex = 0;
            this.Helpforbutton.SetToolTip(this.lbhandouts, "Double Click the item to view.");
            this.lbhandouts.DoubleClick += new System.EventHandler(this.lbhandouts_DoubleClick);
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
            this.btndownload.Location = new System.Drawing.Point(182, 400);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(224, 49);
            this.btndownload.TabIndex = 41;
            this.btndownload.Text = "DOWNLOAD";
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // MessageDialog1
            // 
            this.MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog1.Caption = "Smart Learn";
            this.MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageDialog1.Parent = this;
            this.MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageDialog1.Text = null;
            // 
            // Helpforbutton
            // 
            this.Helpforbutton.AllowLinksHandling = true;
            this.Helpforbutton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpforbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Helpforbutton.MaximumSize = new System.Drawing.Size(0, 0);
            this.Helpforbutton.TitleFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpforbutton.ToolTipTitle = "Guide";
            // 
            // FEFAHandout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 467);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.lbhandouts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FEFAHandout";
            this.ShowInTaskbar = false;
            this.Text = "FEFAHandout";
            this.Load += new System.EventHandler(this.FEFAHandout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbhandouts;
        private Guna.UI2.WinForms.Guna2GradientButton btndownload;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip Helpforbutton;
    }
}