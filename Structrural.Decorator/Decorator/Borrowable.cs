using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structrural.Decorator.AbstractComponent;
using Structrural.Decorator.AbstractDecorator;

namespace Structrural.Decorator.Decorator
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Borrowable : AbstractDecorator.AbstractDecorator
    {
        protected List<string> _borrowers = new List<string>();

        //Constructor
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            base._libraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            base._libraryItem.NumberOfCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in _borrowers)
            {
                Console.WriteLine($" borrower: {borrower}");
            }
        }
    }
}
