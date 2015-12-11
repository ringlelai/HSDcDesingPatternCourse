using hsdc.dpt.Control.Behavioral.Command.Caculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Behavioural
{
    public class CommandController : Controller
    {
        // GET: Command
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Compute(int operand, string @operator)
        {
            ElementaryArithCaculator receiver;
            if (Session["calculator"] == null)
            {
                Session.Add("calculator", new ElementaryArithCaculator());
            }
            receiver = (ElementaryArithCaculator)Session["calculator"];
            (new CalculationInvoker()).Compute(receiver, @operator, operand);
            Session["calculator"] = receiver;
            return Json(receiver.GetResult(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Clear()
        {
            ElementaryArithCaculator receiver;
            if (Session["calculator"] == null)
            {
                Session.Add("calculator", new ElementaryArithCaculator());
            }
            receiver = new ElementaryArithCaculator();
            Session["calculator"] = receiver;
            return Json(receiver.GetResult(), JsonRequestBehavior.AllowGet);
        }
    }
}