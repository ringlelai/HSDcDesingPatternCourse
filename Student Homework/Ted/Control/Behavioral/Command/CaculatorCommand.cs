using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Command.Caculator
{
    [Serializable]
    public class CalculationInvoker
    {
        private List<Command> commands = new List<Command>();
        private Stack<int> results = new Stack<int>();

        public void Compute(Calculator receiver, string @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new ElementaryArithCommand(
              receiver, @operator, operand);
            command.Execute();
            commands.Add(command);
            results.Push(receiver.GetResult());
        }
        public void Undo(Calculator receiver)
        {
            if (results.Count > 0)
              results.Pop();
            if (results.Count > 0)
                receiver.SetCurr(results.Peek());
            else
                receiver.SetCurr(0);
        }
    }

    public abstract class Command
    {
        protected string Operator;
        protected int Operand;
        public abstract void Execute();
        public Command(object receiver, string Operator, int Operand) 
        {
            this.Operator = Operator;
            this.Operand = Operand;
        }
    }

    public class ElementaryArithCommand : Command
    {
        private ElementaryArithCaculator _caculator;
        public ElementaryArithCommand(object receiver, string Operator, int Operand)
            : base(receiver, Operator, Operand)
        {
            if (receiver.GetType() == typeof(ElementaryArithCaculator))
                this._caculator = (ElementaryArithCaculator)receiver;
        }
        public override void Execute()
        {
            if (this._caculator != null)
                this._caculator.Operation(Operator, Operand);
        }
    }

    [Serializable]
    public abstract class Calculator
    {
        protected int _curr = 0;

        public void SetCurr(int input)
        {
            _curr = input;
        }

        public int GetResult()
        {
            return _curr;
        }
    }


    public class ElementaryArithCaculator : Calculator
    {
        

        public void Operation(string @operator, int operand)
        {
            switch (@operator)
            {
                case "+": _curr += operand; break;
                case "-": _curr -= operand; break;
                case "*": _curr *= operand; break;
                case "/": _curr /= operand; break;
            }
        }
    }
}
