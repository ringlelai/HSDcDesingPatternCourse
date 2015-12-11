using hsdc.dpt.Control.Structural.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Structural
{
    public class CompositeController : Controller
    {
        // GET: Composite
        public ActionResult Index()
        {
            RingelOrgControl uco = new RingelOrgControl();
            return View(uco.GetAllDepartmentName());
        }

        public JsonResult QueryEmp(string deptName)
        {
            RingelOrgControl uco = new RingelOrgControl();
            return Json(uco.GetAllEmployeeName(deptName), JsonRequestBehavior.AllowGet);
        }
    }
}