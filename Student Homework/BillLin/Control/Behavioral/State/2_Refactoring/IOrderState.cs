using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.State
{
    /// <summary>
    /// The 'State' Interface
    /// 定義 Context 內的 function，在某特定狀態下所需處理的行為
    /// </summary>
    public interface IOrderState
    {        
        /// <summary>
        /// 定義訂單在各狀態的處理行為
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        string processSomething(OrderStateContext context);
    }
}
