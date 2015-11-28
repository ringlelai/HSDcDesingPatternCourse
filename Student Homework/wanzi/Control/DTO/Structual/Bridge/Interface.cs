using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Structual.Bridge.Intf
{
    internal interface StatusProgressImpl
    {
        OrderProgress GetCurrentOrderProgress(string oid);
    }

    public enum OrderProgress
    {
        [DescriptionAttribute("收到訂單")]
        RECEIVE_ORDER = 0,
        [DescriptionAttribute("撿貨")]
        PICK_PRODUCT = 1,
        [DescriptionAttribute("理貨")]
        ARRANGE_PRODUCT = 2,
        [DescriptionAttribute("出貨")]
        SHIPPING = 3,
        [DescriptionAttribute("宅配單位收貨")]
        IN_SHIPMENT_STOCK = 4,
        [DescriptionAttribute("宅配單位運送中")]
        IN_DELIVER_WAY = 5,
        [DescriptionAttribute("到貨")]
        DELIVERED = 6,
        [DescriptionAttribute("無資料")]
        NONE = 99
    }

    public enum OrderStatus
    {
        IN_STOCK,
        SHIPPING
    }
}
