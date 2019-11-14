using Behavioral.ChainOfResponsibility.AbstractHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility.Handler
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
            else
            {
                //End of a chain.
                Console.WriteLine("President says: Request# {0} requires an executive meeting!", purchase.Number);
            }
        }
    }
}
