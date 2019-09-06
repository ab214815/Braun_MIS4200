using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Braun_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "First MIS4200 Web Site";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Ashley";

            return View();
        }
    }
}