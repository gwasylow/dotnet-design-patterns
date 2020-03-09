using Behavioral.TemplateMethod.AbstractDAO;
using Behavioral.TemplateMethod.DAO;
using System;

namespace Behavioral.TemplateMethod
{
    /**
     *  AbstractClass  (DataObject)
     *      - defines abstract primitive operations that concrete 
     *          subclasses define to implement steps of an algorithm
     *      - implements a template method defining the skeleton 
     *          of an algorithm. The template method calls primitive 
     *          operations as well as operations defined in AbstractClass 
     *          or those of other objects.
     *      
     *  ConcreteClass  (CustomerDataObject)
     *      - implements the primitive operations ot carry out 
     *          subclass-specific steps of the algorithm
     */
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}
