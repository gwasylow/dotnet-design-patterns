using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Visitor.ConcreteElement
{
    //Concrete employee
    public class President : Employee
    {
        // Constructor
        public President() : base("Dick", 45000.0, 21)
        {
        }
    }
}
