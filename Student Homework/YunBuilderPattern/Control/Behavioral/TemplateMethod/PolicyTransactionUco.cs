using hsdc.dpt.Control.Behavioral.TemplateMethod.InsurancePolicy;
using hsdc.dpt.Control.DTO.Behavioral.TemplateMethod;
using hsdc.dpt.Control.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.TemplateMethod
{
    public class PolicyTransactionUco
    {
        public List<PolicyTransaction> GetTransactionList(string className)
        {
            AbstractPolicyChangeTemplate policyChange = ObjectCreator<AbstractPolicyChangeTemplate>.CreateObject(className);
            return policyChange.GetTransactionList();
        }
    }
}
