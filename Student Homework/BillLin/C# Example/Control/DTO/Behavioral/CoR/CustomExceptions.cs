using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Behavioral.CoR
{
    // User-defined Exception : 政治獻金超出法定限額
    public class DonateExceedException : Exception
    {
        public DonateExceedException():base() { } 
        public DonateExceedException (string message): base(message) { }
    }

    public class NullHanderException : NullReferenceException
    { 
        public NullHanderException():base() { } 
        public NullHanderException (string message): base(message) { }
    }
}
