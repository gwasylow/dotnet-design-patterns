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
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Piaggio Vespa 50LC");
        }

        public override void BuildDoors()
        {
            vehicle[BuidlerKeys.DOORS] = "0";
        }

        public override void BuildEngine()
        {
            vehicle[BuidlerKeys.ENGINE] = "Piaggio 50cc";
        }

        public override void BuildFrame()
        {
            vehicle[BuidlerKeys.FRAME] = "Vespa Frame";
        }

        public override void BuildWheels()
        {
            vehicle[BuidlerKeys.WHEELS] = "2";
        }
    }
}
