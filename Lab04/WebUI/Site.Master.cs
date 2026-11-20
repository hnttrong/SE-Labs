using System;
using System.Web.UI;

namespace WebUI
{
    public partial class SiteMaster : MasterPage
    {
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }
}
