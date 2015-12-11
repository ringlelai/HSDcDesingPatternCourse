using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Strategy
{
    /// <summary>
    /// The 'ConcreteStrategy' Class
    /// 使用雙均線 (一長一短)交叉向上/往下，執行買進/賣出交易策略
    /// </summary>
    public class 黃金交叉Strategy : IStrategy
    {
        public string execute()
        {
            string comment;
            string pseudo_code;

            comment = "黃金交叉策略：\n" +
                "5根均Bar 與 15根均Bar 交叉向上，即執行買進；\n" +
                "5根均Bar 與 15根均Bar 交叉往上，即執行賣出;\n" +
                "==========================================\n\n";

            pseudo_code = "var MA5 = MA(5);\n" +
                          "var MA15 = MA(15);\n" +
                          "\n" +
                          "If CrossOver(MA5,MA15)\n" +
                          "    // 觸發(Trig)買進訊號\n" +
                          "else\n" +
                          "If CrossUnder(MA5,MA15)" +
                          "    // 觸發(Trig)賣出訊號\n";
 
           return comment + pseudo_code;
        }
    }
}
