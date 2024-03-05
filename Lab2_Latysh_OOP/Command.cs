using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Latysh_OOP
{
    abstract class Command
    {
        protected ArithUnit unit;
        protected int operand;
        public abstract void Execute();
        public abstract void UnExecute();
    }
    class Add : Command
    {
        public Add(ArithUnit unit, int operand)
        {
            this.unit = unit;   
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('+', operand);
        }
        public override void UnExecute()
        {
            unit.Run('-', operand);
        }
    }
    class Sub : Command
    {
        public Sub(ArithUnit unit, int operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            unit.Run('-', operand);
        }

        public override void UnExecute()
        {
            unit.Run('+', operand);
        }
    }
    class Div : Command
    {
        public Div(ArithUnit unit, int operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            unit.Run('/', operand);
        }

        public override void UnExecute()
        {
            unit.Run('*', operand);
        }
    }
    class Mul : Command
    {
        public Mul(ArithUnit unit, int operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('*', operand);
        }

        public override void UnExecute()
        {
            unit.Run('/', operand);
        }
    }
}
