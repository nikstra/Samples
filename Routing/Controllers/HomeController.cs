using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Date(int? year, int? month, int? day)
        {
            if ((year ?? month ?? day) == null) // Routing should prevent partial dates.
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "All parameters are null");

            return Content(string.Format("{0:D4}-{1:D2}-{2:D2}", year, month, day));
        }

        public ActionResult MixedParams(string param, int? id)
        {
            if (param == null || id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "One of the parameters are null");

            return Content(string.Format("param: {0}, id: {1}", param, id));
        }
    }
}