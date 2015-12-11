using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.AbstractoryFactory
{
    public class LocalDBOrganizationParticipant : OrganizationParticipant
    {
        public override string process()
        {
            string process_result = "製造工廠： LocalDBFactory\n" +
                                    "參與者類型： Organization\n" +
                                    "參與者： " + this.aggignee_name + "\n" +
                                    "執行處理工作事務...。";

            return process_result;
        }
    }

    public class LocalDBRoleParticipant : RoleParticipant
    {
        public override string process()
        {
            string process_result = "製造工廠： LocalDBFactory\n" +
                                    "參與者類型： Role\n" +
                                    "參與者： " + this.aggignee_name + "\n" +
                                    "執行處理工作事務...。";

            return process_result;
        }
    }

    public class LocalDBHumanParticipant : HumanParticipant
    {
        public override string process()
        {
            string process_result = "製造工廠：LocalDBFactory\n" +
                                    "參與者類型： Organization\n" +
                                    "參與者： " + this.aggignee_name + "\n" +
                                    "執行處理工作事務...。";

            return process_result;
        }
    }
}