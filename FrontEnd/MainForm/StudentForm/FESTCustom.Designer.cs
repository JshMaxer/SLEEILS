namespace SMARTLEARN.FrontEnd.MainForm.StudentForm
{
    partial class FESTCustom
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
            this.btndownload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbcustom = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
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
            this.btndownload.TabIndex = 43;
            this.btndownload.Text = "DOWNLOAD";
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click_1);
            // 
            // lbcustom
            // 
            this.lbcustom.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.lbcustom.FormattingEnabled = true;
            this.lbcustom.ItemHeight = 23;
            this.lbcustom.Location = new System.Drawing.Point(12, 12);
            this.lbcustom.Name = "lbcustom";
            this.lbcustom.Size = new System.Drawing.Size(564, 372);
            this.lbcustom.TabIndex = 42;
            // 
            // FESTCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 467);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.lbcustom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FESTCustom";
            this.Text = "FESTCustom";
            this.Load += new System.EventHandler(this.FESTCustom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btndownload;
        private System.Windows.Forms.ListBox lbcustom;
    }
}