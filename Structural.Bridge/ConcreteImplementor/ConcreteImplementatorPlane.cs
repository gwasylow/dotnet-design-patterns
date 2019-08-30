using Structural.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge.ConcreteImplementor
{
    class ConcreteImplementatorPlane : AbstractImplementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementator <<PLANE>> Operation()");
        }
    }
}
