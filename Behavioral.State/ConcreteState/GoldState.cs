using Behavioral.State.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.State.ConcreteState
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    class GoldState : State.State

    {
        // Overloaded constructors

        public GoldState(State.State state) : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
        {
            base.balance = balance;
            base.account = account;

            Initialize();
        }

        private void Initialize()
        {
            // Should come from a database
            base.interest = 0.05;
            base.lowerLimit = 1000.0;
            base.upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            base.balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            base.balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            base.balance += interest * balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (base.balance < 0.0)
                account.State = new RedState(this);
            else if (base.balance < base.lowerLimit)
                account.State = new SilverState(this);
        }
    }
}
