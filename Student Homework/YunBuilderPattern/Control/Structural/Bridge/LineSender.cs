using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO.Structual.Bridge;

namespace hsdc.dpt.Control.Structural.Bridge
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// 實現由 Line 傳送訊息
    /// </summary>
    public class LineSender : IMessageSender
    {
        // 實務上，需實作呼叫 Line 系統的 API
        // 將訊息傳入至 Line 系統        
        public string SendMessage(Message msg)
        {            
            string result;
            result = "交由 Line Sender 傳送：\n\n"
                + "收件人：" + msg.Recipient + "\n"
                + "主旨　：" + msg.Subject + "\n"
                + "內容　：" + msg.Body;
            return result;
        }

        // 模擬將訊息內容編碼的程序
        public string 編碼(string msgBody)
        {
            // Line 不實作編碼的程序，僅傳未編碼的訊息內容
            return msgBody;
        }
    }
}
