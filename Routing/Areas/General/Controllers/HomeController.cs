using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Routing.Areas.General.Controllers
{
    public class HomeController : Controller
    {
        // GET: General/Home
        public ActionResult Index()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            return Content("Action full name: " + method.ReflectedType.FullName + "." + method.Name);
        }
    }
}