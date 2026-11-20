using BLL;
using System;
using System.Web.UI;

namespace WebUI
{
    public partial class Login : Page
    {
        private readonly LoginService _loginService = new LoginService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["Username"] != null)
            {
                Response.Redirect("~/Main.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (_loginService.Login(txtUsername.Text, txtPassword.Text))
            {
                Session["Username"] = txtUsername.Text.Trim();
                Response.Redirect("~/Main.aspx");
                return;
            }

            lblMessage.Text = "Invalid username or password.";
        }
    }
}
