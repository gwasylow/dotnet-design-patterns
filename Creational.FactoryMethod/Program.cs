using Creational.FactoryMethod.AbstractCreators;
using Creational.FactoryMethod.AbstractProducts;
using Creational.FactoryMethod.Creators;
using System;

namespace Creational.FactoryMethod
{
    /**
     *  Factory Method: Define an interface for creating 
     *      an object, but let subclasses decide which class 
     *      to instantiate. Factory Method lets a class 
     *      defer instantiation to subclasses.
     *  
     *  
     *  Participants:
     *      
     *  Product  (Page)
     *      defines the interface of objects the factory method creates.
     *      
     *  ConcreteProduct  (SkillsPage, EducationPage, ExperiencePage)
     *      implements the Product interface.
     *      
     *  Creator  (Document)
     *      declares the factory method, which returns an object of type
     *      Product. Creator may also define a default implementation of
     *      the factory method that returns a default ConcreteProduct object.
     *      May call the factory method to create a Product object.
     *      
     *  ConcreteCreator  (Report, Resume)
     *      overrides the factory method to return an instance of 
     *      a ConcreteProduct.         
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method
            Document[] documentsRepository = new Document[2];
            documentsRepository[0] = new Report();
            documentsRepository[1] = new Admin();

            //Display document pages
            foreach (Document doc in documentsRepository)
            {
                Console.WriteLine($"\n {doc.GetType().Name} -->");

                foreach (Page page in doc.Pages)
                    Console.WriteLine($"\t>> {page.GetType().Name}");
            }

            Console.ReadKey();
        }
    }
}
