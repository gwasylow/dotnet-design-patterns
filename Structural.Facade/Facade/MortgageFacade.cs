using Structural.Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.Facade
{
    class MortgageFacade
    {
        private BankSubSystem _bank = new BankSubSystem();
        private LoanSubSystem _loan = new LoanSubSystem();
        private CreditSubSystem _credit = new CreditSubSystem();

        public bool IsEligible(Customer cust, int amount)
        {
            bool isEligble = true;
            Console.WriteLine($"{cust.Name} applies for {amount:C} loan:\n");

            // Check creditworthyness of applicant
            if (_bank.HasSufficientSavings(cust, amount) == false)
                isEligble = false;
            else if (_loan.HasNoBadLoans(cust) == false)
                isEligble = false;
            else if (_credit.HasGoodCredit(cust) == false)
                isEligble = false;

            return isEligble;
        }
    }
}
