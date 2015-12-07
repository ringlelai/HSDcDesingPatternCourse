using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Behavioral.Strategy;
using hsdc.dpt.Control.DTO.Behavioral.Strategy;

namespace WebMVC.Controllers.Behavioral
{
    public class StrategyController : Controller
    {
        // GET: Strategy
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExecuteStrategy(string selStrategyType)
        {
            PlaceOrderControl control = new PlaceOrderControl();        // domain control object
            StrategyType type;      // enum type

            if (selStrategyType.Equals("黃金交叉"))
                type = StrategyType.GoldenCross;
            else
                type = StrategyType.RSI;

            ViewData["ProcssResult"] = control.ExecuteStrategy(type);            

            return View("Index");
        }
    }
}