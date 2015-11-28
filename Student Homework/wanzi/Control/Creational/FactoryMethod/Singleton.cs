using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.FactoryMethod.Singleton
{
    internal class Db
    {
        private static volatile Db instance;
        private static object syncRoot = new Object();
        private List<Customer> customers;
        private List<Supplier> suppliers;
        private List<Product> products;

        private Db()
        {
            customers = new List<Customer>();
            customers.Add(new Customer() { CustomerID = "CUST001", CustomerName = "保險公司" , CustomerContactPerson = "保險人" });
            customers.Add(new Customer() { CustomerID = "CUST002", CustomerName = "工研院", CustomerContactPerson = "工研人" });
            customers.Add(new Customer() { CustomerID = "CUST003", CustomerName = "鋼鐵公司", CustomerContactPerson = "鋼鐵人" });
            suppliers = new List<Supplier>();
            suppliers.Add(new Supplier() { SupplierID = "SUPP001" , SupplierName = "Sparx Systems" , SupplierContactEmail = "xxxx@sparxsystems.com" });
            suppliers.Add(new Supplier() { SupplierID = "SUPP002", SupplierName = "Microsfot", SupplierContactEmail = "yyyy@microsoft.com" });
            products = new List<Product>();
            products.Add(new Product() { ProductID = "PROD001" , ProductName = "Enterprise Architect Corporate Edition" , ProductType = "Software" , ProductMSRP = 10000 , IsDelete = false });
            products.Add(new Product() { ProductID = "PROD002", ProductName = "Visual Studtio 2013 Ultimate Edition", ProductType = "Software", ProductMSRP = 200000 , IsDelete = false });
            products.Add(new Product() { ProductID = "PROD003", ProductName = "HSDc Sequece Plugin", ProductType = "Software", ProductMSRP = 3500 , IsDelete = false });
            products.Add(new Product() { ProductID = "PROD004", ProductName = "HSDc Workflow Engine", ProductType = "Open Source", ProductMSRP = 0 , IsDelete = false });
            products.Add(new Product() { ProductID = "PROD005", ProductName = "Borland Together", ProductType = "Software", ProductMSRP = 180000, IsDelete = true });
        }

        internal static Db Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Db();
                    }
                }

                return instance;
            }
        }

        internal List<Customer> Customers()
        {
            return this.customers;
        }

        internal List<Supplier> Suppliers()
        {
            return this.suppliers;
        }

        internal List<Product> Products()
        {
            return this.products;
        }
    }
}
