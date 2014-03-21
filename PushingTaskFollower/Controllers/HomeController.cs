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
			ViewBag.Message = "{\"msg\": \"MyCouch says hello to Cloudant!\"}";

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

        public JsonResult Hooks(object test) 
		{
            return new JsonResult { Data = test.ToString(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            //return new JsonResult { Data = "{\"valami\": \"asdfg\"}" , JsonRequestBehavior = JsonRequestBehavior.AllowGet };

			/// ezt az adatot meg továbbdobom, azure-felé pl. ami feldolgozza :)
		}
    }
}
