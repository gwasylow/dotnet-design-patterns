using Creational.AbstractFactory.Logic;
using Creational.AbstractFactory.Logic.Clients;
using System;

namespace Creational.AbstractFactory
{
    class Program
    {
        /***********************************************************
        * Creational - Abstract Factory
        * Creates an instance of several families of classes
        ************************************************************
        * 
        * Definition:  Provide an interface for creating families 
        *              of related or dependent objects without 
        *              specifying their concrete classes.        
        ************************************************************              
        *              
        * Participants:
        * The classes and objects participating in this pattern are:
        * 
        * AbstractFactory  (ContinentFactory)
        * declares an interface for operations that create abstract products
        * 
        * ConcreteFactory   (AfricaFactory, AmericaFactory)
        * implements the operations to create concrete product objects
        * 
        * AbstractProduct   (Herbivore, Carnivore)
        * declares an interface for a type of product object
        * 
        * Product  (Wildebeest, Lion, Bison, Wolf)
        * defines a product object to be created by the corresponding concrete factory
        * implements the AbstractProduct interface
        * 
        * Client  (AnimalWorld)
        * uses interfaces declared by AbstractFactory and AbstractProduct classes             
        ***********************************************************/
        static void Main(string[] args)
        {
            //Create and run African animal world!
            var africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            //Create and run American animal world!
            var america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadLine();
        }
    }
}
