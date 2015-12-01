using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    //public class PayStructure
    //{
    //    public List<PayItem> PayItemList{get;set;}
    //}

    public class PayItem
    {
        public string PayItemIditity { get; set; }
        public string PayItemName { get; set; }
        public Double value { get; set; }
        public string PayRuleIditity { get; set; }
    }

    public class PayRule
    {
        public string PayRuleIditity { get; set;}
        public string PayRuleName { get; set; }
        public string PayRuleMethod { get; set; }
    }

    public class PayRoll
    {
        public string PayItemIditity { get; set; }
        public string PayItemName { get; set; }
        public Double PayRollAmt { get; set; }
    }
}
