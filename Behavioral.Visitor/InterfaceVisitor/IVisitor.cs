using Behavioral.Visitor.AbstractElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Visitor.InterfaceVisitor
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
