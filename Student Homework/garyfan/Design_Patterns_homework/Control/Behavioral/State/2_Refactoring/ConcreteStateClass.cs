using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.State
{
    // 實作在 'NEW_ORDER 狀態時所需處理的行為
    public class NewOrderState : IOrderState
    {
        public string processSomething(OrderStateContext context)
        {
            // 回傳處理過程資訊
            string procResult = "目前狀態：新訂單成立中‧‧‧\n" +
                "紀錄本關卡的處理過程‧‧‧。\n";
            //current_state = ORDER_STATE.PAID;       // 設定下一關的狀態
            context.setState(new PaidOrderState());
            
            procResult = procResult + "轉移至下一關卡狀態為：已付款";

            return procResult;            
        }
    }

    // 實作在 'PAID_ORDER 狀態時所需處理的行為
    public class PaidOrderState : IOrderState
    {
        public string processSomething(OrderStateContext context)
        {
            // 回傳處理過程資訊
            string procResult = "目前狀態：新訂單\n" +
                "紀錄本關卡的處理過程‧‧‧。\n";
            //current_state = ORDER_STATE.SHIPPED;       // 設定下一關的狀態
            context.setState(new ShippedOrderState());
            procResult = procResult + "轉移至下一關卡狀態為：已出貨\n\n";

            return procResult;
        }
    }

    // 實作在 'SHIPPED_ORDER 狀態時所需處理的行為
    public class ShippedOrderState : IOrderState
    {
        public string processSomething(OrderStateContext context)
        {
            // 回傳處理過程資訊
            string procResult = "目前狀態：已付款\n" +
                "紀錄本關卡的處理過程‧‧‧。\n";
            //current_state = ORDER_STATE.FINISHED;       // 設定下一關的狀態
            context.setState(new FINISHEDOrderState());
            procResult = procResult + "轉移至下一關卡狀態為：已完成\n\n";

            return procResult;
        }
    }

    // 實作在 'FINISHED_ORDER 狀態時所需處理的行為
    public class FINISHEDOrderState : IOrderState
    {
        public string processSomething(OrderStateContext context)
        {
            // 回傳處理過程資訊
            string procResult = "目前狀態：已完成訂單\n" +
                "紀錄本關卡的處理過程‧‧‧。\n";
            procResult = procResult + "實作上應該把已完成訂單的狀態設定為關閉 (CLOSED)\n\n";

            return procResult;
        }
    }
}
