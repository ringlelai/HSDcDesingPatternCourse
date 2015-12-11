using hsdc.dpt.Control.Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Behavioural
{
    public class MediatorController : Controller
    {
        // GET: Mediator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            StockingUco uco = new StockingUco();
            return View(uco.GetAllProducts());
        }

        public ActionResult StockIn()
        {
            StockingUco uco = new StockingUco();
            return View(uco.GetAllProducts());
        }

        public JsonResult CheckQuantity(string prodName)
        {
            StockingUco uco = new StockingUco();
            return Json(uco.CheckQunatity(prodName), JsonRequestBehavior.AllowGet);
        }
    }
}