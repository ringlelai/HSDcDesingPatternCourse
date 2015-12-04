using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Behavioral.CoR;
using hsdc.dpt.Control.DTO.Behavioral.CoR;

namespace WebMVC.Controllers.Behavioral
{
    public class CoRController : Controller
    {
        // GET: CoR
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult handleDonate(string TxtName, string SelDonateType, string TxtDonateMoney, string TxtExtInfo)
        {
            procDonateControl control = new procDonateControl();    // new a domain controller
            Donation donate = new Donation();                       // new a Donation DTO Class.
            DonateType dtype;

            switch (SelDonateType)
            { 
                case ("個人") :
                    dtype = DonateType.個人;
                    break;
                case ("營利事業"):
                    dtype = DonateType.營利事業;
                    break;
                case ("人民團體"):
                    dtype = DonateType.人民團體;
                    break;
                default :
                    dtype = DonateType.UNKNOWN;
                    break;
            }

            // put the form's values into donate instance.
            donate.name = TxtName;
            donate.type = dtype;
            donate.money = Convert.ToInt32(TxtDonateMoney);
            donate.ext_info = TxtExtInfo;

            // get the process result.
            ViewData["ProcssResult"] = control.procDonation(donate);

            return View("Index");
        }
    }
}