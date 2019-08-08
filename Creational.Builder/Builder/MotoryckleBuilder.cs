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
    public class MotoryckleBuilder : VehicleBuilder
    {
        public MotoryckleBuilder()
        {
            vehicle = new Vehicle("Kawasaki ER5");
        }

        public override void BuildDoors()
        {
            vehicle[BuidlerKeys.DOORS] = "0";
        }

        public override void BuildEngine()
        {
            vehicle[BuidlerKeys.ENGINE] = "Kawasaki Engine 650ccm";
        }

        public override void BuildFrame()
        {
            vehicle[BuidlerKeys.FRAME] = "Kawasaki Frame";
        }

        public override void BuildWheels()
        {
            vehicle[BuidlerKeys.WHEELS] = "2";
        }
    }
}
