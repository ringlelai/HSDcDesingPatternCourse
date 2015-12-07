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
    /// 實現電子郵件的傳送訊息
    /// </summary>
    public class EmailSender : IMessageSender
    {       
        // 實務上，需實作呼叫郵件系統(如 SMTP)的 API
        // 將訊息傳入至郵件系統
        public string SendMessage(Message msg)
        {
            string result;
            result = "交由 Email Sender 傳送：\n\n"
                + "收件人：" + msg.Recipient + "\n"
                + "主旨　：" + msg.Subject + "\n"
                + "內容　：" + msg.Body;
            return result;
        }

        // 模擬將訊息內容編碼的程序
        public string 編碼(string msgBody)
        {
            string mBody = "{已編碼內容：" + msgBody + "}\n\n";
            return mBody;
        }
    }
}
