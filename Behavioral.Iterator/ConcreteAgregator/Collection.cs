using Behavioral.Iterator.ConcreteIterator;
using Behavioral.Iterator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator.ConcreteAgregator
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    public class Collection : IAbstractCollection

    {
        private ArrayList _items = new ArrayList();

        public ConcreteIterator.Iterator CreateIterator()
        {
            return new ConcreteIterator.Iterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
