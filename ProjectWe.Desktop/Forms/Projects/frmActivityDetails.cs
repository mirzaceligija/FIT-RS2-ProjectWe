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
    public partial class frmActivityDetails : Form
    {
        public APIService ActivitiesService { get; set; } = new APIService("Activities");
        public APIService OutputsService { get; set; } = new APIService("Outputs");


        private Models.Activity _model = null;
        public frmActivityDetails(Models.Activity model)
        {
            InitializeComponent();
            _model = model;
        }

        private async void frmActivityDetails_Load(object sender, EventArgs e)
        {
            if (_model is not null)
            {
                await LoadOutputs();

                txtDescription.Text = _model.Description;
                txtDirBenef.Text = _model.DirectBeneficiaries;
                txtLocation.Text = _model.Locations;
                txtIndirBenef.Text = _model.IndirectBeneficiaries;
                dtpStartDate.Value = (DateTime)_model.StartDate;
                dtpEndDate.Value = (DateTime)_model.EndDate;
            }
        }

        private async Task LoadOutputs()
        {
            var outputSearch = new OutputSearchObject
            {
                ProjectId = _model.ProjectId,
            };
            var outputs = await OutputsService.GetList<List<Models.Output>>(outputSearch);

            cmbOutputs.DataSource = outputs;
            cmbOutputs.ValueMember = "OutputId";
            cmbOutputs.DisplayMember = "Description";
            cmbOutputs.SelectedValue = _model.OutputId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren() || _model is null)
            {
                return;
            }

            ActivityUpdateRequest updateRequest = new ActivityUpdateRequest()
            {
                Description = txtDescription.Text,
                Locations = txtLocation.Text,
                DirectBeneficiaries = txtDirBenef.Text,
                IndirectBeneficiaries = txtIndirBenef.Text,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                OutputId = (int)cmbOutputs.SelectedValue,
            };

            await ActivitiesService.Update<Models.Activity>(_model.ActivityId, updateRequest);
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

        private void cmbOutputs_Validating(object sender, CancelEventArgs e)
        {
            if (cmbOutputs.SelectedItem is null)
            {
                e.Cancel = true;
                cmbOutputs.Focus();
                errorProvider.SetError(cmbOutputs, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbOutputs, "");
            }
        }

        private void dtpStartDate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpStartDate.Value.ToString()))
            {
                e.Cancel = true;
                dtpStartDate.Focus();
                errorProvider.SetError(dtpStartDate, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtpStartDate, "");
            }
        }

        private void dtpEndDate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpEndDate.Value.ToString()))
            {
                e.Cancel = true;
                dtpEndDate.Focus();
                errorProvider.SetError(dtpEndDate, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtpEndDate, "");
            }
        }
    }
}
