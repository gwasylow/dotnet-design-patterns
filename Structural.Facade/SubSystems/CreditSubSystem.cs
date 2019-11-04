using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.SubSystems
{
    class CreditSubSystem
    {
        public bool HasGoodCredit(Customer cust)
        {
            Console.WriteLine($">> Check for credit sub system on: {cust.Name}");
            return true;
        }
    }
}
