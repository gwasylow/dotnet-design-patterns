using Structural.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge.ConcreteImplementor
{
    class ConcreteImplementatorBook : AbstractImplementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementator <<BOOK>> Operation()");
        }
    }
}
