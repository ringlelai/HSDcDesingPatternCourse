using hsdc.dpt.Control.DTO.Structual.Decorator;
using hsdc.dpt.Control.DTO.Structual.Decorator.intf;
using hsdc.dpt.Control.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers.Structural
{
    public class DecoratorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Login(string type, string userId, string password)
        {
            UserService userService = new DefaultUserService();
            switch (type)
            {
                case "db":
                    userService = new DbAuthenticationUserService(userService);
                    break;
                case "ldap":
                    userService = new AuthorityUserService(new LdapAuthenticationUserService(userService));
                    break;
                default:
                    break;
            }
            return Json(new Result() { User = userService.Login(userId, password), Acl = userService.GetAclList(userId) }, JsonRequestBehavior.AllowGet);
        }
    }

    public class Result
    {
        public User User { get; set; }
        public List<Function> Acl { get; set; }
    }
}