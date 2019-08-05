using System;
using System.Collections.Generic;
using System.Text;
using Creational.AbstractFactory.Logic.AbstractProducts;
using Creational.AbstractFactory.Logic.Products;

namespace Creational.AbstractFactory.Logic
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
