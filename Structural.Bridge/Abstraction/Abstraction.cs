using System;
using System.Collections.Generic;
using System.Text;
using Structural.Bridge.Implementor;

namespace Structural.Bridge.Abstraction
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    class Abstraction
    {
        protected AbstractImplementor implementor;

        //Property
        public AbstractImplementor Implementator
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
