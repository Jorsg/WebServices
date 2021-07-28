using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using servicio = Web_PruebaIsupan.ServiceReference1;

namespace Web_PruebaIsupan.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var obj_wsIns = new servicio();
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
    }
}