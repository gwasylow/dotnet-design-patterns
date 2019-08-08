using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Product
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        private string _vehicleType;
        private Dictionary<BuidlerKeys, string> _parts = new Dictionary<BuidlerKeys, string>();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        // Indexer
        public string this[BuidlerKeys key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine($" #Wheels: {_parts[BuidlerKeys.WHEELS]}");
            Console.WriteLine($" #Doors: {_parts[BuidlerKeys.DOORS]}");
            Console.WriteLine($" Frame: {_parts[BuidlerKeys.FRAME]}");
            Console.WriteLine($" Engine: {_parts[BuidlerKeys.ENGINE]}");
        }
    }
}
