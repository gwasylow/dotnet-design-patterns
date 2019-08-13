using Creational.Prototype.Prototype;
using Creational.Prototype.PrototypeManager;
using System;

namespace Creational.Prototype
{
    /*
     *  PROTOTYPE: Specify the kind of objects to create using a 
     *      prototypical instance, and create new objects by 
     *      copying this prototype.
     * 
     *  Participants:
     *  Prototype  (ColorPrototype)
     *      declares an interface for cloning itself
     *      
     *  ConcretePrototype  (Color)
     *      implements an operation for cloning itself
     *  
     *  Client  (ColorManager)
     *      creates a new object by asking a prototype 
     *      to clone itself
     */
    class Program
    {
        private static ColorManager _colorManager = new ColorManager();

        static void Main(string[] args)
        {
            // Initialize with standard colors
            _colorManager["red"] = new Color(255, 0, 0);
            _colorManager["green"] = new Color(0, 255, 0);
            _colorManager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            _colorManager["angry"] = new Color(255, 54, 0);
            _colorManager["peace"] = new Color(128, 211, 128);
            _colorManager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color clonedColor1 = _colorManager["red"].Clone() as Color;
            Color clonedColor2 = _colorManager["peace"].Clone() as Color;
            Color clonedColor3 = _colorManager["flame"].Clone() as Color;
            

            Console.ReadKey();
        }
    }
}
