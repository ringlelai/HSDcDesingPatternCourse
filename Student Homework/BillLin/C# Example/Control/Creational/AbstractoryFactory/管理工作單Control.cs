using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Creational.AbstractFactory;

namespace hsdc.dpt.Control.Creational.AbstractoryFactory
{
    public class 管理工作單Control
    {
        private List<WorkItemDTO> workitemList;     // Act as a in-memory repository
        private ParticipantFactory factory;

        // constructor
        public 管理工作單Control()
        {
            workitemList = new List<WorkItemDTO>();
        }

        /// <summary>
        /// 設定所使用的參與者工廠
        /// 目前提供的工廠：LDAP / LocalDB
        /// </summary>
        public void SetParticipantFactory(ParticipantFactoryEnum factory_type)
        {
            switch (factory_type)
            { 
                case ParticipantFactoryEnum.LDAP :
                    factory = new LDAPParticipantFactory();
                    break;
                case ParticipantFactoryEnum.LocalDB:
                    factory = new LocalDBParticipantFactory();
                    break;
            }
        }


        /// <summary>
        /// 新增工作單 (WorkItem)
        /// </summary>
        public void AddWorkItem(WorkItemDTO wkdto)
        {
            wkdto.ID = (workitemList.Count() + 1).ToString();       // Set the WorkItem ID
            workitemList.Add(wkdto);                                // Add the WorkItem DTO to the List
        }

        /// <summary>
        /// 列出所有工作單項目
        /// </summary>
        /// <returns></returns>
        public List<WorkItemDTO> ListAllWorkItems()
        {
            return this.workitemList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WorkItemID">工作單號</param>
        /// <returns></returns>
        public string Process(string WorkItemID)
        {
            WorkItemDTO dto = (WorkItemDTO)workitemList.SingleOrDefault(x => x.ID == WorkItemID);
            WorkItem wkItem = new WorkItem();

            wkItem.ID = dto.ID;
            wkItem.item_title = dto.item_title;

            switch (dto.assign_type)
            {
                case AssigneeType.ORGANIZATION:
                    wkItem.assignee = factory.CreateOrganizationParticipant();
                    wkItem.assignee.assignType = AssigneeType.ORGANIZATION;
                    break;
                case AssigneeType.ROLE:
                    wkItem.assignee = factory.CreateRoleParticipant();
                    wkItem.assignee.assignType = AssigneeType.ROLE;
                    break;
                case AssigneeType.HUMAN:
                    wkItem.assignee = factory.CreateHumanParticipant();
                    wkItem.assignee.assignType = AssigneeType.HUMAN;
                    break;
            }
            wkItem.assignee.aggignee_name = dto.assignee_name;

            return wkItem.assignee.process();
        }
    }
}
