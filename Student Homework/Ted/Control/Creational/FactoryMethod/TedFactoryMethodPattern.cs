using hsdc.dpt.Control.Behavioral.FactoryMethod.Singleton;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.FactoryMethod.Ted
{
    public abstract class Marketplace
    {
        public abstract MarketplaceAdapter CreateMarketplaceAdapter();
    }

    public abstract class MarketplaceAdapter
    {
        public abstract List<Order> GetUpdatedOrders(DateTime startDate);
    }

    public class AmazonMarketplace : Marketplace
    {
        public override MarketplaceAdapter CreateMarketplaceAdapter()
        {
            return new AmazonAdapter();
        }
    }

    public class EBayMarketplace : Marketplace
    {
        public override MarketplaceAdapter CreateMarketplaceAdapter()
        {
            return new EBayAdapter();
        }
    }


    public class AmazonAdapter : MarketplaceAdapter
    {
        public override List<Order> GetUpdatedOrders(DateTime startDate)
        {
            List<Order> orders = new List<Order>();
            Order someOrder = new Order();
            someOrder.OrderID = "AmazonOrder123";
            someOrder.OrderTime = new DateTime(2015, 12, 19);
            orders.Add(someOrder);
            return orders;
        }
    }

    public class EBayAdapter : MarketplaceAdapter
    {
        public override List<Order> GetUpdatedOrders(DateTime startDate)
        {
            List<Order> orders = new List<Order>();
            Order someOrder = new Order();
            someOrder.OrderID = "EBayOrder123";
            someOrder.OrderTime = new DateTime(2015, 10, 15);
            orders.Add(someOrder);
            return orders;
        }
    }
}
