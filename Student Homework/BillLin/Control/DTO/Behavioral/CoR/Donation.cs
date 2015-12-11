using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Behavioral.CoR
{
    // 政治獻金 Data Type
    public class Donation
    {
        public string name { get; set; }
        public DonateType type { get; set; }        // 個人；營利事業；人民團體；UNKNOWN
        public int money { get; set; }              // 捐款金額
        public string ext_info { get; set; }        // 關於捐款相關事宜的備註/摘要
    }
}