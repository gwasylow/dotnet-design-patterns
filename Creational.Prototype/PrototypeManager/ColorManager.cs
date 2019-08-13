using Creational.Prototype.AbstractPrototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype.PrototypeManager
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
