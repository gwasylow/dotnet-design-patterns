using Creational.AbstractFactory.Logic.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Logic
{
    /*
     *  This real-world code demonstrates the creation of different 
     *  animal worlds for a computer game using different factories. 
     *  
     *  Although the animals created by the Continent factories are 
     *  different, the interactions among the animals remain the same.
     */
    public abstract class ContinentFactory        
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
