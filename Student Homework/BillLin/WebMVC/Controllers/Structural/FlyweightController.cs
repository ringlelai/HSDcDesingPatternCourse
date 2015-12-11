using hsdc.dpt.Control.DTO.Structual.Flyweight;
using hsdc.dpt.Control.Structural.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Structural
{
    public class FlyweightController : Controller
    {
        public ActionResult Index()
        {
            List<CodeDto> cityCodes = CodeFactory.GetInstance().GetCode("CITY").GetCodeList();
            return View(cityCodes);
        }

        public JsonResult QueryArea(string city)
        {
            List<CodeDto> cityCodes = CodeFactory.GetInstance().GetCode("AREA").GetCodeList(city);
            return Json(cityCodes, JsonRequestBehavior.AllowGet);
        }
    }
}