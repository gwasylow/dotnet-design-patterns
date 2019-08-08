using Creational.Builder.AbstractBuilder;
using Creational.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("BMW Car");
        }
        public override void BuildDoors()
        {
            vehicle[BuidlerKeys.DOORS] = "4";
        }

        public override void BuildEngine()
        {
            vehicle[BuidlerKeys.ENGINE] = "BMW 2000cc Diesel";
        }

        public override void BuildFrame()
        {
            vehicle[BuidlerKeys.FRAME] = "BMW Frame";
        }

        public override void BuildWheels()
        {
            vehicle[BuidlerKeys.WHEELS] = "4";
        }
    }
}
