namespace SMARTLEARN.FrontEnd.Message
{
    partial class ProcessDeclineMessage
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
            this.loadingbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.BorderRadius = 8;
            this.RoundEdge.TargetControl = this;
            // 
            // loadingbar
            // 
            this.loadingbar.Animated = true;
            this.loadingbar.AnimationSpeed = 5F;
            this.loadingbar.BackColor = System.Drawing.Color.Transparent;
            this.loadingbar.Backwards = true;
            this.loadingbar.FillColor = System.Drawing.Color.Transparent;
            this.loadingbar.FillThickness = 1;
            this.loadingbar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadingbar.ForeColor = System.Drawing.Color.Transparent;
            this.loadingbar.Location = new System.Drawing.Point(226, 174);
            this.loadingbar.Minimum = 0;
            this.loadingbar.Name = "loadingbar";
            this.loadingbar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.loadingbar.ProgressColor2 = System.Drawing.Color.Crimson;
            this.loadingbar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.loadingbar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.loadingbar.ProgressThickness = 10;
            this.loadingbar.ShadowDecoration.BorderRadius = 0;
            this.loadingbar.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.loadingbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.loadingbar.Size = new System.Drawing.Size(69, 69);
            this.loadingbar.TabIndex = 31;
            this.loadingbar.Text = "guna2CircleProgressBar1";
            this.loadingbar.UseTransparentBackground = true;
            this.loadingbar.Value = 50;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.guna2Panel3.Location = new System.Drawing.Point(-1, -1);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(523, 10);
            this.guna2Panel3.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 45);
            this.label2.TabIndex = 29;
            this.label2.Text = "TRY AGAIN LATER!";
            // 
            // lblmessage
            // 
            this.lblmessage.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(-4, 12);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(529, 90);
            this.lblmessage.TabIndex = 28;
            this.lblmessage.Text = "YOUR ENROLLMENT CANNOT\r\nBE PROCESS!";
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProcessDeclineMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(514, 260);
            this.Controls.Add(this.loadingbar);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessDeclineMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessDeclineMessage";
            this.Load += new System.EventHandler(this.ProcessDeclineMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        public Guna.UI2.WinForms.Guna2CircleProgressBar loadingbar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Timer timer1;
    }
}