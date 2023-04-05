using ProjectWe.Desktop.Services;
using ProjectWe.Models.Extensions;
using ProjectWe.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWe.Desktop.Forms.Projects
{
    public partial class frmProjects : Form
    {
        public APIService ProjectsService { get; set; } = new APIService("Projects");
        public APIService CitiesService { get; set; } = new APIService("Cities");
        public APIService CategoriesService { get; set; } = new APIService("Categories");
        public APIService StatusesService { get; set; } = new APIService("Statuses");

        public frmProjects()
        {
            InitializeComponent();
            dgvProjects.AutoGenerateColumns = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searchObject = new ProjectSearchObject
            {
                Name = txtProject.Text,
                CityId = (int)cmbCity.SelectedValue,
                CategoryId = (int)cmbCategory.SelectedValue,
                StatusId = (int)cmbStatus.SelectedValue,
            };

            var projects = await ProjectsService.GetList<List<Models.Project>>(searchObject);
            dgvProjects.DataSource = projects;
        }

        private async void frmProjects_Load(object sender, EventArgs e)
        {
            await LoadCities();
            await LoadCategories();
            await LoadStatuses();
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

        private void dgvProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var project = dgvProjects.SelectedRows[0].DataBoundItem as Models.Project;

            frmProjectDetails frmProjectDetails = new frmProjectDetails(project);
            frmProjectDetails.ShowDialog();
        }
    }
}
