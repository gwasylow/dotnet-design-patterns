using Structrural.Decorator.AbstractComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structrural.Decorator.AbstractDecorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class AbstractDecorator : LibraryItem
    {
        protected LibraryItem _libraryItem;

        public AbstractDecorator(LibraryItem libraryItem)
        {
            this._libraryItem = libraryItem;
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}
