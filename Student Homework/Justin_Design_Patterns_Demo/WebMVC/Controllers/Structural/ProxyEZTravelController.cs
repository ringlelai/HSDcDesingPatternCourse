using hsdc.dpt.Control.DTO.Structual.Proxy;
using hsdc.dpt.Control.Structural.ProxyEZTravel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Structural
{
    public class ProxyEZTravelController : Controller
    {
        // GET: ProxyEZTravel
        public ActionResult Index()
        {
            return View();
        }   

        [HttpPost]
        public ActionResult GetHotels(HotelsInfo info)
        {
            var control = new EZTraveInControl();
            var list = control.GetHotelsInfo(info);
            return View(list);
        }
    }
}