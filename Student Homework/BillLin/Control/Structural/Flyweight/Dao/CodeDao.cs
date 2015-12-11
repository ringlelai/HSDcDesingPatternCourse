using hsdc.dpt.Control.DTO.Structual.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Flyweight.Dao
{
    internal class CodeDao
    {
        internal List<CodeDto> query(string type)
        {
            Dao.DesignPatternEntities entity = new DesignPatternEntities();
            var codes = (from c in entity.Code
                         where c.CodeType.Equals(type)
                         orderby c.Id
                         select new CodeDto() { CodeValue = c.CodeValue, CodeText = c.CodeText }).ToList();
            return codes;
        }

        internal List<CodeDto> query(string type, string parentValue)
        {
            Dao.DesignPatternEntities entity = new DesignPatternEntities();
            var codes = (from c in entity.Code
                         where c.CodeType.Equals(type) && c.Code2.CodeValue.Equals(parentValue)
                         orderby c.Id
                         select new CodeDto() { CodeValue = c.CodeValue, CodeText = c.CodeText }).ToList();
            return codes;
        }
    }
}
