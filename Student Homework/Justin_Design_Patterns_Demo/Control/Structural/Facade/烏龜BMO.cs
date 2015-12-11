using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO;

namespace hsdc.dpt.Control.Structural.Facade
{
    // BMO = Business Management Object
    // 負責關於烏龜商品的商務邏輯處理與運算
    public class 烏龜BMO
    {
        public ShoppingCart proc訂購資訊(ShoppingCart cart)
        {
            int total = 0;
            foreach (烏龜商品 item in cart.CartList)
            {
                total = total + (item.price * item.quantity);
            }

            // Todo:
            // 實作應有相關於 eCoupon 的處理邏輯︰這裡僅示範簡單的商業邏輯處理
            if (cart.eCoupon.Equals("1688"))
                cart.TotalPrice = Convert.ToInt32(total * 0.9);      //九折優惠
            else
                cart.TotalPrice = total;

            return cart;
        }
    }
}
