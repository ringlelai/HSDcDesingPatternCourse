using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Creational.AbstractFactory;

namespace hsdc.dpt.Control.Creational.AbstractoryFactory
{
    /// <summary>
    /// The root class of Participant.
    /// </summary>
    public abstract class Participant
    {
        public AssigneeType assignType { get; set; }        // 參與者類型
        public string aggignee_name { get; set; }           // 參與者名稱

        // 定義處理行為的介面
        public abstract string process();
    }

    /// <summary>
    /// The 'Abstract Product' class
    /// '組織參與者' 抽象產品
    /// </summary>
    public abstract class OrganizationParticipant : Participant {        
    }

    /// <summary>
    /// The 'Abstract Product' class
    /// '角色參與者' 抽象產品
    /// </summary>
    public abstract class RoleParticipant : Participant {
    }

    /// <summary>
    /// The 'Abstract Product' class
    /// '人參與者' 抽象產品
    /// </summary>
    public abstract class HumanParticipant : Participant {
    }
}
