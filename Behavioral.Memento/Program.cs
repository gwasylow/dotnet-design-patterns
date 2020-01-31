﻿using Behavioral.Memento.Caretaker;
using Behavioral.Memento.Originator;
using System;

namespace Behavioral.Memento
{

    /**
     *  Memento  (Memento)
     *      - stores internal state of the Originator object. The memento 
     *      may store as much or as little of the originator's internal 
     *      state as necessary at its originator's discretion.
     *      - protect against access by objects of other than the originator. 
     *      Mementos have effectively two interfaces. Caretaker sees a narrow 
     *      interface to the Memento -- it can only pass the memento to the 
     *      other objects. Originator, in contrast, sees a wide interface, one 
     *      that lets it access all the data necessary to restore itself to its 
     *      previous state. Ideally, only the originator that produces the 
     *      memento would be permitted to access the memento's internal state.
     *      
     *
     *  Originator  (SalesProspect)
     *      - creates a memento containing a snapshot of its current internal state.
     *      - uses the memento to restore its internal state
     *
     * 
     *  Caretaker  (Caretaker)
     *      - is responsible for the memento's safekeeping
     *      - never operates on or examines the contents of a memento.     
     */
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            SalesProspect salesProspect = new SalesProspect();
            salesProspect.Name = "SANTA CLAUS";
            salesProspect.Phone = "0 111 222 333";
            salesProspect.Budget = 25000.0;

            // Store internal state
            ProspectMemory prospectMemory = new ProspectMemory();
            prospectMemory.Memento = salesProspect.SaveMemento();

            // Continue changing originator
            salesProspect.Name = "SILVESTER STALONE";
            salesProspect.Phone = "0 333 444 555";
            salesProspect.Budget = 1000000.0;

            // Restore saved state
            salesProspect.RestoreMemento(prospectMemory.Memento);

            Console.ReadLine();
        }
    }
}
