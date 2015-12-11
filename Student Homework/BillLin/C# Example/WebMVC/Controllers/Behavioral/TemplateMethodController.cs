using hsdc.dpt.Control.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Behavioural
{
    public class TemplateMethodController : Controller
    {
        // GET: TemplateMethod
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult QueryPolicyList(string type)
        {
            PolicyTransactionUco uco = new PolicyTransactionUco();
            return Json(uco.GetTransactionList(ConfigurationManager.AppSettings[type]), JsonRequestBehavior.AllowGet);
        }
    }
}