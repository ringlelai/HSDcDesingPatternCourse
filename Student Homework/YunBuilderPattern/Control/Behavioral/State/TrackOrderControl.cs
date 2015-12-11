using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.State
{
    public class TrackOrderControl
    {
        private OrderState_SwitchCase order_state_use_switch;
        private OrderStateContext state_context;

        // constructor
        public TrackOrderControl()
        {
            order_state_use_switch = new OrderState_SwitchCase();
            state_context = new OrderStateContext();
        }

        /// <summary>
        /// 作法一：使用 Switch-Case 的作法處理訂單的狀態
        /// </summary>
        /// <returns></returns>
        public string StampOrder_1()
        {
            string procResult = order_state_use_switch.StampIt();

            return procResult;
        }

        /// <summary>
        /// 作法二：使用 State Pattern 設計處理訂單的狀態 (完全消彌掉 Switch-If-then-else)
        /// </summary>
        /// <returns></returns>
        public string StampOrder_2()
        {
            string procResult = state_context.StampIt();

            return procResult;
        }
    }
}
