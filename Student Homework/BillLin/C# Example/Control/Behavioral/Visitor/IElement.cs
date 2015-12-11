using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Visitor
{
    /// <summary>
    /// The 'Element' interface.
    /// </summary>
    public interface IElement
    {
        // 同意讓 Visitor 進入，以進行後續的操作
        void Accept(Visitor visitor);
    }
}
