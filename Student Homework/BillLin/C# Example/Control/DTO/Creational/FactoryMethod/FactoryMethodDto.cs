using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContactPerson { get; set; }
    }

    public class Supplier
    {
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContactEmail { get; set; }
    }

    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public decimal ProductMSRP { get; set; }
        public bool IsDelete { get; set; }
    }
}
