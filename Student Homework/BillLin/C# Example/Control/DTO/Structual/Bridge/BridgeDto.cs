using hsdc.dpt.Control.DTO.Structual.Bridge.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Structual.Bridge
{
    public class Order
    {
        public string OrderID { get; set; }
        public string ProductName { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Shipper { get; set; }
        public string ShippingID { get; set; }
    }
}
