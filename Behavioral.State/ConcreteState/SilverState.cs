using Behavioral.State.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.State.ConcreteState
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Silver indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    class SilverState : State.State
    {
        // Overloaded constructors
        public SilverState(State.State state) : this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
        {
            base.balance = balance;
            base.account = account;

            Initialize();
        }

        private void Initialize()
        {
            // Should come from a 
            base.interest = 0.0;
            base.lowerLimit = 0.0;
            base.upperLimit = 1000.0;
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
            if (base.balance < base.lowerLimit)
                base.account.State = new RedState(this);
            else if (base.balance > upperLimit)
                base.account.State = new GoldState(this);
        }

    }
}
