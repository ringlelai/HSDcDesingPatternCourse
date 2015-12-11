using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using hsdc.dpt.Control.Structural.Adapter;
using hsdc.dpt.Control.DTO.Structual.Adapter;

namespace WebMVC.Controllers.Structural
{
    public class AdapterController : Controller
    {
        // GET: Adapter
        public ActionResult Index()
        {
            // new a control object.
            查詢商品Control control = new 查詢商品Control();

            // new a List<T> object.
            List<烏龜商品> prodList = new List<烏龜商品>();

            // 取得可訂購的烏龜清單
            prodList = control.get可訂購烏龜清單();

            //return View(DTO);
            return View(prodList);            
        }
    }
}