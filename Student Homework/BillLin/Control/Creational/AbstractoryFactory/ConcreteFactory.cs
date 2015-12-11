using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.AbstractoryFactory
{
    /// <summary>
    /// The 'Concrete Factory' class.
    /// </summary>
    public class LDAPParticipantFactory : ParticipantFactory
    {
        public override OrganizationParticipant CreateOrganizationParticipant()
        {
            OrganizationParticipant op = new LDAPOrganizationParticipant();
            return op;
        }

        public override RoleParticipant CreateRoleParticipant()
        {
            RoleParticipant rp = new LDAPRoleParticipant();
            return rp;
        }

        public override HumanParticipant CreateHumanParticipant()
        {
            HumanParticipant hp = new LDAPHumanParticipant();
            return hp;
        }
    }

    /// <summary>
    /// The 'Concrete Factory' class.
    /// </summary>
    public class LocalDBParticipantFactory : ParticipantFactory
    {
        public override OrganizationParticipant CreateOrganizationParticipant()
        {
            OrganizationParticipant op = new LocalDBOrganizationParticipant();
            return op;
        }

        public override RoleParticipant CreateRoleParticipant()
        {
            RoleParticipant rp = new LocalDBRoleParticipant();
            return rp;
        }

        public override HumanParticipant CreateHumanParticipant()
        {
            HumanParticipant hp = new LocalDBHumanParticipant();
            return hp;
        }
    }
}
