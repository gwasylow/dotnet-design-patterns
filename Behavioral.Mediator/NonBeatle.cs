using Behavioral.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class NonBeatle : Participant

    {
        // Constructor
        public NonBeatle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
