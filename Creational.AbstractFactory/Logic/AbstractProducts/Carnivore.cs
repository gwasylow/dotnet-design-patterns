using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Logic.AbstractProducts
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// PL: MIESOZERCY
    /// </summary>
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }
}
