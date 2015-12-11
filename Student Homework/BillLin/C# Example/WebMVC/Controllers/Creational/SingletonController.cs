using hsdc.dpt.Control.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Creational
{
    public class SingletonController : Controller
    {
        // GET: Singleton
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GenID(string formType)
        {
            string id = IDGeneratorSingleton.Instance.GetNextID(formType, DateTime.Today);
            return Json(id, JsonRequestBehavior.AllowGet);
        }
    }
}