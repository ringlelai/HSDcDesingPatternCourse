using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Strategy
{
    /// <summary>
    /// The 'Strategy' Interface
    /// 制訂交易策略的共同介面
    /// </summary>
    public interface IStrategy
    {
        // 執行策略的操作
        string execute();
    }
}
