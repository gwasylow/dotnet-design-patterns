using Behavioral.Strategy.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.ConcreteStrategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}
