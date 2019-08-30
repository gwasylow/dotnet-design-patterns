using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    class RefinedAbstraction : Abstraction.Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
