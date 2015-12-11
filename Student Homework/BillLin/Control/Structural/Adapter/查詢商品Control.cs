using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO.Structual.Adapter;

namespace hsdc.dpt.Control.Structural.Adapter
{
    public class 查詢商品Control
    {
        // Constructor
        public 查詢商品Control()
        { 
        }

        public List<烏龜商品> get可訂購烏龜清單()
        {
            IGet存貨資訊 adapter = this.getAdapter();

            return adapter.get存貨清單();
        }

        // 取得實現 IGet存貨資訊 介面的物件。
        // TODO： 實務上會透過如 Factory 工廠類別產出實作介面的 Adatper 物件並傳回
        // 附帶說明：ADO.NET 的資料庫連線物件即為以此方式取得
        private IGet存貨資訊 getAdapter()
        {                        
            return new Get存貨Adapter();
        }
    }
}
