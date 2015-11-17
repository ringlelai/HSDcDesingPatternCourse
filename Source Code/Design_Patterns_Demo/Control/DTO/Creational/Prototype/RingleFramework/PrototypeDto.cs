using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.Prototype.RingleFramework.InternalDto
{
    public class PurchaseOrderDto : Prototype.RingleFramework.Intf.Prototype<Prototype.RingleFramework.Intf.PurchaseOrder>, Prototype.RingleFramework.Intf.PurchaseOrder
    {

        internal PurchaseOrderDto()
        {
            if (LineItemsInternal == null)
                LineItemsInternal = new List<PurchaseOrderLineItemDto>();
        }

        public Intf.PurchaseOrder Clone()
        {
            return new PurchaseOrderDto();
        }

        public string PoNumber
        {
            get { return PoNumberInternal; }
            set { this.PoNumberInternal = value; }
        }

        public string CustomerName
        {
            get { return CustomerNameInternal; }
            set { this.CustomerNameInternal = value; }
        }

        public decimal Total
        {
            get {
                decimal subTotal = 0;
                if (LineItemsInternal == null)
                    return subTotal;
                LineItemsInternal.ForEach(d => subTotal += ((Prototype.RingleFramework.Intf.PurchaseOrderLineItem)d).SubTotal);
                return subTotal;
            }
        }

        public List<Intf.PurchaseOrderLineItem> LineItems
        {
            get { return LineItemsInternal.ConvertAll<Intf.PurchaseOrderLineItem>(new Converter<PurchaseOrderLineItemDto, Intf.PurchaseOrderLineItem>(DtoToIntf)); }
        }

        public void AddLineItem(Intf.PurchaseOrderLineItem item)
        {
            if (this.LineItemsInternal == null)
                LineItemsInternal = new List<PurchaseOrderLineItemDto>();
            LineItemsInternal.Add((PurchaseOrderLineItemDto)item);
        }

        internal String PoNumberInternal { get; set; }
        internal String CustomerNameInternal { get; set; }
        internal List<PurchaseOrderLineItemDto> LineItemsInternal { get; set; }
        internal Intf.PurchaseOrderLineItem DtoToIntf(PurchaseOrderLineItemDto dto)
        {
            return dto as Intf.PurchaseOrderLineItem;
        }
    }

    public class PurchaseOrderLineItemDto : Prototype.RingleFramework.Intf.Prototype<Intf.PurchaseOrderLineItem>, Prototype.RingleFramework.Intf.PurchaseOrderLineItem
    {

        internal PurchaseOrderLineItemDto() { }

        public Intf.PurchaseOrderLineItem Clone()
        {
            return new PurchaseOrderLineItemDto();
        }

        public string ProductName
        {
            get { return ProductNameInternal; }
            set { this.ProductNameInternal = value; }
        }

        public int Quantity
        {
            get { return QuantityInternal; }
            set { this.QuantityInternal = value; }
        }

        public decimal Price
        {
            get { return PriceInternal; }
            set { this.PriceInternal = value; }
        }

        public decimal SubTotal
        {
            get { return Caculate(); }
        }

        internal string ProductNameInternal { get; set; }
        internal int QuantityInternal { get; set; }
        internal decimal PriceInternal { get; set; }
        private decimal Caculate()
        {
            return PriceInternal * (decimal)QuantityInternal;
        }
    }
}
