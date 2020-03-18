using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Visitor.ConcreteElement
{
    //concrete employee
    public class Director : Employee
    {
        // Constructor
        public Director() : base("Elly", 35000.0, 16)
        {
        }
    }
}
