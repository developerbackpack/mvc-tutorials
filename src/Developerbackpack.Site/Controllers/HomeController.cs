using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Developerbackpack.Site.Controllers
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

        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return $"The id value is : {id}";
            }
            throw new ArgumentOutOfRangeException(nameof(id),id,"");
        }
    }
}