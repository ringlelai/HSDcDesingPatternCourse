using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Behavioral.CoR;

namespace hsdc.dpt.Control.Behavioral.CoR
{
    /// <summary>
    /// The 'Handler' abstract class.
    /// </summary>
    public abstract class DonateHandler
    {
        public abstract string handleDonate(Donation donate);       // abstract method, 關於捐贈的邏輯處理，由 extend 的 Handler 實現
        public DonateHandler Successor { get; set; }                // 指向下一個 Handler
        public void SetHandlers(DonateHandler _successor)
        { 

        }
    }
}
