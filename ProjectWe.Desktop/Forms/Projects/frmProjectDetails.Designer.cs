namespace ProjectWe.Desktop.Forms.Projects
{
    partial class frmProjectDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDetails));
            cmbStatus = new ComboBox();
            cmbCategory = new ComboBox();
            cmbCity = new ComboBox();
            txtDescription = new TextBox();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            label10 = new Label();
            btnSave = new Button();
            tabObjective = new TabControl();
            tabPage1 = new TabPage();
            btnObjectivesRefresh = new Button();
            dgvObjectives = new DataGridView();
            ObjectiveId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tabOutputs = new TabPage();
            btnOutputRefresh = new Button();
            dgvOutputs = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Indicators = new DataGridViewTextBoxColumn();
            MeansOfVerification = new DataGridViewTextBoxColumn();
            tabActivities = new TabPage();
            btnRefreshActivities = new Button();
            dgvActivities = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Locations = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            tabBudget = new TabPage();
            btnRefreshBudget = new Button();
            dgvBudget = new DataGridView();
            Description = new DataGridViewTextBoxColumn();
            CostPerUnit = new DataGridViewTextBoxColumn();
            NumberOfUnits = new DataGridViewTextBoxColumn();
            TotalCost = new DataGridViewTextBoxColumn();
            lblTotalCostValue = new Label();
            lblTotalCost = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            label2 = new Label();
            dgvReviews = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            StatusId = new DataGridViewTextBoxColumn();
            LastModified = new DataGridViewTextBoxColumn();
            btnReviewsRefresh = new Button();
            txtReview = new TextBox();
            btnAddReview = new Button();
            label3 = new Label();
            cmbReivewStatus = new ComboBox();
            tabObjective.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjectives).BeginInit();
            tabOutputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOutputs).BeginInit();
            tabActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivities).BeginInit();
            tabBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).BeginInit();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.Enabled = false;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(16, 165);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(296, 28);
            cmbStatus.TabIndex = 24;
            cmbStatus.Validating += cmbStatus_Validating;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(16, 219);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(296, 28);
            cmbCategory.TabIndex = 22;
            cmbCategory.Validating += cmbCategory_Validating;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(16, 273);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(296, 28);
            cmbCity.TabIndex = 18;
            cmbCity.Validating += cmbCity_Validating;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(354, 112);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(430, 189);
            txtDescription.TabIndex = 1;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(16, 250);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 25;
            label11.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(16, 196);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 6;
            label8.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(16, 142);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 2;
            label9.Text = "Status:";
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 27);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(14, 89);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 0;
            label10.Text = "Name:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 122, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(690, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tabObjective
            // 
            tabObjective.Controls.Add(tabPage1);
            tabObjective.Controls.Add(tabOutputs);
            tabObjective.Controls.Add(tabActivities);
            tabObjective.Controls.Add(tabBudget);
            tabObjective.Location = new Point(12, 342);
            tabObjective.Name = "tabObjective";
            tabObjective.SelectedIndex = 0;
            tabObjective.Size = new Size(776, 367);
            tabObjective.TabIndex = 29;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnObjectivesRefresh);
            tabPage1.Controls.Add(dgvObjectives);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 334);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Objectives";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnObjectivesRefresh
            // 
            btnObjectivesRefresh.BackColor = Color.White;
            btnObjectivesRefresh.FlatStyle = FlatStyle.Flat;
            btnObjectivesRefresh.Location = new Point(667, 14);
            btnObjectivesRefresh.Name = "btnObjectivesRefresh";
            btnObjectivesRefresh.Size = new Size(94, 29);
            btnObjectivesRefresh.TabIndex = 12;
            btnObjectivesRefresh.Text = "Refresh";
            btnObjectivesRefresh.UseVisualStyleBackColor = false;
            btnObjectivesRefresh.Click += btnObjectivesRefresh_Click;
            // 
            // dgvObjectives
            // 
            dgvObjectives.AllowUserToAddRows = false;
            dgvObjectives.AllowUserToDeleteRows = false;
            dgvObjectives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObjectives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObjectives.Columns.AddRange(new DataGridViewColumn[] { ObjectiveId, dataGridViewTextBoxColumn3 });
            dgvObjectives.Location = new Point(7, 49);
            dgvObjectives.MultiSelect = false;
            dgvObjectives.Name = "dgvObjectives";
            dgvObjectives.ReadOnly = true;
            dgvObjectives.RowHeadersWidth = 51;
            dgvObjectives.RowTemplate.Height = 29;
            dgvObjectives.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvObjectives.Size = new Size(754, 279);
            dgvObjectives.TabIndex = 5;
            dgvObjectives.CellDoubleClick += dgvObjectives_CellDoubleClick;
            // 
            // ObjectiveId
            // 
            ObjectiveId.DataPropertyName = "ObjectiveId";
            ObjectiveId.HeaderText = "ObjectiveId";
            ObjectiveId.MinimumWidth = 6;
            ObjectiveId.Name = "ObjectiveId";
            ObjectiveId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabOutputs
            // 
            tabOutputs.Controls.Add(btnOutputRefresh);
            tabOutputs.Controls.Add(dgvOutputs);
            tabOutputs.Location = new Point(4, 29);
            tabOutputs.Name = "tabOutputs";
            tabOutputs.Padding = new Padding(3);
            tabOutputs.Size = new Size(768, 334);
            tabOutputs.TabIndex = 1;
            tabOutputs.Text = "Outputs";
            tabOutputs.UseVisualStyleBackColor = true;
            // 
            // btnOutputRefresh
            // 
            btnOutputRefresh.BackColor = Color.White;
            btnOutputRefresh.FlatStyle = FlatStyle.Flat;
            btnOutputRefresh.Location = new Point(667, 14);
            btnOutputRefresh.Name = "btnOutputRefresh";
            btnOutputRefresh.Size = new Size(94, 29);
            btnOutputRefresh.TabIndex = 11;
            btnOutputRefresh.Text = "Refresh";
            btnOutputRefresh.UseVisualStyleBackColor = false;
            btnOutputRefresh.Click += btnOutputRefresh_Click;
            // 
            // dgvOutputs
            // 
            dgvOutputs.AllowUserToAddRows = false;
            dgvOutputs.AllowUserToDeleteRows = false;
            dgvOutputs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOutputs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutputs.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Indicators, MeansOfVerification });
            dgvOutputs.Location = new Point(7, 49);
            dgvOutputs.MultiSelect = false;
            dgvOutputs.Name = "dgvOutputs";
            dgvOutputs.ReadOnly = true;
            dgvOutputs.RowHeadersWidth = 51;
            dgvOutputs.RowTemplate.Height = 29;
            dgvOutputs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOutputs.Size = new Size(754, 279);
            dgvOutputs.TabIndex = 4;
            dgvOutputs.CellDoubleClick += dgvOutputs_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Indicators
            // 
            Indicators.DataPropertyName = "Indicators";
            Indicators.HeaderText = "Indicators";
            Indicators.MinimumWidth = 6;
            Indicators.Name = "Indicators";
            Indicators.ReadOnly = true;
            // 
            // MeansOfVerification
            // 
            MeansOfVerification.DataPropertyName = "MeansOfVerification";
            MeansOfVerification.HeaderText = "MeansOfVerification";
            MeansOfVerification.MinimumWidth = 6;
            MeansOfVerification.Name = "MeansOfVerification";
            MeansOfVerification.ReadOnly = true;
            // 
            // tabActivities
            // 
            tabActivities.Controls.Add(btnRefreshActivities);
            tabActivities.Controls.Add(dgvActivities);
            tabActivities.Location = new Point(4, 29);
            tabActivities.Name = "tabActivities";
            tabActivities.Padding = new Padding(3);
            tabActivities.Size = new Size(768, 334);
            tabActivities.TabIndex = 2;
            tabActivities.Text = "Activities";
            tabActivities.UseVisualStyleBackColor = true;
            // 
            // btnRefreshActivities
            // 
            btnRefreshActivities.BackColor = Color.White;
            btnRefreshActivities.FlatStyle = FlatStyle.Flat;
            btnRefreshActivities.Location = new Point(667, 14);
            btnRefreshActivities.Name = "btnRefreshActivities";
            btnRefreshActivities.Size = new Size(94, 29);
            btnRefreshActivities.TabIndex = 10;
            btnRefreshActivities.Text = "Refresh";
            btnRefreshActivities.UseVisualStyleBackColor = false;
            btnRefreshActivities.Click += btnRefreshActivities_Click;
            // 
            // dgvActivities
            // 
            dgvActivities.AllowUserToAddRows = false;
            dgvActivities.AllowUserToDeleteRows = false;
            dgvActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivities.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Locations, StartDate, EndDate });
            dgvActivities.Location = new Point(7, 49);
            dgvActivities.MultiSelect = false;
            dgvActivities.Name = "dgvActivities";
            dgvActivities.ReadOnly = true;
            dgvActivities.RowHeadersWidth = 51;
            dgvActivities.RowTemplate.Height = 29;
            dgvActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivities.Size = new Size(754, 279);
            dgvActivities.TabIndex = 3;
            dgvActivities.CellDoubleClick += dgvActivities_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            dataGridViewTextBoxColumn1.HeaderText = "Description";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Locations
            // 
            Locations.DataPropertyName = "Locations";
            Locations.HeaderText = "Locations";
            Locations.MinimumWidth = 6;
            Locations.Name = "Locations";
            Locations.ReadOnly = true;
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "StartDate";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "EndDate";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            // 
            // tabBudget
            // 
            tabBudget.Controls.Add(btnRefreshBudget);
            tabBudget.Controls.Add(dgvBudget);
            tabBudget.Controls.Add(lblTotalCostValue);
            tabBudget.Controls.Add(lblTotalCost);
            tabBudget.Location = new Point(4, 29);
            tabBudget.Name = "tabBudget";
            tabBudget.Padding = new Padding(3);
            tabBudget.Size = new Size(768, 334);
            tabBudget.TabIndex = 3;
            tabBudget.Text = "Budget";
            tabBudget.UseVisualStyleBackColor = true;
            // 
            // btnRefreshBudget
            // 
            btnRefreshBudget.BackColor = Color.White;
            btnRefreshBudget.FlatStyle = FlatStyle.Flat;
            btnRefreshBudget.Location = new Point(668, 14);
            btnRefreshBudget.Name = "btnRefreshBudget";
            btnRefreshBudget.Size = new Size(94, 29);
            btnRefreshBudget.TabIndex = 9;
            btnRefreshBudget.Text = "Refresh";
            btnRefreshBudget.UseVisualStyleBackColor = false;
            btnRefreshBudget.Click += btnRefreshBudget_Click;
            // 
            // dgvBudget
            // 
            dgvBudget.AllowUserToAddRows = false;
            dgvBudget.AllowUserToDeleteRows = false;
            dgvBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudget.Columns.AddRange(new DataGridViewColumn[] { Description, CostPerUnit, NumberOfUnits, TotalCost });
            dgvBudget.Location = new Point(8, 49);
            dgvBudget.MultiSelect = false;
            dgvBudget.Name = "dgvBudget";
            dgvBudget.ReadOnly = true;
            dgvBudget.RowHeadersWidth = 51;
            dgvBudget.RowTemplate.Height = 29;
            dgvBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBudget.Size = new Size(754, 279);
            dgvBudget.TabIndex = 2;
            dgvBudget.CellDoubleClick += dgvBudget_CellDoubleClick;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // CostPerUnit
            // 
            CostPerUnit.DataPropertyName = "CostPerUnit";
            CostPerUnit.HeaderText = "CostPerUnit";
            CostPerUnit.MinimumWidth = 6;
            CostPerUnit.Name = "CostPerUnit";
            CostPerUnit.ReadOnly = true;
            // 
            // NumberOfUnits
            // 
            NumberOfUnits.DataPropertyName = "NumberOfUnits";
            NumberOfUnits.HeaderText = "NumberOfUnits";
            NumberOfUnits.MinimumWidth = 6;
            NumberOfUnits.Name = "NumberOfUnits";
            NumberOfUnits.ReadOnly = true;
            // 
            // TotalCost
            // 
            TotalCost.DataPropertyName = "TotalCost";
            TotalCost.HeaderText = "TotalCost";
            TotalCost.MinimumWidth = 6;
            TotalCost.Name = "TotalCost";
            TotalCost.ReadOnly = true;
            // 
            // lblTotalCostValue
            // 
            lblTotalCostValue.AutoSize = true;
            lblTotalCostValue.Location = new Point(99, 18);
            lblTotalCostValue.Name = "lblTotalCostValue";
            lblTotalCostValue.Size = new Size(36, 20);
            lblTotalCostValue.TabIndex = 1;
            lblTotalCostValue.Text = "N/A";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCost.Location = new Point(10, 18);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(83, 20);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "Total Cost:";
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
            label6.Size = new Size(187, 37);
            label6.TabIndex = 37;
            label6.Text = "Project Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(354, 89);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 39;
            label1.Text = "Description:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(846, 385);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 40;
            label2.Text = "Review History";
            // 
            // dgvReviews
            // 
            dgvReviews.AllowUserToAddRows = false;
            dgvReviews.AllowUserToDeleteRows = false;
            dgvReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReviews.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, StatusId, LastModified });
            dgvReviews.Location = new Point(846, 420);
            dgvReviews.MultiSelect = false;
            dgvReviews.Name = "dgvReviews";
            dgvReviews.ReadOnly = true;
            dgvReviews.RowHeadersWidth = 51;
            dgvReviews.RowTemplate.Height = 29;
            dgvReviews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReviews.Size = new Size(490, 289);
            dgvReviews.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            dataGridViewTextBoxColumn4.HeaderText = "Description";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // StatusId
            // 
            StatusId.DataPropertyName = "StatusId";
            StatusId.HeaderText = "StatusId";
            StatusId.MinimumWidth = 6;
            StatusId.Name = "StatusId";
            StatusId.ReadOnly = true;
            // 
            // LastModified
            // 
            LastModified.DataPropertyName = "LastModified";
            LastModified.HeaderText = "LastModified";
            LastModified.MinimumWidth = 6;
            LastModified.Name = "LastModified";
            LastModified.ReadOnly = true;
            // 
            // btnReviewsRefresh
            // 
            btnReviewsRefresh.BackColor = Color.White;
            btnReviewsRefresh.FlatStyle = FlatStyle.Flat;
            btnReviewsRefresh.Location = new Point(1242, 385);
            btnReviewsRefresh.Name = "btnReviewsRefresh";
            btnReviewsRefresh.Size = new Size(94, 29);
            btnReviewsRefresh.TabIndex = 42;
            btnReviewsRefresh.Text = "Refresh";
            btnReviewsRefresh.UseVisualStyleBackColor = false;
            btnReviewsRefresh.Click += btnReviewsRefresh_Click;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(846, 145);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.ScrollBars = ScrollBars.Vertical;
            txtReview.Size = new Size(490, 156);
            txtReview.TabIndex = 43;
            txtReview.Validating += txtReview_Validating;
            // 
            // btnAddReview
            // 
            btnAddReview.BackColor = Color.FromArgb(4, 200, 200);
            btnAddReview.FlatAppearance.BorderSize = 0;
            btnAddReview.FlatStyle = FlatStyle.Flat;
            btnAddReview.ForeColor = SystemColors.ControlLightLight;
            btnAddReview.Location = new Point(1242, 307);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(94, 29);
            btnAddReview.TabIndex = 44;
            btnAddReview.Text = "Add";
            btnAddReview.UseVisualStyleBackColor = false;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(846, 89);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 45;
            label3.Text = "Review:";
            // 
            // cmbReivewStatus
            // 
            cmbReivewStatus.FormattingEnabled = true;
            cmbReivewStatus.Location = new Point(846, 111);
            cmbReivewStatus.Name = "cmbReivewStatus";
            cmbReivewStatus.Size = new Size(490, 28);
            cmbReivewStatus.TabIndex = 46;
            cmbReivewStatus.Validating += cmbReivewStatus_Validating;
            // 
            // frmProjectDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 721);
            Controls.Add(cmbReivewStatus);
            Controls.Add(label3);
            Controls.Add(btnAddReview);
            Controls.Add(txtReview);
            Controls.Add(btnReviewsRefresh);
            Controls.Add(dgvReviews);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(tabObjective);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(label10);
            Controls.Add(cmbCategory);
            Controls.Add(cmbCity);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProjectDetails";
            Text = "Project Details";
            Load += frmProjectDetails_Load;
            tabObjective.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvObjectives).EndInit();
            tabOutputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOutputs).EndInit();
            tabActivities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivities).EndInit();
            tabBudget.ResumeLayout(false);
            tabBudget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbStatus;
        private ComboBox cmbCategory;
        private ComboBox cmbCity;
        private TextBox txtDescription;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private Label label10;
        private Label label11;
        private Button btnSave;
        private TabControl tabObjective;
        private TabPage tabPage1;
        private TabPage tabOutputs;
        private TabPage tabActivities;
        private TabPage tabBudget;
        private Label lblTotalCost;
        private Label lblTotalCostValue;
        private DataGridView dgvBudget;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CostPerUnit;
        private DataGridViewTextBoxColumn NumberOfUnits;
        private DataGridViewTextBoxColumn TotalCost;
        private DataGridView dgvActivities;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Locations;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridView dgvOutputs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Indicators;
        private DataGridViewTextBoxColumn MeansOfVerification;
        private DataGridView dgvObjectives;
        private Button btnRefreshBudget;
        private Button btnRefreshActivities;
        private Button btnOutputRefresh;
        private Button btnObjectivesRefresh;
        private DataGridViewTextBoxColumn ObjectiveId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label1;
        private ErrorProvider errorProvider;
        private Label label2;
        private DataGridView dgvReviews;
        private Button btnReviewsRefresh;
        private Button btnAddReview;
        private TextBox txtReview;
        private Label label3;
        private ComboBox cmbReivewStatus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn StatusId;
        private DataGridViewTextBoxColumn LastModified;
    }
}