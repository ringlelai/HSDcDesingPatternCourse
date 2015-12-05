using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Behavioral.Mediator
{
    public class Product
    {
        public string ProductName { get; set; }
    }

    public class Stocking
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Order
    {
        public Product Product { get; set; }
    }

    public class StockIn
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
