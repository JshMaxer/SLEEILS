﻿namespace SMARTLEARN.FrontEnd.MainForm.StudentForm
{
    partial class FESTGrades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.DGVStudentlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbsemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Grades";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(3, -31);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(937, 10);
            this.guna2Separator1.TabIndex = 28;
            // 
            // DGVStudentlist
            // 
            this.DGVStudentlist.AllowUserToAddRows = false;
            this.DGVStudentlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVStudentlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStudentlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVStudentlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVStudentlist.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVStudentlist.ColumnHeadersHeight = 50;
            this.DGVStudentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVStudentlist.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudentlist.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVStudentlist.EnableHeadersVisualStyles = true;
            this.DGVStudentlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.Location = new System.Drawing.Point(19, 135);
            this.DGVStudentlist.MultiSelect = false;
            this.DGVStudentlist.Name = "DGVStudentlist";
            this.DGVStudentlist.ReadOnly = true;
            this.DGVStudentlist.RowHeadersVisible = false;
            this.DGVStudentlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVStudentlist.Size = new System.Drawing.Size(914, 446);
            this.DGVStudentlist.TabIndex = 37;
            this.DGVStudentlist.TabStop = false;
            this.DGVStudentlist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVStudentlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVStudentlist.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVStudentlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVStudentlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVStudentlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVStudentlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudentlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVStudentlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVStudentlist.ThemeStyle.HeaderStyle.Height = 50;
            this.DGVStudentlist.ThemeStyle.ReadOnly = true;
            this.DGVStudentlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVStudentlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVStudentlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudentlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVStudentlist.ThemeStyle.RowsStyle.Height = 22;
            this.DGVStudentlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVStudentlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Semester";
            // 
            // cbsemester
            // 
            this.cbsemester.BackColor = System.Drawing.Color.Transparent;
            this.cbsemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbsemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbsemester.ItemHeight = 30;
            this.cbsemester.Items.AddRange(new object[] {
            "1st Sem",
            "2nd Sem"});
            this.cbsemester.Location = new System.Drawing.Point(19, 93);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(189, 36);
            this.cbsemester.TabIndex = 40;
            this.cbsemester.TabStop = false;
            this.cbsemester.SelectedIndexChanged += new System.EventHandler(this.cbsemester_SelectedIndexChanged);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(13, 52);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(920, 10);
            this.guna2Separator2.TabIndex = 41;
            // 
            // FESTGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGVStudentlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FESTGrades";
            this.Text = "FESTGrades";
            this.Load += new System.EventHandler(this.FESTGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVStudentlist;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbsemester;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}