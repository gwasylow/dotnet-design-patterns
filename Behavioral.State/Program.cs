using Behavioral.State.Context;
using System;

namespace Behavioral.State
{
    class Program
    {
        /**
         *  Participants:
         *  
         *  Context  (Account)
         *      - defines the interface of interest to clients
         *      - maintains an instance of a ConcreteState subclass that defines the current state.
         * 
         *  State  (State)
         *      - defines an interface for encapsulating the behavior associated with a particular state of the Context.
         * 
         *  Concrete State  (RedState, SilverState, GoldState)
         *      - each subclass implements a behavior associated with a state of Context
         */
        static void Main(string[] args)
        {
            //State entry point
            Account account = new Account("Greg W");

            //Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            Console.ReadLine();
        }
    }
}
