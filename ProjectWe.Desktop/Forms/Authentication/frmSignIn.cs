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
            btnSignIn.Enabled = false;

            var authRequest = new
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                APIService.User = await _api.SignIn(authRequest);
                if(APIService.User.RoleNames.Contains("Admin"))
                {
                    this.Hide();
                    frmUsers frmUsers = new frmUsers();
                    frmUsers.Show();
                } else
                {
                    throw new Exception();
                }
            }
            catch
            {
                btnSignIn.Enabled = true;
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
