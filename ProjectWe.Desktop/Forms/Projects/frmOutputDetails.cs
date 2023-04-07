using ProjectWe.Desktop.Services;
using ProjectWe.Models.Requests;
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
    public partial class frmOutputDetails : Form
    {
        public APIService OutputsService { get; set; } = new APIService("Outputs");
        public APIService ObjectivesService { get; set; } = new APIService("Objectives");

        private Models.Output _model = null;

        public frmOutputDetails(Models.Output model)
        {
            InitializeComponent();
            _model = model;
        }

        private async void frmOutputDetails_Load(object sender, EventArgs e)
        {
            if (_model is not null)
            {
                await LoadObjectives();

                txtDescription.Text = _model.Description;
                txtIndicators.Text = _model.Indicators;
                txtMeansOfVerification.Text = _model.MeansOfVerification;
            }
        }

        private async Task LoadObjectives()
        {
            var objectivesSearch = new ObjectiveSearchObject
            {
                ProjectId = _model.ProjectId,
            };
            var objectives = await ObjectivesService.GetList<List<Models.Objective>>(objectivesSearch);

            cmbObjectives.DataSource = objectives;
            cmbObjectives.ValueMember = "ObjectiveId";
            cmbObjectives.DisplayMember = "Description";
            cmbObjectives.SelectedValue = _model.ObjectiveId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren() || _model is null)
            {
                return;
            }

            btnSave.Enabled = false;
            btnSave.Text = "Saving...";

            OutputUpdateRequest updateRequest = new OutputUpdateRequest()
            {
                Description = txtDescription.Text,
                MeansOfVerification = txtMeansOfVerification.Text,
                Indicators = txtIndicators.Text,
                ObjectiveId = (int)cmbObjectives.SelectedValue,
            };

            await OutputsService.Update<Models.Output>(_model.OutputId, updateRequest);

            btnSave.Enabled = true;
            btnSave.Text = "Save";
            this.Hide();
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

        private void cmbObjectives_Validating(object sender, CancelEventArgs e)
        {
            if (cmbObjectives.SelectedItem is null)
            {
                e.Cancel = true;
                cmbObjectives.Focus();
                errorProvider.SetError(cmbObjectives, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbObjectives, "");
            }
        }
    }
}
