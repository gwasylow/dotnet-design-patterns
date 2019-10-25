using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.Nodes
{
    /// <summary>
    /// Tree Node
    /// </summary>
    public abstract class DrawingElement
    {
        protected string _name;

        public DrawingElement(string name)
        {
            this._name = name;
        }

        public abstract void Add(DrawingElement element);
        public abstract void Remove(DrawingElement element);
        public abstract void Display(int indent);
    }
}
