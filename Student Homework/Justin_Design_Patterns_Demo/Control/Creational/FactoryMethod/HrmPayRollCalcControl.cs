using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            string methodNmae = "hsdc.dpt.Control.Creational.FactoryMethod.";
            foreach (var item in paystructure)
            {
                if (item.PayItemIditity == "001") calcbase = item.value;
                #region 改使用 Assembly.Load("Control").CreateInstance
                //switch (item.PayRuleIditity)
                //{
                //    case "C001":
                //        //rule = new AddPayCalc();
                //        rule = (PayCalc<PayItem>)Assembly.Load("Control").CreateInstance("hsdc.dpt.Control.Creational.FactoryMethod.AddPayCalc");
                //        break;
                //    case "C002":
                //        rule = new MinusPayCalc();
                //        break;
                //    case "C003":
                //        rule = new LaborPayCalc();
                //        break;
                //    case "C004":
                //        rule = new NHIPayCalc();
                //        break;
                //    case "C005":
                //        rule = new PensionPayCalc();
                //        break;
                //    case "C006":
                //        rule = new TotalPayCalc();
                //        break;
                //}
                #endregion
                rule = (PayCalc<PayItem>)Assembly.Load("Control").CreateInstance(methodNmae + item.PayRuleIditity);
                if (rule != null)
                {
                    rule.CalcPayRoll(ref payrolllist, item);
                }
            }
            return payrolllist;
        }




        public List<PayItem> GetPayStructure()
        {
            var paystructure = new List<PayItem>();
            paystructure.Add(new PayItem { PayItemIditity = "001", PayItemName = "本薪", value = 30000, PayRuleIditity = "AddPayCalc" });
            paystructure.Add(new PayItem { PayItemIditity = "002", PayItemName = "伙食津貼", value = 1500, PayRuleIditity = "AddPayCalc" });
            paystructure.Add(new PayItem { PayItemIditity = "003", PayItemName = "勞保", value = 0.023, PayRuleIditity = "LaborPayCalc" });
            paystructure.Add(new PayItem { PayItemIditity = "004", PayItemName = "健保", value = 0.005, PayRuleIditity = "NHIPayCalc" });
            paystructure.Add(new PayItem { PayItemIditity = "005", PayItemName = "勞退", value = 0.06, PayRuleIditity = "PensionPayCalc" });
            paystructure.Add(new PayItem { PayItemIditity = "006", PayItemName = "應付薪資", value = 0, PayRuleIditity = "TotalPayCalc" });

            return paystructure;
        }


    }
}
