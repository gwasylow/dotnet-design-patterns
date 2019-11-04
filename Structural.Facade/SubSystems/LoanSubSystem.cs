using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.SubSystems
{
    class LoanSubSystem
    {
        public bool HasNoBadLoans(Customer cust)
        {
            Console.WriteLine($">> Checking for bad loans sub system for: {cust.Name}");
            return true;
        }
    }
}
