using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structrural.Decorator.AbstractComponent
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class LibraryItem
    {
        private int _numberOfCopies;

        public int NumberOfCopies
        {
            get { return _numberOfCopies; }
            set { _numberOfCopies = value; }
        }

        public abstract void Display();
    }
}
