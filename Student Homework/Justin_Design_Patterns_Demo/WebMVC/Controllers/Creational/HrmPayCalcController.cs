using hsdc.dpt.Control.Creational.FactoryMethod;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Creational
{
    public class HrmPayCalcController : Controller
    {
        // GET: HrmPayCalc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PayCalc()
        {
            var control = new HrmPayRollCalcControl();
            List<PayRoll> payStructure = control.CalcPayRoll();
            return View(payStructure);
        }

    }
}