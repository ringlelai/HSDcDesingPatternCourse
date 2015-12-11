using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO;

namespace hsdc.dpt.Control.Structural.Facade
{
    public class 買烏龜Control
    {        
        // Constructor
        public 買烏龜Control()
        {
        }

        public List<烏龜商品> list烏龜清單()
        {
            return this.getItems();
        }

        public ShoppingCart 確認訂購資訊(ShoppingCart cart)
        {
            烏龜BMO bmo = new 烏龜BMO();
            cart = bmo.proc訂購資訊(cart);

            return cart;
        }

        public bool Save訂購交易(ShoppingCart cart)
        {
            // Todo:
            // 交由 DAO (Data Access Object) 物件，並透 EF (Entity Framework)將本次訂購商品交易儲存至資料庫

            return true;
        }


        /*
         *  實作時，會交由如 DAO (Data Access Object) 物件，並透過 EF (Entity Framework) 從資料庫系統取得資料。         
         */
        private List<烏龜商品> getItems()
        {
            List<烏龜商品> list = new List<烏龜商品>();
            烏龜商品 item1, item2, item3;

            item1 = new 烏龜商品();
            item1.id = "001";
            item1.name = "粉圓龜";
            item1.price = 3000;

            item2 = new 烏龜商品();
            item2.id = "002";
            item2.name = "金錢龜";
            item2.price = 6000;

            item3 = new 烏龜商品();
            item3.id = "003";
            item3.name = "象龜";
            item3.price = 120000;

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);

            return list;
        }
    }
}
