using hsdc.dpt.Control.DTO.Creational.Prototype.RingleERP.InternalDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.Prototype.RingleERP
{
    public class MaintainPurchaseOrderControl
    {
        public List<PurchaseOrderDto> GetPurchaseLists()
        {
            return InitialData();
        }

        private List<PurchaseOrderDto> InitialData()
        {
            List<PurchaseOrderDto> poList = new List<PurchaseOrderDto>();
            List<PurchaseOrderLineItemDto> items = new List<PurchaseOrderLineItemDto>();
            items.Add(new PurchaseOrderLineItemDto() { ProductName = "烏龜", Quantity = 2, Price = 12 });
            items.Add(new PurchaseOrderLineItemDto() { ProductName = "小鳥", Quantity = 1, Price = (decimal)15.2 });
            poList.Add(new PurchaseOrderDto() { PoNumber = "PO010001", CustomerName = "Kenming", LineItems = items });
            items = new List<PurchaseOrderLineItemDto>();
            items.Add(new PurchaseOrderLineItemDto() { ProductName = "烏龜", Quantity = 1, Price = (decimal)11.5 });
            poList.Add(new PurchaseOrderDto() { PoNumber = "PO010002", CustomerName = "Ringle", LineItems = items });
            return poList;
        }

        public PurchaseOrderDto CopyPo(String sourcePoNumber)
        {
            PurchaseOrderDto source = InitialData().Where(p => p.PoNumber.Equals(sourcePoNumber)).SingleOrDefault();
            PurchaseOrderDto target = null;
            if (source != null)
            {
                target = source.Clone();
                target.PoNumber = string.Empty;
            }
            return target;
        }

        public List<PurchaseOrderDto> Save(PurchaseOrderDto po)
        {
            List<PurchaseOrderDto> poList = InitialData();
            po.PoNumber = "PO010003";
            poList.Add(po);
            return poList;
        }
    }
}
