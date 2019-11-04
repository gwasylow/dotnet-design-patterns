using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.SubSystems
{
    class BankSubSystem
    {
        public bool HasSufficientSavings(Customer cust, int amount)
        {
            Console.WriteLine($">> Check bank account sub system for: {cust.Name}");
            return true;
        }
    }
}
