using Creational.FactoryMethod.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.AbstractCreators
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public List<Page> Pages
        {
            get { return this._pages; }
        }

        public Document()
        {
            this.CreatePages();
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
