namespace SMARTLEARN.FrontEnd.MainForm.StudentForm
{
    partial class FESTForgotpass
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnsubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudentid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Animated = true;
            this.btncancel.AutoRoundedCorners = true;
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.BorderRadius = 17;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btncancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(162, 216);
            this.btncancel.Name = "btncancel";
            this.btncancel.ShadowDecoration.Depth = 5;
            this.btncancel.ShadowDecoration.Enabled = true;
            this.btncancel.Size = new System.Drawing.Size(190, 36);
            this.btncancel.TabIndex = 39;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsubmit.Animated = true;
            this.btnsubmit.AutoRoundedCorners = true;
            this.btnsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.BorderRadius = 17;
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnsubmit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.Location = new System.Drawing.Point(162, 174);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.ShadowDecoration.Depth = 5;
            this.btnsubmit.ShadowDecoration.Enabled = true;
            this.btnsubmit.Size = new System.Drawing.Size(190, 36);
            this.btnsubmit.TabIndex = 40;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "STUDENT ID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Forgot Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentid.DefaultText = "";
            this.txtstudentid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstudentid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstudentid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentid.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.ForeColor = System.Drawing.Color.Black;
            this.txtstudentid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentid.Location = new System.Drawing.Point(58, 100);
            this.txtstudentid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.PasswordChar = '\0';
            this.txtstudentid.PlaceholderText = "";
            this.txtstudentid.SelectedText = "";
            this.txtstudentid.Size = new System.Drawing.Size(398, 43);
            this.txtstudentid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtstudentid.TabIndex = 36;
            this.txtstudentid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.guna2Panel3.Location = new System.Drawing.Point(-7, -4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(529, 10);
            this.guna2Panel3.TabIndex = 35;
            // 
            // FESTForgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 260);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FESTForgotpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FESTForgotpass";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Guna.UI2.WinForms.Guna2Button btncancel;
        public Guna.UI2.WinForms.Guna2Button btnsubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtstudentid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}