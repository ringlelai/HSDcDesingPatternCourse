using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Structual.Decorator
{
    public class User
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
    }

    public class Function
    {
        public string FunctionName { get; set; }
        public string FunctionUrl { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ FunctionName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Function))
                return false;
            Function f = (Function)obj;
            return FunctionName.Equals(f.FunctionName);
        }
    }
}
