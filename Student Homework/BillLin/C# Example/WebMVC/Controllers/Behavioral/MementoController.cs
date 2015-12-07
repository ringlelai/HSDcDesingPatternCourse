using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Behavioral.Memento;
using hsdc.dpt.Control.DTO.Behavioral.Memento;

namespace WebMVC.Controllers.Behavioral
{
    public class MementoController : Controller
    {
        管理博彩Control control;        // declare a domain controller.

        // GET: Memento
        public ActionResult Index()
        {
            if (Session["ManageGambleControl"] == null)
            {
                control = new 管理博彩Control();                    // new a domain control instance.
                Session["ManageGambleControl"] = control;
            }
            else
                Session["ManageGambleControl"] = control;           // hold the control object as stateful.
            return View();
        }

        public ActionResult SelectLotteService(string Submit, 複合彩DTO dto)
        {
            switch (Submit)
            {
                case "自動選號":
                    return this.DoAutoSelect(dto);
                case "暫存本組複合彩":
                    return this.DoSave(dto);
                case "回復所選複合彩":
                    return this.DoRestore();
                case "列印選號":
                    break;
            }
            return View("Index", dto);
        }

        // 選擇自動選號
        private ActionResult DoAutoSelect(複合彩DTO dto)
        {
            // get the control object from the Session Object.
            control = (管理博彩Control)Session["ManageGambleControl"];

            dto.彩券號碼 = control.選號().ToString();
            ViewData["Result"] = "已自動選號。";

            return View("Index", dto);
        }

        // 選擇自動選號
        private ActionResult DoSave(複合彩DTO dto)
        {
            // get the control object from the Session Object.
            control = (管理博彩Control)Session["ManageGambleControl"];

            control.Save選號(dto);
            ViewData["Result"] = "本複合彩組合已暫存。";

            return View("Index", dto);
        }

        // 選擇自動選號
        private ActionResult DoRestore()
        {
            // get the control object from the Session Object.
            control = (管理博彩Control)Session["ManageGambleControl"];
            複合彩DTO dto;

            dto = control.還原選號();
            ModelState.Remove("成語字謎");
            ViewData["Result"] = "已還原原來所選擇複合彩組合。";

            return View("Index", dto);
        }
    }
}