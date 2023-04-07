using ProjectWe.Desktop.Services;
using ProjectWe.Models;
using ProjectWe.Models.Requests;
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
    public partial class frmObjectiveDetails : Form
    {
        public APIService ObjectivesService { get; set; } = new APIService("Objectives");

        private Models.Objective _model = null;

        public frmObjectiveDetails(Objective model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private void frmObjectiveDetails_Load(object sender, EventArgs e)
        {
            if (_model is not null)
            {
                txtDescription.Text = _model.Description;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren() || _model is null)
            {
                return;
            }

            ObjectiveUpdateRequest updateRequest = new ObjectiveUpdateRequest()
            {
                Description = txtDescription.Text
            };

            await ObjectivesService.Update<Models.Objective>(_model.ObjectiveId, updateRequest);
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
    }
}
