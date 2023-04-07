﻿using ProjectWe.Desktop.Services;
using ProjectWe.Models;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWe.Desktop.Forms.Projects
{
    public partial class frmProjectDetails : Form
    {
        public APIService ProjectsService { get; set; } = new APIService("Projects");
        public APIService CitiesService { get; set; } = new APIService("Cities");
        public APIService CategoriesService { get; set; } = new APIService("Categories");
        public APIService StatusesService { get; set; } = new APIService("Statuses");
        public APIService BudgetsService { get; set; } = new APIService("Budgets");
        public APIService ActivitiesService { get; set; } = new APIService("Activities");
        public APIService OutputsService { get; set; } = new APIService("Outputs");
        public APIService ObjectivesService { get; set; } = new APIService("Objectives");


        private Project _model = null;

        public frmProjectDetails(Project model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private async void frmProjectDetails_Load(object sender, EventArgs e)
        {
            if (_model is not null)
            {
                await LoadCities();
                await LoadCategories();
                await LoadStatuses();
                await LoadBudget();
                await LoadActivities();
                await LoadOutputs();
                await LoadObjectives();

                txtName.Text = _model.Name;
                txtDescription.Text = _model.Description;
                cmbStatus.SelectedValue = _model.StatusId;
                cmbCity.SelectedValue = _model.CityId;
                cmbCategory.SelectedValue = _model.CategoryId;
            }
        }

        private async Task LoadCities()
        {
            var cities = await CitiesService.GetList<List<Models.City>>();
            cmbCity.DataSource = cities;
            cmbCity.ValueMember = "CityId";
            cmbCity.DisplayMember = "Name";
        }

        private async Task LoadCategories()
        {
            var categories = await CategoriesService.GetList<List<Models.Category>>();
            cmbCategory.DataSource = categories;
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DisplayMember = "Name";
        }

        private async Task LoadStatuses()
        {
            var statuses = await StatusesService.GetList<List<Models.Status>>();
            cmbStatus.DataSource = statuses;
            cmbStatus.ValueMember = "StatusId";
            cmbStatus.DisplayMember = "Name";
        }

        private async Task LoadObjectives()
        {
            //TODO: Filter by ProjectId
            var objectives = await ObjectivesService.GetList<List<Models.Objective>>();
            dgvObjectives.AutoGenerateColumns = false;
            dgvObjectives.DataSource = objectives;
        }

        private async Task LoadOutputs()
        {
            var outputSearch = new OutputSearchObject
            {
                ProjectId = _model.ProjectId,
            };
            var outputs = await OutputsService.GetList<List<Models.Output>>(outputSearch);
            dgvOutputs.AutoGenerateColumns = false;
            dgvOutputs.DataSource = outputs;
        }

        private async Task LoadActivities()
        {
            var activitySearch = new ActivitySearchObject
            {
                ProjectId = _model.ProjectId,
            };
            var activities = await ActivitiesService.GetList<List<Models.Activity>>(activitySearch);
            dgvActivities.AutoGenerateColumns = false;
            dgvActivities.DataSource = activities;
        }

        private async Task LoadBudget()
        {
            var budgetSearch = new BudgetSearchObject
            {
                ProjectId = _model.ProjectId
            };
            var budget = await BudgetsService.GetList<List<Models.Budget>>(budgetSearch);
            dgvBudget.AutoGenerateColumns = false;
            dgvBudget.DataSource = budget;

            string currency = "BAM";
            double totalCost = 0.00;
            foreach (var item in budget)
            {
                totalCost += (double)item.TotalCost;
            }
            lblTotalCostValue.Text = currency + totalCost.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren() || _model is null)
            {
                return;
            }

            ProjectUpdateRequest updateRequest = new ProjectUpdateRequest()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                StatusId = (int)cmbStatus.SelectedValue,
                CategoryId = (int)cmbCategory.SelectedValue,
                CityId = (int)cmbCity.SelectedValue,
            };

            await ProjectsService.Update<Models.Project>(_model.ProjectId, updateRequest);
            this.Hide();
        }

        private void dgvBudget_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var budgetItem = dgvBudget.SelectedRows[0].DataBoundItem as Models.Budget;

            frmBudgetItem frmBudgetItem = new frmBudgetItem(budgetItem);
            frmBudgetItem.ShowDialog();
        }

        private async void btnRefreshBudget_Click(object sender, EventArgs e)
        {
            await LoadBudget();
        }

        private void dgvActivities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var activityItem = dgvActivities.SelectedRows[0].DataBoundItem as Models.Activity;

            frmActivityDetails frmActivityDetails = new frmActivityDetails(activityItem);
            frmActivityDetails.ShowDialog();
        }

        private async void btnRefreshActivities_Click(object sender, EventArgs e)
        {
            await LoadActivities();
        }

        private void dgvOutputs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var outputItem = dgvOutputs.SelectedRows[0].DataBoundItem as Models.Output;

            frmOutputDetails frmOutputDetails = new frmOutputDetails(outputItem);
            frmOutputDetails.ShowDialog();
        }

        private async void btnOutputRefresh_Click(object sender, EventArgs e)
        {
            await LoadOutputs();
        }

        private async void btnObjectivesRefresh_Click(object sender, EventArgs e)
        {
            await LoadObjectives();
        }

        private void dgvObjectives_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var objectiveItem = dgvObjectives.SelectedRows[0].DataBoundItem as Models.Objective;

            frmObjectiveDetails frmObjectiveDetails = new frmObjectiveDetails(objectiveItem);
            frmObjectiveDetails.ShowDialog();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider.SetError(txtName, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtName, "");
            }
        }

        private void cmbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (cmbStatus.SelectedItem is null)
            {
                e.Cancel = true;
                cmbStatus.Focus();
                errorProvider.SetError(cmbStatus, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbStatus, "");
            }
        }

        private void cmbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCategory.SelectedItem is null)
            {
                e.Cancel = true;
                cmbCategory.Focus();
                errorProvider.SetError(cmbCategory, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbCategory, "");
            }
        }

        private void cmbCity_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCity.SelectedItem is null)
            {
                e.Cancel = true;
                cmbCity.Focus();
                errorProvider.SetError(cmbCity, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbCity, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider.SetError(txtDescription, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDescription, "");
            }
        }
    }
}
