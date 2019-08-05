using System;
using System.Collections.Generic;
using System.Text;
using Creational.AbstractFactory.Logic.AbstractProducts;
using Creational.AbstractFactory.Logic.Products;

namespace Creational.AbstractFactory.Logic
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildbeest();
        }
    }
}
