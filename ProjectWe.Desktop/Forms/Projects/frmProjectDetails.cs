using ProjectWe.Desktop.Services;
using ProjectWe.Models;
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
            //TODO: Filter by ProjectId
            var outputs = await OutputsService.GetList<List<Models.Output>>();
            dgvOutputs.AutoGenerateColumns = false;
            dgvOutputs.DataSource = outputs;
        }

        private async Task LoadActivities()
        {
            //TODO: Filter by ProjectId
            var activities = await ActivitiesService.GetList<List<Models.Activity>>();
            dgvActivities.AutoGenerateColumns = false;
            dgvActivities.DataSource = activities;
        }

        private async Task LoadBudget()
        {
            //TODO: Filter by ProjectId
            string currency = "BAM";
            var budget = await BudgetsService.GetList<List<Models.Budget>>();
            dgvBudget.AutoGenerateColumns = false;
            dgvBudget.DataSource = budget;

            double totalCost = 0.00;
            foreach (var item in budget)
            {
                totalCost += (double)item.TotalCost;
            }
            lblTotalCostValue.Text = currency + totalCost.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
