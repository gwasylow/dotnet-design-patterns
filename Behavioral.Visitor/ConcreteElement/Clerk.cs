using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Visitor.ConcreteElement
{
    //Concrete Employee
    public class Clerk : Employee
    {
        // Constructor
        public Clerk() : base("Hank", 25000.0, 14)
        {
        }
    }
}
