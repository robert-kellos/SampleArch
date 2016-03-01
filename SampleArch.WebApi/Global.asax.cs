using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SampleArch.Logging;

namespace SampleArch.WebApi
{
    /// <summary>
    /// WebApiApplication
    /// </summary>
    /// <seealso cref="System.Web.HttpApplication" />
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Application_s the start.
        /// </summary>
        protected void Application_Start()
        {
            Audit.Log.Debug("Application_Start :: App Starting ...");

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Audit.Log.Debug("Application_Start :: Registered Configs");
        }
    }
}
