using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Bridge;

namespace hsdc.dpt.Control.Structural.Bridge
{
    /// <summary>
    /// The 'Abstraction' class
    /// 負責處理通知訊息工作的抽象類別
    /// </summary>
    public abstract class Notifier
    {
        // 將 send(message) 的實作交由實作 Message Sender 介面的具體物件來負責
        // Notifier 不負責 send() 的實作
        public IMessageSender sender { get; set; }

        // 定義為抽象方法，交由子類別來實作
        public abstract string Notify(Message message);
    }
}
