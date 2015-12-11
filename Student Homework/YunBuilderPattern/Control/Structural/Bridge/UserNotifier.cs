using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Bridge;

namespace hsdc.dpt.Control.Structural.Bridge
{
    public class UserNotifier : Notifier
    {
        /// <summary>
        /// 實現 Notify 處理的程序
        /// </summary>
        /// <param name="message">Message 物件</param>
        /// <returns>處理結果</returns>
        public override string Notify(Message message)
        {
            string procResult;       // 處理結果

            // 1. 將訊息傳送給所指定的收件人
            procResult = sender.SendMessage(message);

            return procResult;
        }
    }
}
