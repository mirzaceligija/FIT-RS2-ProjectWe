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

namespace ProjectWe.Desktop.Forms.Users
{
    public partial class frmUserDetails : Form
    {
        public APIService UsersService { get; set; } = new APIService("Users");
        public APIService RolesService { get; set; } = new APIService("Roles");

        private AppUser _model = null;
        private bool _editMode = false;

        public frmUserDetails(AppUser model = null, bool editMode = false)
        {
            InitializeComponent();
            _model = model;
            _editMode = editMode;
            lblTitle.Text = _model is null ? "New User" : $"{_model.FirstName} {_model.LastName}";
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            await LoadRoles();
            if (_model is not null)
            {
                txtFirstName.Text = _model.FirstName;
                txtLastName.Text = _model.LastName;
                txtEmail.Text = _model.Email;
                txtUserName.Text = _model.Username;
                txtUserName.Enabled = false;
                ckEmail.Checked = _model.EmailConfirmed;
                ckPhone.Checked = _model.PhoneNumberConfirmed;
                ck2FA.Checked = _model.TwoFactorEnabled;
                //TODO: Add roles check
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            var roleList = chkRoles.CheckedItems.Cast<AppRole>().ToList();
            var roleIdList = roleList.Select(x => x.Id).ToList();

            if (_model is null)
            {
                UserInsertRequest insertRequest = new UserInsertRequest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    ConfirmPassword = txtPassword.Text,
                    AppRoleIdsList = roleIdList
                };

                await UsersService.Insert<AppUser>(insertRequest);
                this.Hide();
            }
            else
            {
                UserUpdateRequest updateRequest = new UserUpdateRequest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    ConfirmPassword = txtPassword.Text,
                    AppRoleIdsList = roleIdList
                };

                await UsersService.Update<AppUser>(_model.Id, updateRequest);
                this.Hide();
            }
        }

        private async Task LoadRoles()
        {
            var roles = await RolesService.GetList<List<Models.AppRole>>();
            chkRoles.DataSource = roles;
            chkRoles.DisplayMember = "Name";
            if (_model is not null)
            {
                for (int i = 0; i < chkRoles.Items.Count; i++)
                {
                    var roleList = chkRoles.Items.Cast<AppRole>().ToList();
                    string itemName = roleList[i].Name;
                    bool isChecked = _model.RoleNames.Contains(itemName);
                    chkRoles.SetItemChecked(i, isChecked);
                }
            }

            chkRoles.SetItemChecked(1, true); //Set the Manager by default
            chkRoles.SetItemCheckState(1, CheckState.Indeterminate);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider.SetError(txtFirstName, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider.SetError(txtLastName, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider.SetError(txtUserName, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(!_editMode)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    e.Cancel = true;
                    txtPassword.Focus();
                    errorProvider.SetError(txtPassword, "This is a required field!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtPassword, "");
                }
            }
        }

        private void txtConfirmation_Validating(object sender, CancelEventArgs e)
        {
            if (!_editMode)
            {
                if (string.IsNullOrWhiteSpace(txtConfirmation.Text))
                {
                    e.Cancel = true;
                    txtConfirmation.Focus();
                    errorProvider.SetError(txtConfirmation, "This is a required field!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtConfirmation, "");
                }
            }
        }

        private void chkRoles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 1 && e.NewValue == CheckState.Unchecked)
            {
                e.NewValue = CheckState.Checked;
            }
        }
    }
}
