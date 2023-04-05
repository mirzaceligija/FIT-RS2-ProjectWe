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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
            btnSearch = new Button();
            dgvProjects = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            StatusId = new DataGridViewTextBoxColumn();
            CityId = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            LastModified = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            cmbCity = new ComboBox();
            label2 = new Label();
            txtProject = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(694, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProjects
            // 
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Columns.AddRange(new DataGridViewColumn[] { Name, StatusId, CityId, CategoryId, LastModified, CreatedAt });
            dgvProjects.Location = new Point(12, 71);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.RowTemplate.Height = 29;
            dgvProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProjects.Size = new Size(776, 367);
            dgvProjects.TabIndex = 9;
            dgvProjects.CellDoubleClick += dgvProjects_CellDoubleClick;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // StatusId
            // 
            StatusId.DataPropertyName = "StatusId";
            StatusId.HeaderText = "StatusId";
            StatusId.MinimumWidth = 6;
            StatusId.Name = "StatusId";
            StatusId.Width = 125;
            // 
            // CityId
            // 
            CityId.DataPropertyName = "CityId";
            CityId.HeaderText = "CityId";
            CityId.MinimumWidth = 6;
            CityId.Name = "CityId";
            CityId.Width = 125;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.Width = 125;
            // 
            // LastModified
            // 
            LastModified.DataPropertyName = "LastModified";
            LastModified.HeaderText = "LastModified";
            LastModified.MinimumWidth = 6;
            LastModified.Name = "LastModified";
            LastModified.Width = 125;
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "CreatedAt";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 125;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(180, 32);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(151, 28);
            cmbCity.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 12;
            label2.Text = "Project name:";
            // 
            // txtProject
            // 
            txtProject.Location = new Point(12, 32);
            txtProject.Name = "txtProject";
            txtProject.Size = new Size(162, 27);
            txtProject.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 13;
            label1.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(337, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 15;
            label3.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(337, 32);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(494, 9);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 17;
            label4.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(494, 32);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 16;
            // 
            // frmProjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
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
            Name = new DataGridViewTextBoxColumn();
            Text = "Projects";
            Load += frmProjects_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
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
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn StatusId;
        private DataGridViewTextBoxColumn CityId;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn LastModified;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}