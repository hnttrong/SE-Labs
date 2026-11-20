using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WinFormUI
{
    public partial class LoginForm : Form
    {
        private readonly LoginService _loginService;
        public LoginForm()
        {
            InitializeComponent();
            _loginService = new LoginService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = _loginService.Login(
                    txtUsername.Text,
                    txtPassword.Text);

                if (success)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();

                    using (MainForm mainForm = new MainForm())
                    {
                        mainForm.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Login failed. Please check your username and password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
