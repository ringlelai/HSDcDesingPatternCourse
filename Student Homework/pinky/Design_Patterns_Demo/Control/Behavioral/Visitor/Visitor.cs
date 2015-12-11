using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Visitor
{
    /// <summary>
    /// The 'Visitor' abstract class.
    /// </summary>
    public abstract class Visitor
    {
        // 需要針對每一個物件結構內的元素，定義相對應的操作
        abstract public void VisitEmployee(Employee emp);
        abstract public void VisitOffice(Office office);
    }
}
