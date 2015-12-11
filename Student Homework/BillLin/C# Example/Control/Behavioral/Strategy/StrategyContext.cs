using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Strategy
{
    /// <summary>
    /// The 'Context' class
    /// 交易策略處理的主體
    /// </summary>
    public class StrategyContext
    {
        // Hold a reference to a sub-clss implement IStrategy interface
        private IStrategy select_strategy;

        // 交易策略執行的操作 (每次有 Tick 資料更新時，即會呼叫該 function)
        public string UpdateOnTick()
        {
            return select_strategy.execute();
        }

        // 設定所選擇的交易策略，將參考變數指向實作該策略 Strategy 的子類別
        public void SetStrategy(IStrategy strategy)
        {
            this.select_strategy = strategy;
        }
    }
}
