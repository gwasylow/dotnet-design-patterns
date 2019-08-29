using Structural.Adapter.Adaptee;
using Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Adapter.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        public RichCompound(string chemicalName)
            : base(chemicalName)
        {

        }

        public override void Display()
        {
            //The Adaptee
            _bank = new ChemicalDatabank();

            _bolingPoint = _bank.GetCriticalPoint(_chemicalName, ChemicalPoints.BOLING_POINT);
            _meltingPoint = _bank.GetCriticalPoint(_chemicalName, ChemicalPoints.MELTING_POINT);
            _molecularWeight = _bank.GetMolecularWeight(_chemicalName);
            _molercuralFormula = _bank.GetMolecularStructure(_chemicalName);

            base.Display();
            Console.WriteLine($"\tFormula: {_molercuralFormula}");
            Console.WriteLine($"\tWeight: {_molecularWeight}");
            Console.WriteLine($"\tMelting Point: {_bolingPoint}");
            Console.WriteLine($"\tBoiling Point: {_meltingPoint}");
        }

    }
}
