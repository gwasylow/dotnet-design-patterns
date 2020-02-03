using Behavioral.Observer.ConcreteObserver;
using Behavioral.Observer.ConcreteSubject;
using System;

namespace Behavioral.Observer
{
    /**
     *  Observer - Define a one-to-many dependency between objects 
     *  so that when one object changes state, all its dependents 
     *  are notified and updated automatically.
     *  
     *  Subject  (Stock)
     *      - knows its observers. Any number of Observer objects may observe a subject
     *      - provides an interface for attaching and detaching Observer objects.
     * 
     *  ConcreteSubject  (IBM)
     *      - stores state of interest to ConcreteObserver
     *      - sends a notification to its observers when its state changes
     *
     *  Observer  (IInvestor)
     *      - defines an updating interface for objects that should be notified of changes in a subject.
     * 
     *  ConcreteObserver  (Investor)
     *      - maintains a reference to a ConcreteSubject object
     *      - stores state that should stay consistent with the subject's
     *      - implements the Observer updating interface to keep its state consistent with the subject's
     */

    class Program
    {
        static void Main(string[] args)
        {
            //Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Subscribe(new Investor("George Sorros"));
            ibm.Subscribe(new Investor("Bill Gates"));
            ibm.Subscribe(new Investor("Bruce Willis"));

            //Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            ibm.Price = 119.30;
            ibm.Price = 118.00;

            Console.ReadKey();
        }
    }
}
