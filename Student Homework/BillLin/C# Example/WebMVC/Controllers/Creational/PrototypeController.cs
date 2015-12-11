using hsdc.dpt.Control.Creational.Prototype.RingleERP;
using hsdc.dpt.Control.Creational.Prototype.RingleFramework;
using hsdc.dpt.Control.DTO.Creational.Prototype.RingleERP.InternalDto;
using hsdc.dpt.Control.DTO.Creational.Prototype.RingleFramework.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Structural
{
    public class PrototypeController : Controller
    {
        // GET: Prototype
        public ActionResult Index()
        {
            return View();
        }

        #region Case1
        public ActionResult RingleFramework()
        {
            MaintainPurchaseConrol uco = new MaintainPurchaseConrol();
            return View(uco.GetPurchaseLists());
        }

        public ActionResult RingleFrameworkAdd()
        {
            return View();
        }

        public ActionResult RFAddPo(string CustName)
        {
            MaintainPurchaseConrol uco = new MaintainPurchaseConrol();
            PurchaseOrder newPo = uco.NewPurchaseOrder().Clone();
            newPo.CustomerName = CustName;
            List<PurchaseOrder> poList = uco.Save(newPo);
            return View("RingleFramework", poList);
        }
        #endregion

        #region Case2
        public ActionResult RingleERP()
        {
            MaintainPurchaseOrderControl uco = new MaintainPurchaseOrderControl();
            return View(uco.GetPurchaseLists());
        }

        public ActionResult RingleERPCopy(string poNumber)
        {
            MaintainPurchaseOrderControl uco = new MaintainPurchaseOrderControl();
            PurchaseOrderDto dto = uco.CopyPo(poNumber);
            return View(dto);
        }

        public ActionResult REAddPo(PurchaseOrderDto po)
        {
            MaintainPurchaseOrderControl uco = new MaintainPurchaseOrderControl();
            List<PurchaseOrderDto> poList = uco.Save(po);
            return View("RingleERP", poList);
        }
        #endregion
    }
}