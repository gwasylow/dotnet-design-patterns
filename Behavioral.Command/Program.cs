using Behavioral.Command.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    /**
     *  Command Pattern - Encapsulate a request as an object, thereby letting you 
     *  parameterize clients with different requests, queue or log requests, 
     *  and support undoable operations.
     *  
     *  Command  (Command):
     *      declares an interface for executing an operation
     *
     *  ConcreteCommand  (CalculatorCommand)
     *      defines a binding between a Receiver object and an action implements 
     *      Execute by invoking the corresponding operation(s) on Receiver
     *      
     *  Client  (CommandApp)
     *      creates a ConcreteCommand object and sets its receiver
     *
     *  Invoker  (User)
     *      asks the command to carry out the request
     *
     *  Receiver  (Calculator)
     *      knows how to perform the operations associated 
     *      with carrying out the request.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Create user and let her compute
            User user = new User();

            // Let users press calc buttons and perform operations
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}
