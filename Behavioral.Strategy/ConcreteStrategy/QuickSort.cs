using Behavioral.Strategy.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.ConcreteStrategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
