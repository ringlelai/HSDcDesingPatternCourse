using hsdc.dpt.Control.DTO.Creational.Prototype.RingleFramework.InternalDto;
using hsdc.dpt.Control.DTO.Creational.Prototype.RingleFramework.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.Prototype.RingleFramework
{
    public class MaintainPurchaseConrol
    {
        public List<PurchaseOrder> GetPurchaseLists()
        {
            return InitialData();
        }

        private List<PurchaseOrder> InitialData()
        {
            List<PurchaseOrder> poList = new List<PurchaseOrder>();
            List<PurchaseOrderLineItemDto> items = new List<PurchaseOrderLineItemDto>();
            items.Add(new PurchaseOrderLineItemDto() { ProductNameInternal= "烏龜", QuantityInternal = 2, PriceInternal = 12 });
            items.Add(new PurchaseOrderLineItemDto() { ProductNameInternal = "小鳥", QuantityInternal = 1, PriceInternal = (decimal)15.2 });
            poList.Add(new PurchaseOrderDto() { PoNumberInternal = "PO010001", CustomerNameInternal = "Kenming", LineItemsInternal = items });
            items = new List<PurchaseOrderLineItemDto>();
            items.Add(new PurchaseOrderLineItemDto() { ProductNameInternal = "烏龜", QuantityInternal = 1, PriceInternal = (decimal)11.5 });
            poList.Add(new PurchaseOrderDto() { PoNumberInternal = "PO010002", CustomerNameInternal = "Ringle", LineItemsInternal = items });
            return poList;
        }

        public hsdc.dpt.Control.DTO.Creational.Prototype.RingleFramework.Intf.Prototype<PurchaseOrder> NewPurchaseOrder()
        {
            return new PurchaseOrderDto();
        }

        public List<PurchaseOrder> Save(PurchaseOrder po)
        {
            List<PurchaseOrder> poList = InitialData();
            po.PoNumber = "PO010003";
            poList.Add(po);
            return poList;
        }
    }
}
