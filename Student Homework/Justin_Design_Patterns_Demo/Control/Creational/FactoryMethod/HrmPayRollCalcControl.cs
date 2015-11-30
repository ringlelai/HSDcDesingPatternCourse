using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    public class HrmPayRollCalcControl
    {

        public List<PayRoll> CalcPayRoll()
        {
            var payrolllist = new List<PayRoll>();
            var paystructure = GetPayStructure();
            PayCalc<PayItem> rule = null;
            Double calcbase = 0;
            foreach (var item in paystructure)
            {
                if (item.PayItemIditity == "001") calcbase = item.value;
                switch (item.PayRuleIditity)
                {
                    case "C001":
                        rule = new AddPayCalc();
                        break;
                    case "C002":
                        rule = new MinusPayCalc();
                        break;
                    case "C003":
                        rule = new LaborPayCalc();
                        break;
                    case "C004":
                        rule = new NHIPayCalc();
                        break;
                    case "C005":
                        rule = new PensionPayCalc();
                        break;
                    case "C006":
                        rule = new TotalPayCalc();
                        break;
                }
                rule.CalcPayRoll(ref payrolllist, item);
            }
            return payrolllist;
        }




        public List<PayItem> GetPayStructure()
        {
            var paystructure = new List<PayItem>();
            paystructure.Add(new PayItem { PayItemIditity = "001", PayItemName = "本薪", value = 30000, PayRuleIditity = "C001" });
            paystructure.Add(new PayItem { PayItemIditity = "002", PayItemName = "伙食津貼", value = 1500, PayRuleIditity = "C001" });
            paystructure.Add(new PayItem { PayItemIditity = "003", PayItemName = "勞保", value = 0.01, PayRuleIditity = "C003" });
            paystructure.Add(new PayItem { PayItemIditity = "004", PayItemName = "健保", value = 0.01, PayRuleIditity = "C004" });
            paystructure.Add(new PayItem { PayItemIditity = "005", PayItemName = "勞退", value = 0.06, PayRuleIditity = "C005" });
            paystructure.Add(new PayItem { PayItemIditity = "006", PayItemName = "應付薪資", value = 0, PayRuleIditity = "C006" });

            return paystructure;
        }


    }
}
