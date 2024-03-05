using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Latysh_OOP
{
    class Calc
    {
        ArithUnit arithUnit;
        ControlUnit controlUnit;
        public Calc(ArithUnit unit, ControlUnit controlUnit)
        {
            this.arithUnit = unit;
            this.controlUnit = controlUnit;
        }
        private int Run(Command command) 
        {
            controlUnit.StoreComm(command);
            controlUnit.ExecuteComm();
            return arithUnit.Register;
        }
        public int Add(int operand) 
        {
            return Run(new Add(arithUnit, operand));
        }
        public int Sub(int operand)
        {
            return Run(new Sub(arithUnit, operand));
        }
        public int Mul(int operand)
        {
            return Run(new Mul(arithUnit, operand));
        }
        public int Div(int operand) 
        {
            return Run(new Div(arithUnit, operand));
        }
        public int Undo(int levels)
        {
            controlUnit.Undo(levels);
            return arithUnit.Register;
        }
        public int Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithUnit.Register;
        }
    }
}
