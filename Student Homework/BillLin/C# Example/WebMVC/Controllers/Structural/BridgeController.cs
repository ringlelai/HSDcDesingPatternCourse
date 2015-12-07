using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Structural.Bridge;
using hsdc.dpt.Control.DTO.Structual.Bridge;

namespace WebMVC.Controllers.Structural
{
    public class BridgeController : Controller
    {
        // GET: Bridge
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Notify()
        {
            傳送訊息DemoControl control = new 傳送訊息DemoControl();        // new a control object.
            NotifyType notifytype;                      // declare enumernation type reference.
            SenderType sendertype;
            Message message = new Message();            // Data Transfer Object.

            // 判斷選擇哪一種通知類型
            if (Request.Form["NotifyType"].Equals("SystemNotify"))
                notifytype = NotifyType.System;
            else
                notifytype = NotifyType.User;

            // 判斷選擇哪一種傳送方式
            if (Request.Form["SenderType"].Equals("EmailSender"))
                sendertype = SenderType.Email;
            else
                sendertype = SenderType.Line;

            // 組裝 Message 物件的內容
            message.Recipient = Request.Form["txtRecipient"];
            message.Subject = Request.Form["txtSubject"];
            message.Body = Request.Form["txtBody"];

            // 交由 control 委派處理
            string procResult = control.Notify(notifytype, sendertype, message);
            ViewData["result"] = procResult;

            return View();
        }
    }
}