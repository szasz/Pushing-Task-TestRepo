using PTF.Core.Model;
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

        //public ActionResult Hooks()
        //{
        //    var context = this.ControllerContext;

        //    var reqContext = this.ControllerContext.RequestContext;
        //    var resContext = this.ControllerContext.HttpContext.Response;
            
        //    //ViewBag.Message = "asdas";
        //    //[8:15:15] Péter Takács: this.ControllerContext-en
        //    return View();
        //}

        public JsonResult Hooks(Payload hooks)
        {


            return new JsonResult { Data = hooks, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            /// ezt az adatot meg továbbdobom, azure-felé pl. ami feldolgozza :)
        }
    }
}
