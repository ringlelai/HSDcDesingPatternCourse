using hsdc.dpt.Control.Behavioral.Mediator.Intf;
using hsdc.dpt.Control.Behavioral.Mediator.Singleton;
using hsdc.dpt.Control.DTO.Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Mediator
{
    public abstract class Colleague<T> : NotifierProxy
    {
        protected Mediator mediator;
        protected NotifierProxy proxy;
        public Colleague(Mediator mediator, NotifierProxy proxy)
        {
            this.proxy = proxy;
            this.mediator = mediator;
        }
        public abstract void Send(T obj);

        public abstract void Notify(string prodName);
    }

    public abstract class Mediator
    {
        public abstract void Negociate<T>(Colleague<T> sender, Product product);
    }
    [Serializable]
    public class OrderColleague : Colleague<Order>
    {
        public OrderColleague(Mediator mediator, NotifierProxy proxy) : base(mediator, proxy) { }
        public override void Notify(string prodName)
        {
            proxy.Notify(prodName);
        }

        public override void Send(Order obj)
        {
            if (Db.Instance.GetStocking().Where(s => s.Product.ProductName == obj.Product.ProductName).SingleOrDefault().Quantity > 0)
                Db.Instance.GetStocking().Where(s => s.Product.ProductName == obj.Product.ProductName).SingleOrDefault().Quantity -= 1;
            this.mediator.Negociate(this, obj.Product);
        }
    }
    [Serializable]
    public class StockInColleague : Colleague<StockIn>, NotifierProxy
    {
        public StockInColleague(Mediator mediator, NotifierProxy proxy) : base(mediator, proxy) { }
        public override void Notify(string prodName)
        {
            proxy.Notify(prodName);
        }

        public override void Send(StockIn obj)
        {
            Db.Instance.GetStocking().Where(s => s.Product.ProductName == obj.Product.ProductName).SingleOrDefault().Quantity += obj.Quantity;
            this.mediator.Negociate(this, obj.Product);
        }
    }
    [Serializable]
    public class StockingMediator : Mediator
    {
        private static volatile StockingMediator instance;
        private static object syncRoot = new Object();
        public static StockingMediator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new StockingMediator();
                    }
                }

                return instance;
            }
        }
        private StockingMediator() 
        {
            OrderColleagues = new List<OrderColleague>();
            StockInColleagues = new List<StockInColleague>();
        }
        public List<OrderColleague> OrderColleagues {get; set;}
        public List<StockInColleague> StockInColleagues{get; set;}
        
        public override void Negociate<T>(Colleague<T> sender, Product product)
        {
            if (sender.GetType() == typeof(OrderColleague))
            {
                if (Db.Instance.GetStocking().Where(s => s.Product.ProductName == product.ProductName).SingleOrDefault().Quantity < 1)
                    foreach(var colleague in StockInColleagues)
                        colleague.Notify(product.ProductName);
            }
            else if (sender.GetType() == typeof(StockInColleague))
            {
                if (Db.Instance.GetStocking().Where(s => s.Product.ProductName == product.ProductName).SingleOrDefault().Quantity > 0)
                    foreach(var colleague in OrderColleagues)
                        colleague.Notify(product.ProductName);
            }
            else
            {
                throw new NotSupportedException("Colleague Type " + sender.GetType().FullName + " Not Support");
            }
        }
    }
}
