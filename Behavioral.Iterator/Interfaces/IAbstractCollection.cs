using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Behavioral.Iterator.ConcreteIterator;

namespace Behavioral.Iterator.Interfaces
{
    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    public interface IAbstractCollection
    {
        ConcreteIterator.Iterator CreateIterator();
    }
}
