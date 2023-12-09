namespace SMARTLEARN.FrontEnd
{
    partial class FERemoveImage
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
            this.pictureboxremove = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbids = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnremove = new Guna.UI2.WinForms.Guna2Button();
            this.cbcancel = new Guna.UI2.WinForms.Guna2Button();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxremove)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // pictureboxremove
            // 
            this.pictureboxremove.ImageRotate = 0F;
            this.pictureboxremove.Location = new System.Drawing.Point(12, 12);
            this.pictureboxremove.Name = "pictureboxremove";
            this.pictureboxremove.Size = new System.Drawing.Size(474, 426);
            this.pictureboxremove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxremove.TabIndex = 0;
            this.pictureboxremove.TabStop = false;
            // 
            // cbids
            // 
            this.cbids.BackColor = System.Drawing.Color.Transparent;
            this.cbids.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbids.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbids.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbids.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbids.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbids.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbids.ItemHeight = 30;
            this.cbids.Location = new System.Drawing.Point(584, 147);
            this.cbids.Name = "cbids";
            this.cbids.Size = new System.Drawing.Size(129, 36);
            this.cbids.TabIndex = 1;
            this.cbids.SelectedIndexChanged += new System.EventHandler(this.cbids_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // btnremove
            // 
            this.btnremove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremove.Animated = true;
            this.btnremove.AutoRoundedCorners = true;
            this.btnremove.BackColor = System.Drawing.Color.Transparent;
            this.btnremove.BorderRadius = 26;
            this.btnremove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnremove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnremove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnremove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnremove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.btnremove.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(568, 226);
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Depth = 5;
            this.btnremove.ShadowDecoration.Enabled = true;
            this.btnremove.Size = new System.Drawing.Size(163, 55);
            this.btnremove.TabIndex = 15;
            this.btnremove.Text = "Remove";
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // cbcancel
            // 
            this.cbcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbcancel.Animated = true;
            this.cbcancel.AutoRoundedCorners = true;
            this.cbcancel.BackColor = System.Drawing.Color.Transparent;
            this.cbcancel.BorderRadius = 13;
            this.cbcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbcancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cbcancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cbcancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbcancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cbcancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.cbcancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcancel.ForeColor = System.Drawing.Color.White;
            this.cbcancel.Location = new System.Drawing.Point(681, 409);
            this.cbcancel.Name = "cbcancel";
            this.cbcancel.ShadowDecoration.Depth = 5;
            this.cbcancel.ShadowDecoration.Enabled = true;
            this.cbcancel.Size = new System.Drawing.Size(100, 29);
            this.cbcancel.TabIndex = 15;
            this.cbcancel.Text = "Cancel";
            this.cbcancel.Click += new System.EventHandler(this.cbcancel_Click);
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
            // FERemoveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbcancel);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbids);
            this.Controls.Add(this.pictureboxremove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FERemoveImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FERemoveImage";
            this.Load += new System.EventHandler(this.FERemoveImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxremove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private Guna.UI2.WinForms.Guna2PictureBox pictureboxremove;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbids;
        public Guna.UI2.WinForms.Guna2Button btnremove;
        public Guna.UI2.WinForms.Guna2Button cbcancel;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
    }
}