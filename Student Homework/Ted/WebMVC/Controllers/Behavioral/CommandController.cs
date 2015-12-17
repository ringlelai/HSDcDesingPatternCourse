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
        private CalculationInvoker invoker = new CalculationInvoker();

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
            if (Session["invoker"] == null)
            {
                Session.Add("invoker", new CalculationInvoker());
            }
            receiver = (ElementaryArithCaculator)Session["calculator"];
            invoker = (CalculationInvoker)Session["invoker"];
            //(new CalculationInvoker()).Compute(receiver, @operator, operand);
            invoker.Compute(receiver, @operator, operand);
            Session["calculator"] = receiver;
            Session["invoker"] = invoker;
            return Json(receiver.GetResult(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Undo()
        {
            ElementaryArithCaculator receiver;
            if (Session["calculator"] == null)
            {
                Session.Add("calculator", new ElementaryArithCaculator());
            }
            if (Session["invoker"] == null)
            {
                Session.Add("invoker", new CalculationInvoker());
            }
            receiver = (ElementaryArithCaculator)Session["calculator"];
            invoker = (CalculationInvoker)Session["invoker"];
            invoker.Undo(receiver);
            Session["calculator"] = receiver;
            Session["invoker"] = invoker;
            return Json(receiver.GetResult(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Clear()
        {
            ElementaryArithCaculator receiver;
            if (Session["calculator"] == null)
            {
                Session.Add("calculator", new ElementaryArithCaculator());
            }
            if (Session["invoker"] == null)
            {
                Session.Add("invoker", new CalculationInvoker());
            }
            receiver = new ElementaryArithCaculator();
            invoker = new CalculationInvoker();
            Session["calculator"] = receiver;
            Session["invoker"] = invoker;
            return Json(receiver.GetResult(), JsonRequestBehavior.AllowGet);
        }
    }
}