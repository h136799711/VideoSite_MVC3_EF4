using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using Autofac.Integration.Mvc;
using Autofac.Configuration;
using Autofac;
using VideoSite.EF.Infrastructure;
using VideoSite.Services.IServices;
using VideoSite.Services.Services;
using VideoSite.Web.Common;
namespace VideoSite.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AppHandleErrorAttribute());
         //   filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 "HtmlAction", // Route name
                 "{action}/{htmlName}", // URL with parameters 
                new { controller = "Html" }, // Parameter defaults
                  new { htmlName = @"\b\w+.html$" }
             );
            
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters 
                new { controller = "User", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            ); 
        }
        public static void RegisterAndResolveType()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
        
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        protected void Application_Start()
        {
            RegisterAndResolveType();

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

        }
    }
}