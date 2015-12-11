using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.State
{
    /// <summary>
    /// The 'Context' Class
    /// 1. 定義外界會呼叫使用的 function，且該 function 會影響狀態的變化
    /// 2. 持有實現 (realize) State 介面 (interface) 的子類別 (Concrete State)個體 (instance)，代表現行狀態。
    /// </summary>
    public class OrderStateContext
    {
        // 指向實現 IOrderState 介面的子類別的參考變數；代表現行的狀態。
        private IOrderState current_state;

        // constructor
        public OrderStateContext()
        {
            current_state = new NewOrderState();        // 訂單建立時的初始狀態為 'NEW_ORDER'
        }

        // 依據訂單的狀態處理並簽署該狀態下的執行情形
        public string StampIt()
        {
            string procResult = current_state.processSomething(this);

            return procResult;
        }

        // 設定下一關卡的狀態
        public void setState(IOrderState state)
        {
            current_state = state;
        }
    }
}
