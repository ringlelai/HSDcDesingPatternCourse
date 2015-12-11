using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Bridge;

namespace hsdc.dpt.Control.Structural.Bridge
{
    public class 傳送訊息DemoControl
    {
        private Notifier notifier;
        private IMessageSender mailSender;
        private IMessageSender lineSender;

        public 傳送訊息DemoControl()
        {
            // 實務會設計如 Factory 來產出所有的 Implementor instance            
            mailSender = new EmailSender();
            lineSender = new LineSender();
        }

        /// <summary>
        /// 處理傳遞訊息的控制邏輯
        /// </summary>
        /// <param name="notifytype">enum: System, User</param>
        /// <param name="sendertype">enum: Email, Line</param>
        /// <param name="message">訊息物件</param>
        /// <returns></returns>
        public string Notify(NotifyType notifytype, SenderType sendertype, Message message)
        {
            string procResult = "";
            
            // 判斷需產出哪一個 RefinedAbstraction 的子類別物件
            switch (notifytype)
            { 
                case NotifyType.System :
                    notifier = new SystemNotifier();
                    break;
                case NotifyType.User :
                    notifier = new UserNotifier();
                    break;
            }

            // 判斷需哪個實作 MessageSender 介面的實作物件來服務
            // 實務上會設計如 List or Hastable 集合儲存這些實作物件，並透過 Key 來取得相對應的實作物件
            switch (sendertype)
            { 
                case SenderType.Email :
                    notifier.sender = mailSender;
                    break;
                case SenderType.Line :
                    notifier.sender = lineSender;
                    break;
            }

            // 回傳執行結果，藉此觀察使用哪一個 Notifier 子類別物件與 MessengSender 物件
            procResult = notifier.Notify(message);

            return procResult;
        }
    }
}
