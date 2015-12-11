using hsdc.dpt.Control.DTO.Structual.Decorator;
using hsdc.dpt.Control.DTO.Structual.Decorator.intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Decorator
{
    public class DefaultUserService : UserService
    {
        public DTO.Structual.Decorator.User Login(string userId, string password)
        {
            LoginDao dao = new LoginDao();
            User u = dao.GetMemberData(userId);
            return u;
        }


        public List<Function> GetAclList(string userId)
        {
            List<Function> defaultAcl = new List<Function>();
            defaultAcl.Add(new Function() { FunctionName = "BuilderPattern", FunctionUrl = "/Builder" });
            defaultAcl.Add(new Function() { FunctionName = "PrototypePattern", FunctionUrl = "/Prototype" });
            return defaultAcl;
        }
    }

    internal class LoginDao
    {
        internal User GetMemberData(string userId)
        {
            return Users.Where(u => u.UserID.Equals(userId)).SingleOrDefault();
        }

        private List<User> Users
        {
            get
            {
                List<User> users = new List<User>();
                users.Add(new User() { UserID = "ringle", UserName = "Ringle Lai"});
                users.Add(new User() { UserID = "kenming", UserName = "Kenming Wang" });
                return users;
            }
        }
    }
}
