using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.Singleton
{
    public class Form
    {
        public string FormType { get; set; }
        public string FormDateStr { get; set; }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            return ((Form)obj).FormType.Equals(this.FormType) &&
                ((Form)obj).FormDateStr.Equals(this.FormDateStr);
        }
        public override int GetHashCode()
        {
            return FormType.GetHashCode() ^ FormDateStr.GetHashCode();
        }
    }
}
