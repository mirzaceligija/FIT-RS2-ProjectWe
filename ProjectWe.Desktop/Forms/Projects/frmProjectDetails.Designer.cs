﻿namespace ProjectWe.Desktop.Forms.Projects
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
            cmbStatus = new ComboBox();
            cmbCategory = new ComboBox();
            cmbCity = new ComboBox();
            groupBox1 = new GroupBox();
            txtDescription = new TextBox();
            grpInfo = new GroupBox();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            label10 = new Label();
            btnSave = new Button();
            tabObjective = new TabControl();
            tabPage1 = new TabPage();
            tabOutputs = new TabPage();
            dgvOutputs = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Indicators = new DataGridViewTextBoxColumn();
            MeansOfVerification = new DataGridViewTextBoxColumn();
            tabActivities = new TabPage();
            dgvActivities = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Locations = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            tabBudget = new TabPage();
            dgvBudget = new DataGridView();
            Description = new DataGridViewTextBoxColumn();
            CostPerUnit = new DataGridViewTextBoxColumn();
            NumberOfUnits = new DataGridViewTextBoxColumn();
            TotalCost = new DataGridViewTextBoxColumn();
            lblTotalCostValue = new Label();
            lblTotalCost = new Label();
            dgvObjectives = new DataGridView();
            ObjectiveId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            grpInfo.SuspendLayout();
            tabObjective.SuspendLayout();
            tabPage1.SuspendLayout();
            tabOutputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOutputs).BeginInit();
            tabActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivities).BeginInit();
            tabBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvObjectives).BeginInit();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(113, 58);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(265, 28);
            cmbStatus.TabIndex = 24;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(113, 91);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(265, 28);
            cmbCategory.TabIndex = 22;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(113, 125);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(265, 28);
            cmbCity.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(403, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 173);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(6, 26);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(373, 127);
            txtDescription.TabIndex = 1;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(label11);
            grpInfo.Controls.Add(label8);
            grpInfo.Controls.Add(label9);
            grpInfo.Controls.Add(txtName);
            grpInfo.Controls.Add(cmbStatus);
            grpInfo.Controls.Add(label10);
            grpInfo.Controls.Add(cmbCategory);
            grpInfo.Controls.Add(cmbCity);
            grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpInfo.ForeColor = SystemColors.ControlLightLight;
            grpInfo.Location = new Point(12, 12);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(384, 173);
            grpInfo.TabIndex = 26;
            grpInfo.TabStop = false;
            grpInfo.Text = "Project Info";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(12, 129);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 25;
            label11.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(12, 95);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 6;
            label8.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(12, 62);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 2;
            label9.Text = "Status:";
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(12, 29);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 0;
            label10.Text = "Name:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(694, 409);
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
            tabObjective.Location = new Point(12, 191);
            tabObjective.Name = "tabObjective";
            tabObjective.SelectedIndex = 0;
            tabObjective.Size = new Size(776, 212);
            tabObjective.TabIndex = 29;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvObjectives);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 179);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Objectives";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabOutputs
            // 
            tabOutputs.Controls.Add(dgvOutputs);
            tabOutputs.Location = new Point(4, 29);
            tabOutputs.Name = "tabOutputs";
            tabOutputs.Padding = new Padding(3);
            tabOutputs.Size = new Size(768, 179);
            tabOutputs.TabIndex = 1;
            tabOutputs.Text = "Outputs";
            tabOutputs.UseVisualStyleBackColor = true;
            // 
            // dgvOutputs
            // 
            dgvOutputs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOutputs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutputs.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Indicators, MeansOfVerification });
            dgvOutputs.Location = new Point(7, 18);
            dgvOutputs.MultiSelect = false;
            dgvOutputs.Name = "dgvOutputs";
            dgvOutputs.RowHeadersWidth = 51;
            dgvOutputs.RowTemplate.Height = 29;
            dgvOutputs.Size = new Size(754, 143);
            dgvOutputs.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Indicators
            // 
            Indicators.DataPropertyName = "Indicators";
            Indicators.HeaderText = "Indicators";
            Indicators.MinimumWidth = 6;
            Indicators.Name = "Indicators";
            // 
            // MeansOfVerification
            // 
            MeansOfVerification.DataPropertyName = "MeansOfVerification";
            MeansOfVerification.HeaderText = "MeansOfVerification";
            MeansOfVerification.MinimumWidth = 6;
            MeansOfVerification.Name = "MeansOfVerification";
            // 
            // tabActivities
            // 
            tabActivities.Controls.Add(dgvActivities);
            tabActivities.Location = new Point(4, 29);
            tabActivities.Name = "tabActivities";
            tabActivities.Padding = new Padding(3);
            tabActivities.Size = new Size(768, 179);
            tabActivities.TabIndex = 2;
            tabActivities.Text = "Activities";
            tabActivities.UseVisualStyleBackColor = true;
            // 
            // dgvActivities
            // 
            dgvActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivities.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Locations, StartDate, EndDate });
            dgvActivities.Location = new Point(7, 18);
            dgvActivities.MultiSelect = false;
            dgvActivities.Name = "dgvActivities";
            dgvActivities.RowHeadersWidth = 51;
            dgvActivities.RowTemplate.Height = 29;
            dgvActivities.Size = new Size(754, 143);
            dgvActivities.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            dataGridViewTextBoxColumn1.HeaderText = "Description";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Locations
            // 
            Locations.DataPropertyName = "Locations";
            Locations.HeaderText = "Locations";
            Locations.MinimumWidth = 6;
            Locations.Name = "Locations";
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "StartDate";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "EndDate";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            // 
            // tabBudget
            // 
            tabBudget.Controls.Add(dgvBudget);
            tabBudget.Controls.Add(lblTotalCostValue);
            tabBudget.Controls.Add(lblTotalCost);
            tabBudget.Location = new Point(4, 29);
            tabBudget.Name = "tabBudget";
            tabBudget.Padding = new Padding(3);
            tabBudget.Size = new Size(768, 179);
            tabBudget.TabIndex = 3;
            tabBudget.Text = "Budget";
            tabBudget.UseVisualStyleBackColor = true;
            // 
            // dgvBudget
            // 
            dgvBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudget.Columns.AddRange(new DataGridViewColumn[] { Description, CostPerUnit, NumberOfUnits, TotalCost });
            dgvBudget.Location = new Point(8, 30);
            dgvBudget.MultiSelect = false;
            dgvBudget.Name = "dgvBudget";
            dgvBudget.RowHeadersWidth = 51;
            dgvBudget.RowTemplate.Height = 29;
            dgvBudget.Size = new Size(754, 143);
            dgvBudget.TabIndex = 2;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // CostPerUnit
            // 
            CostPerUnit.DataPropertyName = "CostPerUnit";
            CostPerUnit.HeaderText = "CostPerUnit";
            CostPerUnit.MinimumWidth = 6;
            CostPerUnit.Name = "CostPerUnit";
            // 
            // NumberOfUnits
            // 
            NumberOfUnits.DataPropertyName = "NumberOfUnits";
            NumberOfUnits.HeaderText = "NumberOfUnits";
            NumberOfUnits.MinimumWidth = 6;
            NumberOfUnits.Name = "NumberOfUnits";
            // 
            // TotalCost
            // 
            TotalCost.DataPropertyName = "TotalCost";
            TotalCost.HeaderText = "TotalCost";
            TotalCost.MinimumWidth = 6;
            TotalCost.Name = "TotalCost";
            // 
            // lblTotalCostValue
            // 
            lblTotalCostValue.AutoSize = true;
            lblTotalCostValue.Location = new Point(87, 3);
            lblTotalCostValue.Name = "lblTotalCostValue";
            lblTotalCostValue.Size = new Size(36, 20);
            lblTotalCostValue.TabIndex = 1;
            lblTotalCostValue.Text = "N/A";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCost.Location = new Point(3, 3);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(83, 20);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "Total Cost:";
            // 
            // dgvObjectives
            // 
            dgvObjectives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObjectives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObjectives.Columns.AddRange(new DataGridViewColumn[] { ObjectiveId, dataGridViewTextBoxColumn3 });
            dgvObjectives.Location = new Point(7, 18);
            dgvObjectives.MultiSelect = false;
            dgvObjectives.Name = "dgvObjectives";
            dgvObjectives.RowHeadersWidth = 51;
            dgvObjectives.RowTemplate.Height = 29;
            dgvObjectives.Size = new Size(754, 143);
            dgvObjectives.TabIndex = 5;
            // 
            // ObjectiveId
            // 
            ObjectiveId.DataPropertyName = "ObjectiveId";
            ObjectiveId.HeaderText = "ObjectiveId";
            ObjectiveId.MinimumWidth = 6;
            ObjectiveId.Name = "ObjectiveId";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmProjectDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tabObjective);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(grpInfo);
            Name = "frmProjectDetails";
            Text = "Project Details";
            Load += frmProjectDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            tabObjective.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabOutputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOutputs).EndInit();
            tabActivities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivities).EndInit();
            tabBudget.ResumeLayout(false);
            tabBudget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvObjectives).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbStatus;
        private ComboBox cmbCategory;
        private ComboBox cmbCity;
        private GroupBox groupBox1;
        private TextBox txtDescription;
        private GroupBox grpInfo;
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
        private DataGridViewTextBoxColumn ObjectiveId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}