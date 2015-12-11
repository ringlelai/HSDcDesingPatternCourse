using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Structual.Bridge
{
    public class Message
    {
        public string ID { get; set; }
        public string Recipient { get; set; }       // 收件人
        public string Subject { get; set; }         // 主旨
        public string Body { get; set; }            // 內容
    }
}
