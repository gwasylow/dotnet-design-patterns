using Creational.AbstractFactory.Logic.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Logic.Products
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            // Eat Wildebeest
            Console.WriteLine($"{this.GetType().Name} eats {herbivore.GetType().Name}\n");
        }
    }
}
