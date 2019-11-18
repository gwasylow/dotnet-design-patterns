using Behavioral.Command.Command;
using Behavioral.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command.Invoker
{
    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    class User
    {
        // Initializers
        private Calculator _calculator = new Calculator();
        private List<Behavioral.Command.AbstractCommand.Command> _commandsRepository = new List<AbstractCommand.Command>();
        private int _currentLevel = 0;

        public void Redo(int level)
        {
            Console.WriteLine("\n---- Redo {0} levels ", level);

            // Perform redo operations
            for (int i = 0; i < level; i++)
            {
                if (_currentLevel < _commandsRepository.Count - 1)
                {
                    Behavioral.Command.AbstractCommand.Command command = _commandsRepository[_currentLevel++];
                    command.Execute();
                }
            }
        }

        public void Undo(int level)
        {
            Console.WriteLine("\n---- Undo {0} levels ", level);

            // Perform undo operations
            for (int i = 0; i < level; i++)
            {
                if (_currentLevel > 0)
                {
                    Behavioral.Command.AbstractCommand.Command command = _commandsRepository[--_currentLevel] as Behavioral.Command.AbstractCommand.Command;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Behavioral.Command.AbstractCommand.Command command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            _commandsRepository.Add(command);
            _currentLevel++;
        }
    }
}
