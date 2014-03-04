using MyCouch;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PushingTaskFollower.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var couchClient = CouchClient();
            //Name or password is incorrect, unauthorized
            var post = couchClient.Documents.PostAsync("{\"msg\": \"MyCouch says hello to Cloudant!\"}").Result;

            var requested = couchClient.Documents.GetAsync(post.Id);

            ViewBag.Message = requested.Result.Content;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public static MyCouchClient CouchClient()
        {
            var couchUrl = ConfigurationManager.AppSettings.Get("CLOUDANT_URL");
            var uriBuilder = new MyCouchUriBuilder(couchUrl)
            .SetDbName("db")
            .SetBasicCredentials("szasz", "Asgard23");

            return new MyCouchClient(uriBuilder.Build());
        }


    }
}
