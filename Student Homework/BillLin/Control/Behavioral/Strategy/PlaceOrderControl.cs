using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Behavioral.Strategy;

namespace hsdc.dpt.Control.Behavioral.Strategy
{
    /// <summary>
    /// The 'Client' Class
    /// 處理交易的控制類別
    /// </summary>
    public class PlaceOrderControl
    {
        private StrategyContext context;

        // constructor
        public PlaceOrderControl()
        {
            this.context = new StrategyContext();
        }

        // 執行交易策略
        public string ExecuteStrategy(StrategyType type)
        {
            string procResult;

            // TODO: 這一段未來重構(refactor)時應該要交給工廠物件產生
            switch (type)
            {
                case(StrategyType.GoldenCross):
                    context.SetStrategy(new 黃金交叉Strategy());
                    break;
                case(StrategyType.RSI):
                    context.SetStrategy(new RSI指標Strategy());
                    break;
                default:
                    procResult = string.Empty;
                    break;
            }
            procResult = context.UpdateOnTick();
            
            return procResult;
        }
    }
}