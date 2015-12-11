using hsdc.dpt.Control.Behavioral.TemplateMethod.Singleton;
using hsdc.dpt.Control.DTO.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.TemplateMethod.InsurancePolicy
{
    public abstract class AbstractPolicyChangeTemplate
    {
        public List<PolicyTransaction> GetTransactionList()
        {
            List<PolicyTransaction> trans = new List<PolicyTransaction>();
            trans.Add(new PolicyTransaction() {CanEdit = true, Policies = new List<Policy>()});
            trans.Add(new PolicyTransaction() {CanEdit = false, Policies = new List<Policy>()});
            foreach(var p in Db.Instance.GetPolicies()) 
                trans.Where(t => t.CanEdit == CanEdit(p)).SingleOrDefault().Policies.Add(p);
            return trans;
        }

        protected abstract bool CanEdit(Policy p);
    }

    public class PolicyLoanTransction : AbstractPolicyChangeTemplate
    {

        protected override bool CanEdit(Policy p)
        {
            return p.PolicyType == PolicyType.Normal;
        }
    }

    public class ChangeInsuredNameTransaction : AbstractPolicyChangeTemplate
    {

        protected override bool CanEdit(Policy p)
        {
            return p.PolicyType != PolicyType.HasClaimed;
        }
    }

    public class ChangeInsuredNameTransaction2 : AbstractPolicyChangeTemplate
    {

        protected override bool CanEdit(Policy p)
        {
            return p.PolicyType != PolicyType.InAprrove;
        }
    }
}
