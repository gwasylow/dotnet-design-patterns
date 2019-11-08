using Structural.Flyweight.AbstractFlyweight;
using Structural.Flyweight.ConcreteFlyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class CharacterFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character = null;

            if (_characters.ContainsKey(key))
                character = _characters[key];
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    //C...Y
                    case 'Z': character = new CharacterZ(); break;
                }

                _characters.Add(key, character);
            }

            return character;
        }
    }
}
