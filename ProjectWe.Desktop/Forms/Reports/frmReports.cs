using ProjectWe.Desktop.Enums;
using ProjectWe.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWe.Desktop.Forms.Reports
{
    public partial class frmReports : Form
    {
        public APIService CitiesService { get; set; } = new APIService("Cities");
        public APIService CategoriesService { get; set; } = new APIService("Categories");

        public frmReports()
        {
            InitializeComponent();
        }

        private async void frmReports_Load(object sender, EventArgs e)
        {
            LoadReportTypes();
            await LoadCities();
            await LoadCategories();
        }

        private void LoadReportTypes()
        {
            var reportTypes = Enum.GetValues(typeof(ReportTypesEnum));
            cmbReportType.DataSource = reportTypes;
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SetReportType();
            SetParameters();

            reportViewer.RefreshReport();
        }

        private void SetReportType()
        {
            ReportTypesEnum selectedType = (ReportTypesEnum)cmbReportType.SelectedItem;

            switch (selectedType)
            {
                case ReportTypesEnum.Projects:
                    reportViewer.LocalReport.ReportEmbeddedResource = "ProjectWe.Desktop.Models.Projects.rdlc";
                    break;
                case ReportTypesEnum.Users:
                    reportViewer.LocalReport.ReportEmbeddedResource = "ProjectWe.Desktop.Models.Users.rdlc";
                    break;
                default:
                    break;
            }
        }

        private void SetParameters()
        {
            var prmCityId = new Microsoft.Reporting.WinForms.ReportParameter("CityId");
            prmCityId.Values.Add(cmbCity.SelectedValue.ToString());

            var prmCategoryId = new Microsoft.Reporting.WinForms.ReportParameter("CategoryId");
            prmCategoryId.Values.Add(cmbCategory.SelectedValue.ToString());

            reportViewer.LocalReport.SetParameters(prmCityId);
            reportViewer.LocalReport.SetParameters(prmCategoryId);
        }
    }
}
