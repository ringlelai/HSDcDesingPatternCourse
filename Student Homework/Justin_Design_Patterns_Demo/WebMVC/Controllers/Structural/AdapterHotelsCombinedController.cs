using hsdc.dpt.Control.DTO.Structual.Adapter;
using hsdc.dpt.Control.Structural.AdapterHotelsCombined;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Structural
{
    public class AdapterHotelsCombinedController : Controller
    {
        // GET: AdapterHotelsCombined
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetHotels(TravelSitesInfo info)
        {
            var control = new HotelsCombinedControl();
            var list = control.GetHotelsInfo(info);
            return View(list);
        }
    }
}