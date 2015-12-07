using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Adapter.供應商系統
{
    public class OrderSystem
    {
        /*
         * 實務上，需實現可供遠端存取的協定(如 Web Service)，以及公開介面與標準的參數、回傳值的格式 (如 Jason 字串)
         */

        // 僅模擬透過資訊庫取得產品清單
        public string[][] get產品清單()
        {
            string[][] products = new string[4][];
            // ================== 編號, 龜名, 價格, 數量 ==================
            products[0] = new string[] { "001", "澤龜", "300", "200" };
            products[1] = new string[] { "002", "星龜", "1800", "103" };
            products[2] = new string[] { "003", "金錢龜", "2400", "56" };
            products[3] = new string[] { "004", "象龜", "68800", "12"};
            
            return products;
        }
    }
}
