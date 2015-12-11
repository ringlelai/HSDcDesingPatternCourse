using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO
{
    // 購物車
    public class ShoppingCart
    {
        public List<烏龜商品> CartList { get; set; }
        public string eCoupon { get; set; }         // 折扣代碼
        public int TotalPrice { get; set; }         // 總價
    }
    public class 烏龜商品
    {
        public string id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
    }
}
