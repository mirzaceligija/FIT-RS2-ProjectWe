using ProjectWe.Desktop.Services;
using ProjectWe.Models;
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

namespace ProjectWe.Desktop.Forms.Users
{
    public partial class frmUsers : Form
    {
        public APIService _api { get; set; } = new APIService("Users");
        public frmUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searchObject = new UserSearchObject
            {
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                IncludeRoles = true
            };

            var users = await _api.GetList<List<AppUser>>(searchObject);
            dgvUsers.DataSource = users;
        }
    }
}
