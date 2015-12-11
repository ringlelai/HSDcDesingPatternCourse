using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Behavioral.Visitor;

namespace WebMVC.Controllers.Behavioral
{
    public class VisitorController : Controller
    {
        private ManageHRControl control;

        // GET: Visitor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcTotalPrice()
        {
            control = new ManageHRControl();

            ViewData["ProcssResult"] = control.calc公司每月固定支出();

            return View("Index");
        }

        public ActionResult CalcInventory()
        {
            control = new ManageHRControl();

            ViewData["ProcssResult"] = control.calce公司資產總數();

            return View("Index");
        }
    }
}