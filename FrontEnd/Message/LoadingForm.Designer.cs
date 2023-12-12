namespace SMARTLEARN.FrontEnd
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.RoundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.loadingbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RoundEdge
            // 
            this.RoundEdge.TargetControl = this;
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
            this.loadingbar.Location = new System.Drawing.Point(12, 12);
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
            this.loadingbar.Size = new System.Drawing.Size(102, 102);
            this.loadingbar.TabIndex = 0;
            this.loadingbar.Text = "guna2CircleProgressBar1";
            this.loadingbar.UseTransparentBackground = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 131);
            this.Controls.Add(this.loadingbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundEdge;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2CircleProgressBar loadingbar;
    }
}