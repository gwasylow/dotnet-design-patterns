using Behavioral.Strategy.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.ConcreteStrategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}
