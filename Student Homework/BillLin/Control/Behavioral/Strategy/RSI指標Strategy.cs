using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Strategy
{
    /// <summary>
    /// The 'ConcreteStrategy' Class
    /// 使用指標數值，>30 執行買進；<70 執行賣出交易策略
    /// </summary>
    public class RSI指標Strategy : IStrategy
    {
        public string execute()
        {
            string comment;
            string pseudo_code;

            comment = "RSI 交易策略：\n" +
                "指標數值>30，即執行買進；\n" +
                "指標數值<70，即執行賣出;\n" +
                "==========================================\n\n";

            pseudo_code = "var RSI = RSI(CLOSED,14);\n" +
                          "\n" +
                          "If  CrossOver(RSI, 30)\n" +
                          "  // 觸發(Trig)買進訊號\n" +
                          "else\n" +
                          "  If CrossUnder(RSI, 70)\n" +
                          "  // 觸發(Trig)賣出訊號\n";

            return comment + pseudo_code;
        }
    }
}
