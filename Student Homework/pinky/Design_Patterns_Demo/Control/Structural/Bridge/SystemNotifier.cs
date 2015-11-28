using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Bridge;

namespace hsdc.dpt.Control.Structural.Bridge
{
    public class SystemNotifier : Notifier
    {
        /// <summary>
        /// 實現 Notify 處理的程序
        /// </summary>
        /// <param name="message">Message 物件</param>
        /// <returns>處理結果</returns>
        public override string Notify(Message message)
        {
            string procResult;       // 處理結果
            
            // 1. 寫入到 System Event Log
            procResult = "程序：訊息內容寫入到 System Event Log\n\n";
            
            // 2.1 將訊息內容編碼
            procResult = procResult + "執行編碼程序：\n";
            message.Body = sender.編碼(message.Body);

            // 2.2 將訊息傳送給所指定的收件人
            procResult = procResult + sender.SendMessage(message);

            return procResult;
        }
    }
}
