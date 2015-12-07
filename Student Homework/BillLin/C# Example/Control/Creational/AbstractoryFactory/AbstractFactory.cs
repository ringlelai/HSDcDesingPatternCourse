using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.AbstractoryFactory
{
    /// <summary>
    /// The 'Abstract Factory' class
    /// 參與者抽象工廠
    /// </summary>
    public abstract class ParticipantFactory
    {
        public abstract OrganizationParticipant CreateOrganizationParticipant();
        public abstract RoleParticipant CreateRoleParticipant();
        public abstract HumanParticipant CreateHumanParticipant();
    }
}
