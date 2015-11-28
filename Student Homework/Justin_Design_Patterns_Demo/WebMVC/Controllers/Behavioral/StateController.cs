using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Behavioral.State;

namespace WebMVC.Controllers.Behavioral
{
    public class StateController : Controller
    {
        private TrackOrderControl control;

        // GET: State
        public ActionResult Index()
        {
            if (Session["TrackOrderControl"] == null)
            {
                control = new TrackOrderControl();          // new a domain control instance.
                Session["TrackOrderControl"] = control;
            }
            else
                Session["TrackOrderControl"] = control;     // hold the control object as stateful.

            return View();
        }

        public ActionResult Stamp()
        {
            control = (TrackOrderControl)Session["TrackOrderControl"];     // get the control object from the Session Object.
            ViewData["OrderState"] = control.StampOrder_1();               // 作法一：使用 Switch-Case 處理訂單狀態
            //ViewData["OrderState"] = control.StampOrder_2();               // 作法二：使用 State Pattern 處理訂單狀態

            return View("Index");
        }
    }
}