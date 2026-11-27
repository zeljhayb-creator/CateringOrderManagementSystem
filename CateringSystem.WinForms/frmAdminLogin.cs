using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CateringBusinessLogic;

namespace CateringSystem.WinForms
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            AuthenticationService authenticationService = new AuthenticationService();

            bool isAuthenticated = authenticationService.Login(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login Successful!");

                this.Hide();

                frmAdminPanel adminPanel = new frmAdminPanel();
                adminPanel.ShowDialog();

                this.Close();
            }
        }
    }
}