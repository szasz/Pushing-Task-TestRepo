using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Configuration;
using MyCouch;

namespace PushingTaskFollower
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }

       
            
        //public static Repository<T> GetRepository<T>() where T : class
        //{
        //    const string databaseName = "db";
        //    var connection = new Connection(
        //        new Uri(ConfigurationManager.AppSettings.Get("CLOUDANT_URL")));
        //    if (!connection.ListDatabases().Contains(databaseName))
        //    {
        //        connection.CreateDatabase(databaseName);
        //    }
        //    return new Repository<T>(connection.CreateSession(databaseName));
        //}
    }
}