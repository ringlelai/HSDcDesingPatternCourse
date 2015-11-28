using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Proxy
{
    /// <summary>
    /// The 'Subject' interface
    /// 提供所出售烏龜相關服務的介面定義
    /// 龜庫 = Tortoise Library Information Provider
    /// </summary>
    public interface I龜庫接口
    {
        /// <summary>
        /// 提供烏龜認證的資訊
        /// </summary>
        /// <param name="品種">賣出烏龜的品種</param>
        /// /// <param name="序號">賣出烏龜的序號</param>
        /// <returns>認證資訊</returns>
        string Get認證資訊(string 品種, string 序號);
    }
}
