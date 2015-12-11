using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    //薪資計算
    public abstract class PayCalc<T>
    {
        protected abstract PayCalcRule<T> CreatePayCalcRule();
        //protected abstract void BusinessRuleCheck(ref List<T> obj);
        public void CalcPayRoll(ref List<PayRoll>rolllist,T item)
        {
            PayCalcRule<T> rull = CreatePayCalcRule();
            rull.Calc(ref rolllist, item);
        }
    }

    //薪資計算規則
    public abstract class PayCalcRule<T>
    {
        public abstract void Calc(ref List<PayRoll> rolllist, T item);
    }

    //計算加項規則
    public class AddPayCalc : PayCalc<PayItem>
    {
        protected override PayCalcRule<PayItem> CreatePayCalcRule()
        {
            return new AddPayCalcRule();
        }
    }

    //計算加項規則
    public class AddPayCalcRule : PayCalcRule<PayItem>
    {
        public override void Calc(ref List<PayRoll> rolllist, PayItem item)
        {
            PayRoll roll = new PayRoll();
            roll.PayItemIditity = item.PayItemIditity;
            roll.PayItemName = item.PayItemName;
            roll.PayRollAmt = +(item.value);
            rolllist.Add(roll);       
        }
    }


    //計算減項規則
    public class MinusPayCalc : PayCalc<PayItem>
    {
        protected override PayCalcRule<PayItem> CreatePayCalcRule()
        {
            return new MinusPayCalcRule();
        }
    }

    //計算減項規則
    public class MinusPayCalcRule : PayCalcRule<PayItem>
    {
        public override void Calc(ref List<PayRoll> rolllist, PayItem item)
        {
            PayRoll roll = new PayRoll();
            roll.PayItemIditity = item.PayItemIditity;
            roll.PayItemName = item.PayItemName;
            roll.PayRollAmt = -(item.value);
            rolllist.Add(roll);
        }
    }

    //計算勞保項規則
    public class LaborPayCalc : PayCalc<PayItem>
    {
        protected override PayCalcRule<PayItem> CreatePayCalcRule()
        {
            return new LaborPayCalcRule();
        }
    }

    //計算勞保項規則
    public class LaborPayCalcRule : PayCalcRule<PayItem>
    {
        public override void Calc(ref List<PayRoll> rolllist, PayItem item)
        {
            PayRoll roll = new PayRoll();
            roll.PayItemIditity = item.PayItemIditity;
            roll.PayItemName = item.PayItemName;
            PayRoll calcbase = rolllist.Where(a => a.PayItemIditity == "001").AsQueryable().FirstOrDefault<PayRoll>();
            roll.PayRollAmt = -(calcbase.PayRollAmt * item.value);
            rolllist.Add(roll);
        }
    }

    //計算健保項規則
    public class NHIPayCalc : PayCalc<PayItem>
    {
        protected override PayCalcRule<PayItem> CreatePayCalcRule()
        {
            return new NHIPayCalcRule();
        }
    }

    //計算健保項規則
    public class NHIPayCalcRule : PayCalcRule<PayItem>
    {
        public override void Calc(ref List<PayRoll> rolllist, PayItem item)
        {
            PayRoll roll = new PayRoll();
            roll.PayItemIditity = item.PayItemIditity;
            roll.PayItemName = item.PayItemName;
            PayRoll calcbase = rolllist.Where(a => a.PayItemIditity == "001").AsQueryable().FirstOrDefault<PayRoll>();
            roll.PayRollAmt = -(calcbase.PayRollAmt * item.value);
            rolllist.Add(roll);
        }
    }

    //計算勞退自提項規則
    public class PensionPayCalc : PayCalc<PayItem>
    {
        protected override PayCalcRule<PayItem> CreatePayCalcRule()
        {
            return new PensionPayCalcRule();
        }
    }

    //計算勞退自提項規則
    public class PensionPayCalcRule : PayCalcRule<PayItem>
    {
        public override void Calc(ref List<PayRoll> rolllist, PayItem item)
        {
            PayRoll roll = new PayRoll();
            roll.PayItemIditity = item.PayItemIditity;
            roll.PayItemName = item.PayItemName;
            PayRoll calcbase = rolllist.Where(a => a.PayItemIditity == "001").AsQueryable().FirstOrDefault<PayRoll>();
            roll.PayRollAmt = -(calcbase.PayRollAmt * item.value);
            rolllist.Add(roll);
        }
    }

    //計算勞退自提項規則
    public class TotalPayCalc : PayCalc<PayItem>
    {
        protected override PayCalcRule<PayItem> CreatePayCalcRule()
        {
            return new TotalPayCalcRule();
        }
    }

    //計算勞退自提項規則
    public class TotalPayCalcRule : PayCalcRule<PayItem>
    {
        public override void Calc(ref List<PayRoll> rolllist, PayItem item)
        {
            PayRoll roll = new PayRoll();
            roll.PayItemIditity = item.PayItemIditity;
            roll.PayItemName = item.PayItemName;
            foreach(var r in rolllist)
            {
                roll.PayRollAmt += r.PayRollAmt;
            }

            rolllist.Add(roll);
        }
    }


}
