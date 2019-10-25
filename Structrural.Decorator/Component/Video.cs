using Structrural.Decorator.AbstractComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structrural.Decorator.Component
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class Video : LibraryItem

    {
        private string _director;
        private string _title;
        private int _playTime;

        // Constructor
        public Video(string director, string title, int numberOfCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumberOfCopies = numberOfCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", base.NumberOfCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}
