using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cisdemo_sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sample CIS Applicaiton description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sample CIS contact page.";

            return View();
        }
    }
}