using System;

namespace Creational.Singleton
{
    /**
     * SINGLETON PATTERN:
     *    Ensure a class has only one instance and provide a global point of access to it.
     * 
     *  Participants:
     *      -> Singleton   (LoadBalancer)
     *      defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
     *      responsible for creating and maintaining its own unique instance.
     */
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer lb1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb4 = LoadBalancer.GetLoadBalancer();

            // Check is the same instance?
            if (lb1 == lb2 && lb2 == lb3 && lb3 == lb4)
                Console.WriteLine("Same instance\n");

            //Load balance for 15 requests
            LoadBalancer loadBalancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Dispatching request #{i} to: {loadBalancer.NextServer.Name} with ip: {loadBalancer.NextServer.IP}");
            }

            Console.ReadKey();
        }
    }
}
