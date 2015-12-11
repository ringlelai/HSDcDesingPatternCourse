using hsdc.dpt.Control.Behavioral.Interpreter.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Behavioural
{
    public class InterpreterController : Controller
    {
        // GET: Interpreter
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult TransferToChinese(long number)
        {
            MoneyContext context = new MoneyContext(number);
            MoneyController uco = new MoneyController();
            uco.TransferToChinese(ref context);
            return Json(context.ToChinese(), JsonRequestBehavior.AllowGet);
        }
    }
}