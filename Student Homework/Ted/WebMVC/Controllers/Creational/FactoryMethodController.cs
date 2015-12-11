using hsdc.dpt.Control.Creational.FactoryMethod.Ted;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Creational
{
    public class FactoryMethodController : Controller
    {
        // GET: FactoryMethod
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowUpdatedAmazonOrders()
        {
            AmazonMarketplace marketplace = new AmazonMarketplace();
            MarketplaceAdapter adapter = marketplace.CreateMarketplaceAdapter();
            List<Order> orders = adapter.GetUpdatedOrders(new DateTime(1900, 1, 1));
            return View("Orders", orders);
        }

        public ActionResult ShowUpdatedEBayOrders()
        {
            EBayMarketplace marketplace = new EBayMarketplace();
            MarketplaceAdapter adapter = marketplace.CreateMarketplaceAdapter();
            List<Order> orders = adapter.GetUpdatedOrders(new DateTime(1900, 1, 1));
            return View("Orders", orders);
        }

    }
}