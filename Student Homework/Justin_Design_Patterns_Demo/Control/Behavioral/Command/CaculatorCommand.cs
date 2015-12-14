using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Command.Caculator
{
    public class CalculationInvoker
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;
        public void Compute(object receiver, string @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new ElementaryArithCommand(
              receiver, @operator, operand);
            command.Execute();
            commands.Add(command);
            current++;
        }
        public void Undo(int levels)
        {
            for(int i =0;i< levels;i++)
            {
                if(current>0)
                {
                    Command command = commands[--current] as Command;
                    command.UnExecute();
                }
            }
        }
    }

    public abstract class Command
    {
        protected string Operator;
        protected int Operand;
        public abstract void Execute();
        public abstract void UnExecute();
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
        public override void UnExecute()
        {
            if (this._caculator != null)
                this._caculator.Operation(Undo(Operator), Operand);
        }

        private string Undo(string @operator)
        {
            switch (@operator)
            {
                case "+":
                    @operator = "-";
                    break;
                case "-":
                    @operator = "+";
                    break;
                case "*":
                    @operator = "/";
                    break;
                case "/":
                    @operator = "*";
                    break;
            }
            return @operator;
        }
    }

    public abstract class ICaculator
    {
        public abstract int GetResult();
        public abstract void Operation(string @operator, int operand);
    }


    [Serializable]
    public class ElementaryArithCaculator:ICaculator
    {
        private int _curr = 0;

        public override void Operation(string @operator, int operand)
        {
            //http://www.dofactory.com/net/command-design-pattern
            switch (@operator)
            {
                case "+":
                    _curr += operand;
                    break;
                case "-":
                    _curr -= operand;
                    break;
                case "*":
                    _curr *= operand;
                    break;
                case "/":
                    _curr /= operand;
                    break;
            }

        }

        public override int GetResult()
        {
            return _curr;
        }
    }
}
