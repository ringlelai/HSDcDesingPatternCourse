using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Behavioral.TemplateMethod
{
    public class PolicyTransaction
    {
        public bool CanEdit { get; set; }
        public List<Policy> Policies { get; set; }
    }
    public class Policy
    {
        public string PolicyNumber { get; set; }
        public string PolicyName { get; set; }
        public string PolicyOwnerName { get; set; }
        public string PolicyInsuredName { get; set; }
        public PolicyType PolicyType { get; set; }
    }

    public enum PolicyType
    {
        [DescriptionAttribute("正常")]
        Normal,
        [DescriptionAttribute("審核中")]
        InAprrove,
        [DescriptionAttribute("已理賠")]
        HasClaimed
    }
}
