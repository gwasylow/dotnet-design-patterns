using Behavioral.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Observer.ConcreteSubject
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
