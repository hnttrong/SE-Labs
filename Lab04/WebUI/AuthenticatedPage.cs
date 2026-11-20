using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public class AuthenticatedPage : Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (Session["Username"] == null)
            {
                Response.Redirect("~/Login.aspx", true);
            }
        }

        protected void ShowMessage(Label label, string message, bool success)
        {
            label.Text = message;
            label.CssClass = success ? "message success" : "message error";
        }
    }
}
