namespace SMARTLEARN.FrontEnd.MainForm.FacultyForms
{
    partial class FAFACustomForm
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
            this.btnuploadhandout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbcustom = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btndelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
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
            this.btnuploadhandout.Location = new System.Drawing.Point(108, 402);
            this.btnuploadhandout.Name = "btnuploadhandout";
            this.btnuploadhandout.Size = new System.Drawing.Size(168, 42);
            this.btnuploadhandout.TabIndex = 43;
            this.btnuploadhandout.Text = "UPLOAD";
            this.btnuploadhandout.Click += new System.EventHandler(this.btnuploadhandout_Click);
            // 
            // lbcustom
            // 
            this.lbcustom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbcustom.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcustom.FormattingEnabled = true;
            this.lbcustom.ItemHeight = 23;
            this.lbcustom.Location = new System.Drawing.Point(12, 12);
            this.lbcustom.Name = "lbcustom";
            this.lbcustom.Size = new System.Drawing.Size(564, 372);
            this.lbcustom.TabIndex = 42;
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
            this.btndelete.Location = new System.Drawing.Point(292, 402);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(168, 42);
            this.btndelete.TabIndex = 44;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FAFACustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 467);
            this.Controls.Add(this.btnuploadhandout);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lbcustom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAFACustomForm";
            this.Text = "FACustomForm";
            this.Load += new System.EventHandler(this.FACustomForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnuploadhandout;
        private System.Windows.Forms.ListBox lbcustom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2GradientButton btndelete;
    }
}