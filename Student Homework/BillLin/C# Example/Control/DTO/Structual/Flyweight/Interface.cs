using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Structual.Flyweight.Intf
{
    public interface Code
    {
        List<CodeDto> GetCodeList(string parentValue = "");
    }
}
