using ProjectWe.Desktop.Services;
using ProjectWe.Models;
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
    public partial class frmBudgetItem : Form
    {
        public APIService BudgetsService { get; set; } = new APIService("Budgets");
        public APIService ActivitiesService { get; set; } = new APIService("Activities");

        private Budget _model = null;
        public frmBudgetItem(Models.Budget model)
        {
            InitializeComponent();
            _model = model;
        }

        private async void frmBudgetItem_Load(object sender, EventArgs e)
        {
            if (_model is not null)
            {
                await LoadActivities();

                txtDescription.Text = _model.Description;
                numItemCost.Value = _model.CostPerUnit;
                numQty.Value = _model.NumberOfUnits;
                numTotalCost.Value = (decimal)_model.TotalCost;
            }
        }

        private async Task LoadActivities()
        {
            var activitySearch = new ActivitySearchObject
            {
                ProjectId = _model.ProjectId,
            };
            var activities = await ActivitiesService.GetList<List<Models.Activity>>(activitySearch);

            cmbActivities.DataSource = activities;
            cmbActivities.ValueMember = "ActivityId";
            cmbActivities.DisplayMember = "Description";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren() || _model is null)
            {
                return;
            }

            BudgetUpdateRequest updateRequest = new BudgetUpdateRequest()
            {
                Description = txtDescription.Text,
                ActivityId = (int)cmbActivities.SelectedValue,
                CostPerUnit = numItemCost.Value,
                NumberOfUnits = (int)numQty.Value,
            };

            await BudgetsService.Update<Models.Budget>(_model.BudgetId, updateRequest);
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

        private void cmbActivities_Validating(object sender, CancelEventArgs e)
        {
            if (cmbActivities.SelectedItem is null)
            {
                e.Cancel = true;
                cmbActivities.Focus();
                errorProvider.SetError(cmbActivities, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbActivities, "");
            }
        }

        private void numItemCost_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            numTotalCost.Value = numItemCost.Value * numQty.Value;
        }
    }
}
