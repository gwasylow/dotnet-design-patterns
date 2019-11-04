using Structural.Facade.Facade;
using Structural.Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    /**
     *  Provide a unified interface to a set of interfaces in a subsystem. 
     *  Façade defines a higher-level interface that makes the subsystem easier to use.
     *  
     *  Facade   (MortgageApplication)
     *      knows which subsystem classes are responsible for a request.
     *      delegates client requests to appropriate subsystem objects.
     * 
     *  Subsystem classes   (Bank, Credit, Loan)
     *      implement subsystem functionality.
     *      handle work assigned by the Facade object.
     *      have no knowledge of the facade and keep no reference to it.
     */
    class Program
    {
        static void Main(string[] args)
        {
            MortgageFacade mortgage = new MortgageFacade();

            // Evaluate mortgage eligibility for customer
            var cust = new Customer("Ann McKinsey");
            bool eligable = mortgage.IsEligible(cust, 125000);

            //Display notification info
            Console.WriteLine($"\n{ cust.Name} has been {(eligable ? "Approved" : "Rejected")} for a mortgage.");

            Console.ReadKey();
        }
    }
}
