using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Proxy
{
    /// <summary>
    /// The 'RealSubject' class
    /// 至總部系統取得遠端資料庫的認證資訊
    /// </summary>
    public class 龜庫Informer : I龜庫接口
    {       
        // 需了解遠端的通訊協定 (如 SOAP, RESTFUL)、介面規格 (參數、回傳值)等相關連線細節
        public string Get認證資訊(string m品種, string m序號)
        {
            // TODO: 需實作連線至遠端系統
            string queryResult = "序號:" + m序號 + " 的認證資訊從" + "「總部遠端系統」取得認證結果。";

            return queryResult;
        }
    }
}
