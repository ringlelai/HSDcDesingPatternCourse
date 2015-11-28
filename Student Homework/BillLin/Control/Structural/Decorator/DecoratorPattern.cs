using hsdc.dpt.Control.DTO.Structual.Decorator;
using hsdc.dpt.Control.DTO.Structual.Decorator.intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Decorator
{
    public abstract class ExtendUserService : UserService
    {
        protected UserService component;
        public ExtendUserService(UserService component)
        {
            this.component = component;
        }
        public abstract User Login(string userId, string password);
        public abstract List<Function> GetAclList(string userId);
    }

    public class AuthorityUserService : ExtendUserService
    {
        public AuthorityUserService(UserService component) : base(component) { }
        public override User Login(string userId, string password)
        {
            return component.Login(userId, password);
        }

        public override List<Function> GetAclList(string userId)
        {
            List<Function> baseAcl = component.GetAclList(userId);
            Function addF = new Function() { FunctionName = "Singleton", FunctionUrl = "/Singleton" };
            if (!baseAcl.Contains(addF))
                baseAcl.Add(addF);
            return baseAcl;
        }
    }

    public abstract class AuthenticationUserService : ExtendUserService
    {
        public AuthenticationUserService(UserService component) : base(component) { }

        public override List<Function> GetAclList(string userId)
        {
            return component.GetAclList(userId);
        }
    }

    public class DbAuthenticationUserService : AuthenticationUserService
    {
        public DbAuthenticationUserService(UserService component) : base(component) { }
        public override User Login(string userId, string password)
        {
            User baseUser = component.Login(userId, password);
            if (baseUser == null)
                return baseUser;
            baseUser.UserName += " FROM DB";
            string dbpw = (new UserDao()).GetPassword(userId);
            if ((dbpw != null) && (dbpw.Equals(password)))
                return baseUser;
            return null;
        }
    }

    internal class UserDao
    {
        internal string GetPassword(string userId)
        {
            if (userId.Equals("ringle"))
            {
                return "12345";
            }
            if (userId.Equals("kenming"))
            {
                return "54321";
            }
            return null;
        }
    }

    public class LdapAuthenticationUserService : AuthenticationUserService
    {
        public LdapAuthenticationUserService(UserService component) : base(component) { }
        public override User Login(string userId, string password)
        {
            User baseUser = component.Login(userId, password);
            LdapAdapter adapter = new LdapAdapter();
            if (adapter.IsLdapUser(userId, password))
            {
                baseUser.UserName += " FROM LDAP";
                return baseUser;
            }
            return null;
        }
    }

    internal class LdapAdapter
    {
        internal bool IsLdapUser(string userId, string password)
        {
            return (((userId.Equals("ringle")) && (password.Equals("54321"))) ||
                ((userId.Equals("kenming")) && (password.Equals("12345"))));
        }
    }
}
