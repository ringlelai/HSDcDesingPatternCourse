using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.Builder.Intf
{
    public interface OfficeFormBuilder<T>
    {
        void BuildMaster();
        void BuildDetails();
        T GetResult();
    }
}
