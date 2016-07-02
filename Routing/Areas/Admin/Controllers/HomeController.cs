using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

namespace Routing.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            return Content("Action full name: " + method.ReflectedType.FullName + "." + method.Name);
        }
    }
}