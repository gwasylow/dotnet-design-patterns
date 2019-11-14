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
    class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
            else if (base.successor != null)
                base.successor.ProcessRequest(purchase);
        }
    }
}
