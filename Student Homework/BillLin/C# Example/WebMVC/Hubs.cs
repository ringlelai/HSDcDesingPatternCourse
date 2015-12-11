using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using hsdc.dpt.Control.Behavioral.Mediator.Intf;
using hsdc.dpt.Control.Behavioral.Mediator;
using hsdc.dpt.Control.DTO.Behavioral.Mediator;

namespace WebMVC.Controllers.Behavioural
{
    public class OrderHub : Hub, NotifierProxy
    {
        private const string GROUP = "ORDER";

        public override System.Threading.Tasks.Task OnConnected()
        {
            StockingMediator.Instance.OrderColleagues.Add(new OrderColleague(StockingMediator.Instance, this));
            Groups.Add(Context.ConnectionId, GROUP);
            return base.OnConnected();
        }

        public void Notify(string prodName)
        {
            Clients.Group(GROUP).Notify(prodName);
        }

        public void Send(string prodName)
        {
            StockingMediator.Instance.OrderColleagues[0].Send(new Order() { Product = new Product() { ProductName = prodName } });
            if ((new StockingUco()).CheckQunatity(prodName))
                Clients.All.AddSellOut(prodName);
        }
    }

    public class StockInHub : Hub, NotifierProxy
    {
        private const string GROUP = "STOCKING";

        public override System.Threading.Tasks.Task OnConnected()
        {
            StockingMediator.Instance.StockInColleagues.Add(new StockInColleague(StockingMediator.Instance, this));
            Groups.Add(Context.ConnectionId, GROUP);
            return base.OnConnected();
        }

        public void Notify(string prodName)
        {
            Clients.Group(GROUP).Notify(prodName);
        }

        public void Send(string prodName, int qty)
        {
            StockingMediator.Instance.StockInColleagues[0].Send(new StockIn() { Product = new Product() { ProductName = prodName }, Quantity = qty });
        }
    }
}