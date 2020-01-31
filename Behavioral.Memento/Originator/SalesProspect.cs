using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Memento.Originator
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class SalesProspect
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Gets or sets name
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine($"Name: {_name}");
            }
        }

        // Gets or sets phone
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Console.WriteLine($"Phone: {_phone}");
            }
        }

        // Gets or sets budget
        public double Budget
        {
            get => _budget;
            set

            {
                _budget = value;
                Console.WriteLine($"Budget: {_budget}");
            }
        }

        // Stores memento
        public Memento.Memento SaveMemento()
        {
            Console.WriteLine("\nSaving mementro state --\n");
            return new Memento.Memento(_name, _phone, _budget);
        }

        // Restores memento
        public void RestoreMemento(Memento.Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");

            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }
}
