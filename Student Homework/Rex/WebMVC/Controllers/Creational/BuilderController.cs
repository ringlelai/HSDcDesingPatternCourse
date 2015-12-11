using hsdc.dpt.Control.Creational.Builder;
using hsdc.dpt.Control.Creational.Builder.ApplyExpense;
using hsdc.dpt.Control.Creational.Builder.Leave;
using hsdc.dpt.Control.Creational.Builder.Overtime;
using hsdc.dpt.Control.DTO.Creational.Builder;
using System.Web.Mvc;
using WebMVC.ViewModels.Builder;

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
            return View("NewApplyExpense", form);
        }

        [HttpPost]
        public ActionResult SaveApplyExpense(ApplyExpense expense)
        {
            SaveApplyExpenseControl uco = new SaveApplyExpenseControl();
            expense = uco.Save(expense);
            return View("NewApplyExpense", expense);
        }

        public ActionResult NewOvertime()
        {
            OvertimeBuilder builder = new OvertimeBuilder();

            EOfficeDirector<OverTime> director = new EOfficeDirector<OverTime>();

            OverTime form = director.Construct(builder);

            NewOverTimeViewModel vm = ConverToViewModel(form);

            return View("NewOvertime", vm);
        }

        [HttpPost]
        public ActionResult NewOvertime(NewOverTimeViewModel model)
        {
            if (ModelState.IsValid == false) return View("NewOvertime", model);

            OverTime dto = ConvertToDto(model);

            SaveOvertimeControl uco = new SaveOvertimeControl();

            dto = uco.Save(dto);

            NewOverTimeViewModel vm = ConverToViewModel(dto);

            return View("NewOvertime", vm);
        }

        private static NewOverTimeViewModel ConverToViewModel(OverTime dto)
        {
            NewOverTimeViewModel vm = new NewOverTimeViewModel
            {
                OverTimeId = dto.OverTimeId,
                Applier = dto.Applier,
                ApplyDateTime = dto.ApplyDateTime,
                OverTimeHour = dto.OverTimeHour
            };
            return vm;
        }

        private static OverTime ConvertToDto(NewOverTimeViewModel model)
        {
            OverTime dto = new OverTime
            {
                OverTimeId = model.OverTimeId,
                Applier = model.Applier,
                ApplyDateTime = model.ApplyDateTime,
                OverTimeHour = model.OverTimeHour
            };
            return dto;
        }
    }
}