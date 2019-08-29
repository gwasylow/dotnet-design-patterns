using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Adapter.Target
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Compound
    {
        protected string _chemicalName;
        protected float _bolingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molercuralFormula;

        public Compound(string chemicalName)
        {
            this._chemicalName = chemicalName;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nCompound: {_chemicalName} >>");
        }
    }
}
