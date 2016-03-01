using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.SignalR;
using FluentValidation.WebApi;
using Microsoft.Owin;
using Owin;
using Autofac.Integration.WebApi;
using SampleArch.Logging;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(SampleArch.WebApi.OwinStartup))]

namespace SampleArch.WebApi
{
    /// <summary>
    /// OwinStartup
    /// </summary>
    public class OwinStartup
    {
        /// <summary>
        /// Configurations the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            // STANDARD WEB API SETUP:

            // Get your HttpConfiguration. In OWIN, you'll create one
            // rather than using GlobalConfiguration.
            var config = new HttpConfiguration();

            //// Register your Web API controllers.
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            
            //// Run other optional steps, like registering filters,
            //// per-controller-type services, etc., then set the dependency resolver
            //// to be Autofac.
            ////var container = builder.Build();
            ////config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            ////Autofac Configuration
            ////var builder = new Autofac.ContainerBuilder();
            //Audit.Log.Debug("Application_Start :: Autofac Configuration set");

            //builder.RegisterApiControllers((typeof(WebApiApplication).Assembly)).InstancePerLifetimeScope();
            //Audit.Log.Debug("Application_Start :: RegisterControllers called");

            //builder.RegisterModule(new RepositoryModule());
            //builder.RegisterModule(new ServiceModule());
            //builder.RegisterModule(new EFModule());
            //Audit.Log.Debug("Application_Start :: RegisterModule called");

            // Get your HttpConfiguration.
            //var config = new HttpConfiguration();

            // Register your Web API controllers.
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // You can register hubs all at once using assembly scanning...
            builder.RegisterHubs(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            //builder.RegisterWebApiFilterProvider(config);
            config.EnsureInitialized();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            //Audit.Log.Debug("Application_Start :: DependencyResolver called");
            

            // OWIN WEB API SETUP:

            // Register the Autofac middleware FIRST, then the Autofac Web API middleware,
            // and finally the standard Web API middleware.
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);

            app.Map("/signalr", map =>
            {
                // Setup the cors middleware to run before SignalR.
                // By default this will allow all origins. You can 
                // configure the set of origins and/or http verbs by
                // providing a cors options with a different policy.
                map.UseCors(CorsOptions.AllowAll);

                var hubConfiguration = new HubConfiguration
                {
                    // You can enable JSONP by uncommenting line below.
                    // JSONP requests are insecure but some older browsers (and some
                    // versions of IE) require JSONP to work cross domain
                    // EnableJSONP = true
                };

                // Run the SignalR pipeline. We're not using MapSignalR
                // since this branch is already runs under the "/signalr"
                // path.
                map.RunSignalR(hubConfiguration);
            });

            FluentValidationModelValidatorProvider.Configure(config);

            //app.MapSignalR();
        }
    }
}
