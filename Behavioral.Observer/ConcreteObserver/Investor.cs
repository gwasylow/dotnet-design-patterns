using Behavioral.Observer.ObserverInterfaces;
using Behavioral.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Observer.ConcreteObserver
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public class Investor : IInvestor
    {
        private string _name;

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {this._name} of {stock.Symbol}'s change to {stock.Price:C}.");
        }
    }
}
