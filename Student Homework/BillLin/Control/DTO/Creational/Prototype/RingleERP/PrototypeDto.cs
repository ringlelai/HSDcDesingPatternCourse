using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.Prototype.RingleERP.InternalDto
{
    public class PurchaseOrderDto : Prototype.RingleERP.Intf.PorotoType<PurchaseOrderDto>
    {

        public PurchaseOrderDto()
        {
            if (LineItems == null)
                LineItems = new List<PurchaseOrderLineItemDto>();
        }

        public PurchaseOrderDto Clone()
        {
            PurchaseOrderDto newDto = (PurchaseOrderDto)this.MemberwiseClone();
            return newDto;
        }

        public string PoNumber
        {
            get;
            set;
        }

        public string CustomerName
        {
            get;
            set;
        }

        public decimal Total
        {
            get
            {
                decimal subTotal = 0;
                if (LineItems == null)
                    return subTotal;
                LineItems.ForEach(d => subTotal += d.SubTotal);
                return subTotal;
            }
        }

        public List<PurchaseOrderLineItemDto> LineItems
        {
            get;
            set;
        }

        public void AddLineItem(PurchaseOrderLineItemDto item)
        {
            if (this.LineItems == null)
                LineItems = new List<PurchaseOrderLineItemDto>();
            LineItems.Add((PurchaseOrderLineItemDto)item);
        }
    }

    public class PurchaseOrderLineItemDto : Prototype.RingleERP.Intf.PorotoType<PurchaseOrderLineItemDto>
    {

        public PurchaseOrderLineItemDto() { }

        public PurchaseOrderLineItemDto Clone()
        {
            PurchaseOrderLineItemDto newDto = (PurchaseOrderLineItemDto)this.MemberwiseClone();
            return newDto;
        }

        public string ProductName
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public decimal SubTotal
        {
            get { return Caculate(); }
        }

        private decimal Caculate()
        {
            return Price * (decimal)Quantity;
        }
    }
}
