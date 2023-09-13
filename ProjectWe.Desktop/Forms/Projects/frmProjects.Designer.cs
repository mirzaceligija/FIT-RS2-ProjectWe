namespace ProjectWe.Desktop.Forms.Projects
{
    partial class frmProjects
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
            btnSearch = new Button();
            dgvProjects = new DataGridView();
            cmbCity = new ComboBox();
            label2 = new Label();
            txtProject = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            cmbStatus = new ComboBox();
            errorProvider = new ErrorProvider(components);
            label6 = new Label();
            pictureBox2 = new PictureBox();
            ProjectName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            LastModified = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 122, 255);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(788, 80);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProjects
            // 
            dgvProjects.AllowUserToAddRows = false;
            dgvProjects.AllowUserToDeleteRows = false;
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Columns.AddRange(new DataGridViewColumn[] { ProjectName, Status, Category, City, LastModified, CreatedAt });
            dgvProjects.Location = new Point(10, 112);
            dgvProjects.Margin = new Padding(3, 2, 3, 2);
            dgvProjects.MultiSelect = false;
            dgvProjects.Name = "dgvProjects";
            dgvProjects.ReadOnly = true;
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.RowTemplate.Height = 29;
            dgvProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProjects.Size = new Size(859, 275);
            dgvProjects.TabIndex = 9;
            dgvProjects.CellDoubleClick += dgvProjects_CellDoubleClick;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(158, 81);
            cmbCity.Margin = new Padding(3, 2, 3, 2);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(133, 23);
            cmbCity.TabIndex = 10;
            cmbCity.Validating += cmbCity_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(10, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 12;
            label2.Text = "Project name:";
            // 
            // txtProject
            // 
            txtProject.Location = new Point(10, 81);
            txtProject.Margin = new Padding(3, 2, 3, 2);
            txtProject.Name = "txtProject";
            txtProject.Size = new Size(142, 23);
            txtProject.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(158, 64);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 13;
            label1.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(295, 64);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 15;
            label3.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(295, 81);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(133, 23);
            cmbCategory.TabIndex = 14;
            cmbCategory.Validating += cmbCategory_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(432, 64);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 17;
            label4.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(432, 81);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(133, 23);
            cmbStatus.TabIndex = 16;
            cmbStatus.Validating += cmbStatus_Validating;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(42, 8);
            label6.Name = "label6";
            label6.Size = new Size(151, 30);
            label6.TabIndex = 36;
            label6.Text = "Project Search";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(10, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // ProjectName
            // 
            ProjectName.DataPropertyName = "Name";
            ProjectName.HeaderText = "Name";
            ProjectName.MinimumWidth = 6;
            ProjectName.Name = "ProjectName";
            ProjectName.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // LastModified
            // 
            LastModified.DataPropertyName = "LastModified";
            LastModified.HeaderText = "LastModified";
            LastModified.MinimumWidth = 6;
            LastModified.Name = "LastModified";
            LastModified.ReadOnly = true;
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "CreatedAt";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            // 
            // frmProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 397);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(cmbCategory);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtProject);
            Controls.Add(cmbCity);
            Controls.Add(dgvProjects);
            Controls.Add(btnSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProjects";
            Text = "Projects";
            Load += frmProjects_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvProjects;
        private ComboBox cmbCity;
        private Label label2;
        private TextBox txtProject;
        private Label label1;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label4;
        private ComboBox cmbStatus;
        private ErrorProvider errorProvider;
        private Label label6;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn ProjectName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn LastModified;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}