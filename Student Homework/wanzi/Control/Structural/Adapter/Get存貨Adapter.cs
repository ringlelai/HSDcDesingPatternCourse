using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO.Structual.Adapter;
using hsdc.dpt.Control.Structural.Adapter.供應商系統;

namespace hsdc.dpt.Control.Structural.Adapter
{
    // Realize the IGet存貨資訊 Interface
    public class Get存貨Adapter : IGet存貨資訊
    {
        public List<烏龜商品> get存貨清單()
        {
            OrderSystem mOrder = new OrderSystem();     // 建立對外部供應商系統的參考
            List<烏龜商品> aProdList = new List<烏龜商品>();

            // 從外部系統取得產品清單
            // TODO: 實務應實作如何取得遠端系統的協定, 介面, 參數, 回傳值
            string[][] mOrders = mOrder.get產品清單();

            // A供應商系統的回傳格式為2維字串陣列，因本系統以 List 為回傳值，故需實作轉型的工作
            foreach (string[] product in mOrders)
            {
                烏龜商品 aProd = new 烏龜商品();

                aProd.id = product[0];
                aProd.name = product[1];
                aProd.price = Convert.ToInt32(product[2]);
                aProd.quantity = Convert.ToInt32(product[3]);

                // 將轉型後的烏龜商品資訊新增至 List 集合
                aProdList.Add(aProd);
            }

            return aProdList;
        }
    }
}