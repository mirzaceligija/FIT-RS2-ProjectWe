namespace ProjectWe.Desktop.Forms.Reports
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label2 = new Label();
            cmbCity = new ComboBox();
            btnGenerate = new Button();
            cmbReportType = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(12, 150);
            reportViewer.Name = "ReportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(982, 366);
            reportViewer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(50, 9);
            label6.Name = "label6";
            label6.Size = new Size(107, 37);
            label6.TabIndex = 37;
            label6.Text = "Reports";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(327, 88);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 44;
            label3.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(327, 111);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(170, 88);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 42;
            label2.Text = "City:";
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(170, 111);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(151, 28);
            cmbCity.TabIndex = 41;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(0, 122, 255);
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = SystemColors.ControlLightLight;
            btnGenerate.Location = new Point(900, 111);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 45;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(13, 111);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(151, 28);
            cmbReportType.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(13, 88);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 47;
            label1.Text = "ReportType:";
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 529);
            Controls.Add(label1);
            Controls.Add(cmbReportType);
            Controls.Add(btnGenerate);
            Controls.Add(label3);
            Controls.Add(cmbCategory);
            Controls.Add(label2);
            Controls.Add(cmbCity);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(reportViewer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReports";
            Text = "Reports";
            Load += frmReports_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label2;
        private ComboBox cmbCity;
        private Button btnGenerate;
        private ComboBox cmbReportType;
        private Label label1;
    }
}