using Structural.Adapter.Adapter;
using Structural.Adapter.Target;
using System;

namespace Structural.Adapter
{
    class Program
    {
        /**
         *  ADAPTER:
         *  Definition: Convert the interface of a class into another interface clients expect. 
         *  Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
         *  
         *  Participants:
         *      
         *      Target   (ChemicalCompound) 
         *      defines the domain-specific interface that Client uses.
         *      
         *      Adapter   (Compound)
         *      adapts the interface Adaptee to the Target interface.
         *      
         *      Adaptee   (ChemicalDatabank)
         *      defines an existing interface that needs adapting.
         *      
         *      Client   (AdapterApp)
         *      collaborates with objects conforming to the Target interface.
         */
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compund
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ehtanol = new RichCompound("Ethanol");
            ehtanol.Display();

            Console.ReadKey();
        }
    }
}
