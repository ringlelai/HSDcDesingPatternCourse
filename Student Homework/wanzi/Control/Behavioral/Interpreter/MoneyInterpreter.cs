using hsdc.dpt.Control.DTO.Behavioral.Interpreter;
using hsdc.dpt.Control.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Interpreter.Money
{
    public class MoneyController
    {
        public void TransferToChinese(ref MoneyContext context, MoneyExpression prior = null)
        {
            if (context.GetNumIntList().Count == 0)
                return;
            MoneyExpression expression = new NumericExpression((NumericExpression)prior);
            expression.Interpret(context);
            context.GetNumIntList().RemoveFirst();
            if (context.GetNumIntList().Count > 0)
            {
                this.TransferToChinese(ref context, expression);
            }
        }
    }
    public class MoneyContext
    {
        private LinkedList<String> _ChineseChars = new LinkedList<string>();
        private LinkedList<int> _NumInts = new LinkedList<int>();

        public MoneyContext(long Number)
        {
            foreach (var s in Number.ToString().ToCharArray())
                _NumInts.AddLast(Int32.Parse(s.ToString()));
        }
        public String ToChinese()
        {
            string chineseNum = "";
            foreach(var cchar in _ChineseChars.Reverse()) {
                chineseNum += cchar;
            }
            if (chineseNum.Last().ToString() == EnumUtils.stringValueOf(ChineseNumber.Zero))
                chineseNum = chineseNum.Substring(0, chineseNum.Length - 1);
            return chineseNum;
        }

        
        public LinkedList<String> GetChineseCharList()
        {
            return this._ChineseChars;
        }

        public LinkedList<int> GetNumIntList()
        {
            return this._NumInts;
        }
    }

    public abstract class MoneyExpression
    {
        public abstract void Interpret(MoneyContext context);
        public virtual int ChildrenCount()
        {
            return 0;
        }
    }

    public class NumericExpression : MoneyExpression
    {
        private NumberExpression number;
        private UnitExpression unit;
        private NumericExpression prior = null;
        public NumericExpression(NumericExpression prior)
        {
            this.prior = prior;
            number = new NumberExpression(prior == null ? null : prior.GetNE());
            unit = new UnitExpression(number);
        }
        public override void Interpret(MoneyContext context)
        {
            number.Interpret(context);
            unit.Interpret(context);
        }
        public NumberExpression GetNE()
        {
            return this.number;
        }
        public UnitExpression GetUE()
        {
            return this.unit;
        }
    }

    public class NumberExpression : MoneyExpression
    {
        private NumberExpression prior;
        private ChineseNumber Cn { get; set; }
        public NumberExpression(NumberExpression prior)
        {
            this.prior = prior;
        }
        public override void Interpret(MoneyContext context)
        {
            int value = context.GetNumIntList().First();
            Cn = (ChineseNumber)value;
            if ((prior != null) && (prior.IsZero()) && (prior.Cn == Cn))
                return;
            context.GetChineseCharList().AddFirst(EnumUtils.stringValueOf(Cn));
            return;
        }
        public bool IsZero()
        {

            return Cn == ChineseNumber.Zero;
        }
    }

    public class UnitExpression : MoneyExpression
    {
        private NumberExpression currentNumber;
        private ChineseUnit Cu { get; set; }
        public UnitExpression(NumberExpression currentNumber)
        {
            this.currentNumber = currentNumber;
        }
        public override void Interpret(MoneyContext context)
        {
            int unit = context.GetNumIntList().Count - 1;
            if (unit == 0)
                return;
            else if (unit % 4 > 0)
                unit = unit % 4;
            Cu = (ChineseUnit)unit;
            if ((currentNumber != null) && (currentNumber.IsZero()))
            {
                if (this.LessThan4())
                    return;
                else if (this.GreatThan3())
                {
                    try
                    {
                        ChineseUnit preCu = (ChineseUnit)EnumUtils.enumValueOf(context.GetChineseCharList().First(), typeof(ChineseUnit));
                        if ((((int)preCu) > 3) && (this.GreatThan3()))
                            return;
                    }
                    catch { }
                    context.GetChineseCharList().RemoveFirst();
                }
            }
            try
            {
                ChineseUnit preCu = (ChineseUnit)EnumUtils.enumValueOf(context.GetChineseCharList().First(), typeof(ChineseUnit));
                if ((((int)preCu) > 3) && (this.GreatThan3()))
                    return;
            }
            catch { }
            context.GetChineseCharList().AddFirst(EnumUtils.stringValueOf(Cu));
        }

        public bool LessThan4()
        {
            return ((int)Cu) < 4;
        }

        public bool GreatThan3()
        {
            return ((int)Cu) > 3;
        }
    }

    public class ChineseNumUtils
    {
        public static bool TryGetNumber(String s, out int value)
        {
            value = -1;
            try
            {
                ChineseNumber n = (ChineseNumber)EnumUtils.enumValueOf(s, typeof(ChineseNumber));
                value = (int)n;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool TryGetUnit(String s, out int value)
        {
            value = -1;
            try
            {
                ChineseUnit u = (ChineseUnit)EnumUtils.enumValueOf(s, typeof(ChineseUnit));
                value = (int)u;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
