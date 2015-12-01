using hsdc.dpt.Control.Creational.FactoryMethod.Erp;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using hsdc.dpt.Control.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Creational.FactoryMethod.Mail;

namespace WebMVC.Controllers.Creational
{
    public class FactoryMethodController : Controller
    {
        // GET: FactoryMethod
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MaintainCustomer()
        {
            MaintainCustomerUco uco = new MaintainCustomerUco();
            List<Customer> customers = uco.ListAll();
            return View("MaintainCustomer", customers);
        }
        public ActionResult CreateCustomer()
        {
            return MaintainCustomer();
        }

        public ActionResult EditCustomer(string id)
        {
            return MaintainCustomer();
        }

        public ActionResult DeleteCustomer(string id)
        {
            return MaintainCustomer();
        }

        public ActionResult MaintainSupplier()
        {
            MaintainSupplierUco uco = new MaintainSupplierUco();
            List<Supplier> suppliers = uco.ListAll();
            return View("MaintainSupplier", suppliers);
        }

        public void SendNotifyMail()
        {
            SendNotifyMailUco uco = new SendNotifyMailUco();
            uco.send();
        }

        public void SendErrorMail()
        {
            SendErrorMailUco uco = new SendErrorMailUco();
            uco.send();
        }

        public ActionResult CreateSupplier()
        {
            return MaintainSupplier();
        }

        public ActionResult EditSupplier(string id)
        {
            return MaintainSupplier();
        }

        public ActionResult DeleteSupplier(string id)
        {
            return MaintainSupplier();
        }

        public ActionResult MaintainProduct()
        {
            MaintainProductUco uco = new MaintainProductUco();
            List<Product> products = uco.ListAll();
            return View("MaintainProduct", products);
        }
        public ActionResult CreateProduct()
        {
            return MaintainProduct();
        }

        public ActionResult EditProduct(string id)
        {
            return MaintainProduct();
        }

        public ActionResult DeleteProduct(string id)
        {
            return MaintainProduct();
        }
    }
}