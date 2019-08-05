using Creational.AbstractFactory.Logic.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Logic.Products
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            // Eat Bison
            Console.WriteLine($"{this.GetType().Name} eats {herbivore.GetType().Name}\n");
        }
    }
}
