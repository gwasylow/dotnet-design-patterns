using Behavioral.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command.Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    class CalculatorCommand : Behavioral.Command.AbstractCommand.Command
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this._operator = @operator;
            this._operand = operand;
            this._calculator = calculator;
        }

        //Gets operator
        public char Operator
        {
            set { _operator = value; }
        }

        //Get operand
        public int Operand
        {
            set { _operand = value; }
        }

        //Execute new command
        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        //Unexecute last command
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        //Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }

    }
}
