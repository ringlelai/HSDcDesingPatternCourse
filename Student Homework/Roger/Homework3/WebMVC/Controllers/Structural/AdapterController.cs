using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using hsdc.dpt.Control.Structural.Adapter;
using hsdc.dpt.Control.DTO.Structual.Adapter;

namespace WebMVC.Controllers.Structural
{
    public class AdapterController : Controller
    {
        // GET: Adapter
        public ActionResult Index()
        {
            // new a control object.
            ListHotelsUco uco = new ListHotelsUco();

            // new a List<T> object.
            List<Hotel> hotelList = uco.getAllHotelList();

            //return View(DTO);
            return View(hotelList);            
        }
    }
}