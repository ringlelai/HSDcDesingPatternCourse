using hsdc.dpt.Control.Creational.Builder;
using hsdc.dpt.Control.DTO.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Creational
{
    public class BuilderController : Controller
    {
        // GET: Builder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewLeave()
        {
            LeaveBuilder builder = new LeaveBuilder();
            EOfficeDirector<Leave> director = new EOfficeDirector<Leave>();
            Leave form = director.Construct(builder);
            return View(form);
        }

        [HttpPost]
        public ActionResult SaveLeave(Leave leave)
        {
            SaveLeaveControl uco = new SaveLeaveControl();
            leave = uco.Save(leave);
            return View("NewLeave", leave);
        }

        public ActionResult NewApplyExpense()
        {
            ApplyExpenseBuilder builder = new ApplyExpenseBuilder();
            EOfficeDirector<ApplyExpense> director = new EOfficeDirector<ApplyExpense>();
            ApplyExpense form = director.Construct(builder);
            return View(form);
        }

        [HttpPost]
        public ActionResult SaveApplyExpense(ApplyExpense expense)
        {
            SaveApplyExpenseControl uco = new SaveApplyExpenseControl();
            expense = uco.Save(expense);
            return View("NewApplyExpense", expense);
        }
    }
}