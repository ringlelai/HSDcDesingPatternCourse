using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.AbstractFactory
{
    public enum AssigneeType
    { 
        ORGANIZATION,
        ROLE,
        HUMAN
    }
    public class WorkItemDTO
    {
        public string ID { get; set; }
        public string item_title { get; set; }          // 項目名稱
        public AssigneeType assign_type { get; set; }   // 指派者類型
        public string assignee_name { get; set; }       // 指派者名稱
    }
}
