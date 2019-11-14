using Behavioral.ChainOfResponsibility.AbstractHandler;
using Behavioral.ChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility
{
    /**
     * Chain of Responsibility: Avoid coupling the sender of a request to 
     *      - its receiver by giving more than one object a chance to handle the request. 
     *      - Chain the receiving objects and pass the request along the chain until 
     *      an object handles it.
     * 
     *  Handler   (Approver):
     *      - defines an interface for handling the requests
     *      - (optional) implements the successor link
     * 
     *  ConcreteHandler   (Director, VicePresident, President):
     *      - handles requests it is responsible for
     *      - can access its successor
     *      - if the ConcreteHandler can handle the request, it does so; otherwise it 
     *      forwards the request to its successor
     *      
     *  Client   (ChainApp):
     *      - initiates the request to a ConcreteHandler object on the chain
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver john = new President();

            //Explain how the chain should be connected
            larry.SetSuccessor(sam);
            sam.SetSuccessor(john);

            //Generate and process purchase requests
            Purchase purchaseRequest = new Purchase(2034, 35.00, "Project X");
            larry.ProcessRequest(purchaseRequest);

            purchaseRequest = new Purchase(2035, 32590.10, "Project Y");
            larry.ProcessRequest(purchaseRequest);

            purchaseRequest = new Purchase(2036, 122100.00, "Project Z");
            larry.ProcessRequest(purchaseRequest);

            //Wait for user
            Console.ReadKey();
        }
    }
}
