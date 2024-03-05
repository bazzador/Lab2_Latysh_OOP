using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Latysh_OOP
{
    class ArithUnit
    {
        public int Register {  get; private set; }
        public void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}
