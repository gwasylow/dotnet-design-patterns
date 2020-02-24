using Behavioral.Strategy.ConcreteStrategy;
using Behavioral.Strategy.Context;
using System;

namespace Behavioral.Strategy
{
    /**
     *  Strategy  (SortStrategy)
     *      - declares an interface common to all supported algorithms. 
     *      Context uses this interface to call the algorithm defined by a ConcreteStrategy
     *      
     *  ConcreteStrategy  (QuickSort, ShellSort, MergeSort)
     *      - implements the algorithm using the Strategy interface
     * 
     *  Context  (SortedList)
     *      - is configured with a ConcreteStrategy object
     *      - maintains a reference to a Strategy object
     *      - may define an interface that lets Strategy access its data.     
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Adam");
            studentRecords.Add("Sathya");
            studentRecords.Add("Greg");
            studentRecords.Add("Zenek");
            studentRecords.Add("Pawel");
            studentRecords.Add("Janek");            
            
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user
            Console.ReadKey();
        }
    }
}
