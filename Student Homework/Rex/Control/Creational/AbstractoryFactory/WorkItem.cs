using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Creational.AbstractFactory;

namespace hsdc.dpt.Control.Creational.AbstractoryFactory
{
    /// <summary>
    /// The 'Client' class
    /// 工作項目
    /// </summary>
    public class WorkItem
    {
        public string ID { get; set; }
        public string item_title { get; set; }
        public Participant assignee { get; set; }
    }
}
