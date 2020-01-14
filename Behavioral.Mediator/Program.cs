using Behavioral.Mediator.Abstract;
using Behavioral.Mediator.Mediator;
using System;

namespace Behavioral.Mediator
{
    /**
     *  Mediator Design Pattern
     * 
     *  Mediator  (IChatroom)
     *      - defines an interface for communicating with Colleague objects
     * 
     *  ConcreteMediator  (Chatroom)
     *      - implements cooperative behavior by coordinating Colleague objects
     *      - knows and maintains its colleagues
     * 
     *  Colleague classes  (Participant)
     *      - each Colleague class knows its Mediator object
     *      - each colleague communicates with its mediator whenever it would 
     *          have otherwise communicated with another colleague
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Create chatroom (concrete Mediator)
            Chatroom chatroom = new Chatroom();

            //Create Participants and register them
            Participant greg = new Beatle("Greg");
            Participant john = new Beatle("John");
            Participant anna = new Beatle("Anna");
            Participant doe = new Beatle("Doe");
            Participant charlie = new Beatle("Charlie");
            Participant fuzz = new NonBeatle("Fuzz");

            //register
            chatroom.Register(greg);
            chatroom.Register(john);
            chatroom.Register(anna);
            chatroom.Register(doe);
            chatroom.Register(charlie);
            chatroom.Register(fuzz);

            //Chatting participants
            greg.Send("John", "Hi John!");
            john.Send("Anna", "Hi Anna!");
            anna.Send("Doe", "How are you Doe?");
            doe.Send("Charlie", "Howdy Charlie?");
            charlie.Send("Fuzz", "Hiya Fuzz!!");

            Console.ReadKey();
        }
    }
}
