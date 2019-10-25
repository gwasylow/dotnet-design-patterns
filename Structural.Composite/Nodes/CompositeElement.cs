using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.Nodes
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> _elements = new List<DrawingElement>();

        // Constructor

        public CompositeElement(string name)
          : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            _elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            _elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + _name);

            // Display each child element on this node
            foreach (DrawingElement elem in _elements)
            {
                elem.Display(indent + 2);
            }
        }
    }
}
