using Behavioral.Strategy.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Context
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            this._list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            // Iterate over list and display results
            foreach (string name in _list)
                Console.WriteLine(" " + name);

            Console.WriteLine();
        }
    }
}
