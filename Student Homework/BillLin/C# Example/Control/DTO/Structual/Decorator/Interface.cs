using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Structual.Decorator.intf
{
    public interface UserService
    {
        User Login(string userId, string password);
        List<Function> GetAclList(string userId);
    }
}
