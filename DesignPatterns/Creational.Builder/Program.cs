using Creational.Builder.AbstractBuilder;
using Creational.Builder.Builder;
using Creational.Builder.Director;
using System;

namespace Creational.Builder
{
    /**
     * Builder - Separates object construction from its representation
     *      Separate the construction of a complex object from its 
     *      representation so that the same construction process can 
     *      create different representations.
     * 
     * 
     * Builder  (VehicleBuilder)
     *      specifies an abstract interface for creating parts of a Product object
     *
     * ConcreteBuilder  (MotorCycleBuilder, CarBuilder, ScooterBuilder)
     *      constructs and assembles parts of the product by implementing the Builder interface
     *      defines and keeps track of the representation it creates
     *      provides an interface for retrieving the product
     *      
     * Director  (VehicleDealer)
     *      constructs an object using the Builder interface
     *
     * Product  (Vehicle)
     *      represents the complex object under construction. ConcreteBuilder 
     *      builds the product's internal representation and defines the process 
     *      by which it's assembled includes classes that define the constituent 
     *      parts, including interfaces for assembling the parts into the final result
     */
    class Program
    {
        private static VehicleBuilder _builder;

        static void Main(string[] args)
        {
            var vehicleDealer = new VehicleDealer();

            //Construct and display vehicles
            _builder = new CarBuilder();
            vehicleDealer.Construct(_builder);
            _builder.Vehicle.Show();

            _builder = new MotoryckleBuilder();
            vehicleDealer.Construct(_builder);
            _builder.Vehicle.Show();

            _builder = new ScooterBuilder();
            vehicleDealer.Construct(_builder);
            _builder.Vehicle.Show();

            Console.ReadLine();
        }
    }
}
