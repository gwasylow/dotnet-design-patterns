using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype.AbstractPrototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
