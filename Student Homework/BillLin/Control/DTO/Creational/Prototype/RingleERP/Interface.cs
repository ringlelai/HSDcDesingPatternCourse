using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.Prototype.RingleERP.Intf
{
    public interface PorotoType<T>
    {
        T Clone();
    }
}
