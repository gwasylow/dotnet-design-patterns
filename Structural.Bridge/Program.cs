using System;
using Structural.Bridge.ConcreteImplementor;

namespace Structural.Bridge
{
    /**
         *  Bridge: Separates an object’s interface from its implementation.
         *          
         *          Decouple an abstraction from its implementation 
         *          so that the two can vary independently.
         *          
         *  Abstraction   (BusinessObject)
         *      defines the abstraction's interface.
         *      maintains a reference to an object of type Implementor.
         *      
         *  RefinedAbstraction   (CustomersBusinessObject)
         *      extends the interface defined by Abstraction.
         *
         *  Implementor   (DataObject)
         *      defines the interface for implementation classes. This interface doesn't have 
         *      to correspond exactly to Abstraction's interface; in fact the two interfaces 
         *      can be quite different. Typically the Implementation interface provides only 
         *      primitive operations, and Abstraction defines higher-level operations based 
         *      on these primitives.
         *      
         *  ConcreteImplementor   (CustomersDataObject)
         *      implements the Implementor interface and defines its concrete implementation.
         */
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction.Abstraction abs = new RefinedAbstraction.RefinedAbstraction();

            // Set implementation and call
            abs.Implementator = new ConcreteImplementatorBook();
            abs.Operation();

            //Change implementation call
            abs.Implementator = new ConcreteImplementatorCar();
            abs.Operation();

            //Change implementation call
            abs.Implementator = new ConcreteImplementatorPlane();
            abs.Operation();

            Console.ReadKey();
        }
    }
}
