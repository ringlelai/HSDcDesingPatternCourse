using hsdc.dpt.Control.DTO.Structual.Bridge;
using hsdc.dpt.Control.DTO.Structual.Bridge.Intf;
using hsdc.dpt.Control.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Bridge.PxHome
{
    public class QueryOrderProgress
    {
        private StatusProgressImpl implementor;
        public string Query(string OrderID)
        {
            OrderProgress progress = OrderProgress.NONE;
            Order order = QueryOrderDao.QueryOrder(OrderID);
            if (order == null)
                return EnumUtils.stringValueOf(progress);
            ProcessStatusProgressImpl(order.OrderStatus, order.Shipper);
            progress = implementor.GetCurrentOrderProgress(OrderID);
            return EnumUtils.stringValueOf(progress);
        }

        private void ProcessStatusProgressImpl(OrderStatus status, string shipper)
        {
            if (status == OrderStatus.IN_STOCK)
                this.implementor = new InStockStatusProgressImpl();
            else
            {
                if (shipper.Equals("BlackCat"))
                    this.implementor = new BlackCatDeliveryProgressImpl();
                else
                    this.implementor = new PostOfficeDeliveryProgressImpl();
            }
        }
    }

    public class InStockStatusProgressImpl : StatusProgressImpl
    {
        public OrderProgress GetCurrentOrderProgress(string oid)
        {
            int value = QueryOrderDao.RealOrderStatus(oid);
            return (OrderProgress)value;
        }
    }

    public abstract class InDeliveryProgressImpl : StatusProgressImpl
    {
        public OrderProgress GetCurrentOrderProgress(string oid)
        {
            string progress = GetProgress(GetShippingID(oid));
            return TransferToOrderProgress(progress);
        }

        public string GetShippingID(string oid)
        {
            return QueryOrderDao.QueryOrder(oid).ShippingID;
        }

        protected abstract string GetProgress(string shippingId);
        protected abstract OrderProgress TransferToOrderProgress(string shippingStatus);
    }

    public class BlackCatDeliveryProgressImpl : InDeliveryProgressImpl
    {

        protected override string GetProgress(string shippingId)
        {
            // 去黑貓宅急便取得狀態
            return SimulateWebService(shippingId);
        }

        protected override OrderProgress TransferToOrderProgress(string shippingStatus)
        {
            return shippingStatus.Equals("已送達") ? OrderProgress.DELIVERED :
                (shippingStatus.Equals("已收貨") ? OrderProgress.IN_SHIPMENT_STOCK : OrderProgress.IN_DELIVER_WAY);
        }

        private string SimulateWebService(string shippingId)
        {
            long id = long.Parse(shippingId);
            int value = (int)(id % 3);
            return value == 0 ? "已收貨" : (value == 1 ? "送達衛星所" : (value == 2 ? "送貨中" : "已送達"));
        }
    }

    public class PostOfficeDeliveryProgressImpl : InDeliveryProgressImpl
    {

        protected override string GetProgress(string shippingId)
        {
            // 去郵局取得狀態
            return SimulateWebService(shippingId);
        }

        protected override OrderProgress TransferToOrderProgress(string shippingStatus)
        {
            return shippingStatus.Equals("郵件已送達") ? OrderProgress.DELIVERED :
                (shippingStatus.Contains("已收貨") ? OrderProgress.IN_SHIPMENT_STOCK : OrderProgress.IN_DELIVER_WAY);
        }

        private string SimulateWebService(string shippingId)
        {
            long id = long.Parse(shippingId);
            int value = (int)(id % 2);
            return value == 0 ? "xx郵局已收貨" : (value == 1 ? "郵件投遞中" : "郵件已送達");
        }
    }

    // This Class need to connect to db, but now, use pseudo code
    public class QueryOrderDao
    {
        public static Order QueryOrder(string oid)
        {
            return OrderData().Where(o => o.OrderID.Equals(oid)).SingleOrDefault();
        }

        public static int RealOrderStatus(string oid)
        {
            long id = long.Parse(oid.Substring(3));
            int value = (int)(id % 3);
            return value;
        }

        public static List<Order> OrderData()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { OrderID = "ORD1411140001", OrderStatus = OrderStatus.IN_STOCK, ProductName = "Mac Book Pro" });
            orders.Add(new Order() { OrderID = "ORD1411140002", OrderStatus = OrderStatus.SHIPPING, ProductName = "ThunderBold Line", Shipper = "BlackCat", ShippingID = "1" });
            orders.Add(new Order() { OrderID = "ORD1411140003", OrderStatus = OrderStatus.SHIPPING, ProductName = "Design Pattern", Shipper = "PostOffice", ShippingID = "2" });
            return orders;
        }
    }
}
