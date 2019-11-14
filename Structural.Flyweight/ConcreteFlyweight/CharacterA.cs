using Structural.Flyweight.AbstractFlyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight.ConcreteFlyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class CharacterA : Character
    {
        public CharacterA()
        {
            base.symbol = 'A';
            base.height = 100;
            base.width = 120;
            base.ascent = 70;
            base.descent = 0;
        }

        //DRY - if the 
        public override void Display(int pointSize)
        {
            base.pointSize = pointSize;
            Console.WriteLine(base.symbol + " (pointsize " + base.pointSize + ")");
        }
    }
}
