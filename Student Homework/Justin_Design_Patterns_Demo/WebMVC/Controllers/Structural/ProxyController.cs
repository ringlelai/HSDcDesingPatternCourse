using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Structural.Proxy;

namespace WebMVC.Controllers.Structural
{
    public class ProxyController : Controller
    {
        // GET: Proxy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Identify(string selTurtleType, string txtSerialNo)
        {
            ViewData["result1"] = selTurtleType;
            ViewData["result2"] = txtSerialNo;
            販售服務Control control = new 販售服務Control();

            string 認證結果 = control.get認證資訊(selTurtleType, txtSerialNo);
            ViewData["IdentifyResult"] = 認證結果;

            return View();
        }
    }
}