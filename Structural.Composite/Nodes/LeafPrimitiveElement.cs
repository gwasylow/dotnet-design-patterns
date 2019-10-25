using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.Nodes
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class LeafPrimitiveElement : DrawingElement
    {
        public LeafPrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement element)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _name);
        }

        public override void Remove(DrawingElement element)
        {
            Console.WriteLine("Cannot remove the PrimitiveElement");
        }
    }
}
