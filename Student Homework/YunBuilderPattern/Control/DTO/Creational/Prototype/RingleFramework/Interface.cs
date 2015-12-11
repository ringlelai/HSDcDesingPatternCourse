using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.Prototype.RingleFramework.Intf
{
    public interface PurchaseOrder
    {
        String PoNumber { get; set; }
        String CustomerName { get; set; }
        List<PurchaseOrderLineItem> LineItems { get; }
        void AddLineItem(PurchaseOrderLineItem item);
        decimal Total { get; }
    }

    public interface PurchaseOrderLineItem
    {
        String ProductName { get; set; }
        int Quantity { get; set; }
        decimal Price { get; set; }
        decimal SubTotal { get; }
    }

    public interface Prototype<T>
    {
        T Clone();
    }
}
