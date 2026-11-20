using System;
using System.Web;
using System.Web.Routing;

namespace WebUI
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapPageRoute("Home", "", "~/Login.aspx");
        }
    }
}
