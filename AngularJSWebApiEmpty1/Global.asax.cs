using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace AngularJSWebApiEmpty1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            int k = 20;
            int l = 50;
            //test change in branch
            int i=0;
            int j = 9;
        }
    }
}
