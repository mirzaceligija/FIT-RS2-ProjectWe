using ProjectWe.Desktop.Forms.Users;
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

namespace ProjectWe.Desktop.Forms.Authentication
{
    public partial class frmSignIn : Form
    {
        private readonly APIService _api = new APIService("users");
        public frmSignIn()
        {
            InitializeComponent();
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            btnSignIn.Enabled = false;

            var authRequest = new
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                APIService.User = await _api.SignIn(authRequest);
                if (!APIService.User.RoleNames.Contains("Admin"))
                {
                    MessageBox.Show("User is not an Admin");
                    btnSignIn.Enabled = true;
                    return;
                }

                this.Hide();
                mdiMain mdiMain = new mdiMain();
                mdiMain.Show();
            }
            catch
            {
                btnSignIn.Enabled = true;
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "This is a required field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
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
}
