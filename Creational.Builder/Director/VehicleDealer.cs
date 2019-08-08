using Creational.Builder.AbstractBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Director
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class VehicleDealer
    {
        // Builder uses a complex series of steps
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildWheels();
        }
    }
}
