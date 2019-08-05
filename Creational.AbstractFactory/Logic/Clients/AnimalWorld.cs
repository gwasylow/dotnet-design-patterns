using Creational.AbstractFactory.Logic.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Logic.Clients
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continentFactory)
        {
            _carnivore = continentFactory.CreateCarnivore();
            _herbivore = continentFactory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            Console.Write("Run food chain >> ");
            _carnivore.Eat(_herbivore);
        }
    }
}
