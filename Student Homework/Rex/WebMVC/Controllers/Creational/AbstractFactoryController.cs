using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hsdc.dpt.Control.Creational.AbstractoryFactory;
using hsdc.dpt.Control.DTO.Creational.AbstractFactory;

namespace WebMVC.Controllers.Creational
{
    public class AbstractFactoryController : Controller
    {
        private 管理工作單Control control;       // declare a domain control object.

        // GET: AbstractFactory
        public ActionResult Index()
        {
            if (Session["ManageWorkItemControl"] == null)
            {
                control = new 管理工作單Control();          // new a domain control instance.
                Session["ManageWorkItemControl"] = control;
            }
            else
                Session["ManageWorkItemControl"] = control;     // hold the control object as stateful.

            return View();
        }

        public ActionResult SelectDirectoryService(string selDirectoryService)
        {
            control = (管理工作單Control)Session["ManageWorkItemControl"];     // get the control object from the Session Object.

            switch (selDirectoryService)
            {
                case "LDAP":
                    control.SetParticipantFactory(ParticipantFactoryEnum.LDAP);
                    break;
                case "LocalDB":
                    control.SetParticipantFactory(ParticipantFactoryEnum.LocalDB);
                    break;                    
            }


            return View("AddWorkItem");
        }

        public ActionResult AddWorkItem(string txtItemTitle, string selAssigneeType, string txtAssignee)
        {
            control = (管理工作單Control)Session["ManageWorkItemControl"];     // get the control object from the Session Object.
            WorkItemDTO dto = new WorkItemDTO();            // new a WorkItem DTO object.
            
            // put the form's value to the WorkItem DTO object.
            dto.item_title = txtItemTitle;            
            dto.assignee_name = txtAssignee;
            switch (selAssigneeType)
            { 
                case "ORGANIZATION" :
                    dto.assign_type = AssigneeType.ORGANIZATION;
                    break;
                case "ROLE":
                    dto.assign_type = AssigneeType.ROLE;
                    break;
                case "HUMAN":
                    dto.assign_type = AssigneeType.HUMAN;
                    break;
            }

            control.AddWorkItem(dto);       // put the WorkItem DTO object into the List object.

            return View();
        }

        public ActionResult ListWorkItems()
        {
            control = (管理工作單Control)Session["ManageWorkItemControl"];     // get the control object from the Session Object.
           
            return View(control.ListAllWorkItems());
        }

        // GET: /Process/1
        public ActionResult Process(string ID)
        {
            control = (管理工作單Control)Session["ManageWorkItemControl"];     // get the control object from the Session Object.
            ViewData["result"] = control.Process(ID);
            return View();
        }
    }
}