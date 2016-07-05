using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Useful_nugets.Controllers
{
    public class HomeController : Controller
    {
        private IList<string> _list;

        public HomeController(IList<string> list)
        {
            _list = list;
        }

        public ActionResult Index()
        {
            _list.Add("String 1");
            _list.Add("String 2");
            return View(_list);
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
    }
}