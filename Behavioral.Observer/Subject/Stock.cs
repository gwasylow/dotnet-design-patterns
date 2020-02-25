using Behavioral.Observer.ObserverInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Observer.Subject
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Stock
    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        // Constructor
        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        // Gets the symbol
        public string Symbol
        {
            get { return _symbol; }
        }

        // Gets or sets the price
        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public void Subscribe(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Unsubscribe(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        private void Notify()
        {
            foreach (IInvestor investor in _investors)
                investor.Update(this);

            Console.WriteLine("");
        }
    }
}
