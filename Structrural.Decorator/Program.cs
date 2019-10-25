using Structrural.Decorator.Component;
using Structrural.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structrural.Decorator
{
    class Program
    {
        /**
         * DECORATOR PATTERN: Attach additional responsibilities to an object dynamically. 
         *      Decorators provide a flexible alternative to subclassing for extending functionality.
         * 
         *  Component   (LibraryItem)
         *      defines the interface for objects that can 
         *      have responsibilities added to them dynamically.
         *      
         *  ConcreteComponent   (Book, Video)
         *      defines an object to which additional responsibilities can be attached.
         *
         *  Decorator   (Decorator)
         *      maintains a reference to a Component object and defines an interface 
         *      that conforms to Component's interface.
         *
         *  ConcreteDecorator   (Borrowable)
         *      adds responsibilities to the component.
         */
        static void Main(string[] args)
        {
            //Create a book
            Book book = new Book("Steve Henry", ".NET Core Proffessional", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "JURRASIC PARK", 30, 120);
            video.Display();

            //Make a video object borrowable, then borrown and display
            Console.WriteLine("Now make the video borrowable.");
            Borrowable borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Customer #1");
            borrowableVideo.BorrowItem("Customer #2");
            borrowableVideo.BorrowItem("Customer #3");
            borrowableVideo.BorrowItem("Customer #4");

            borrowableVideo.Display();


            Console.ReadKey();
        }
    }
}
