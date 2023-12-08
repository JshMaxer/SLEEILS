namespace SMARTLEARN.FrontEnd
{
    partial class FEForumMessage
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
            this.btnpost = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // btnpost
            // 
            this.btnpost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpost.Animated = true;
            this.btnpost.AutoRoundedCorners = true;
            this.btnpost.BackColor = System.Drawing.Color.Transparent;
            this.btnpost.BorderRadius = 16;
            this.btnpost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnpost.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpost.ForeColor = System.Drawing.Color.White;
            this.btnpost.Location = new System.Drawing.Point(949, 529);
            this.btnpost.Name = "btnpost";
            this.btnpost.ShadowDecoration.Depth = 5;
            this.btnpost.ShadowDecoration.Enabled = true;
            this.btnpost.Size = new System.Drawing.Size(96, 34);
            this.btnpost.TabIndex = 15;
            this.btnpost.Text = "Post";
            this.btnpost.Click += new System.EventHandler(this.btnpost_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Animated = true;
            this.btnclose.AutoRoundedCorners = true;
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BorderRadius = 16;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnclose.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(847, 529);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Depth = 5;
            this.btnclose.ShadowDecoration.Enabled = true;
            this.btnclose.Size = new System.Drawing.Size(96, 34);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1034, 511);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // FEForumMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1058, 575);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnpost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEForumMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEForumMessage";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        public Guna.UI2.WinForms.Guna2Button btnpost;
        public Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}