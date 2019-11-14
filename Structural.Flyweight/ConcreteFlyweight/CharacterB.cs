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
    class CharacterB : Character
    {
        public CharacterB()
        {
            base.symbol = 'B';
            base.height = 100;
            base.width = 140;
            base.ascent = 72;
            base.descent = 0;
        }

        public override void Display(int pointSize)
        {
            base.pointSize = pointSize;
            Console.WriteLine(base.symbol + " (pointsize " + base.pointSize + ")");
        }

    }
}
