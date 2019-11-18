using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command.Receiver
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Calculator
    {
        private int _currentOperation = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _currentOperation += operand; break;
                case '-': _currentOperation -= operand; break;
                case '*': _currentOperation *= operand; break;
                case '/': _currentOperation /= operand; break;
            }

            Console.WriteLine("Current value = {0,3} (following {1} {2})", _currentOperation, @operator, operand);
        }
    }
}
