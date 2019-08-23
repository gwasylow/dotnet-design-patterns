using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class LoadBalancer
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly LoadBalancer _instance = new LoadBalancer();
        // Type-safe generic list of servers
        private List<Server> _servers = new List<Server>();
        private Random _random = new Random();

        //Property for simple and effective randomisation in Load Balancing
        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }

        //protected constructor
        protected LoadBalancer()
        {
            // Load list of available servers
            _servers = new List<Server>
                {
                 new Server{ Name = "ServerI", IP = "120.14.220.18" },
                 new Server{ Name = "ServerII", IP = "120.14.220.19" },
                 new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                 new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                 new Server{ Name = "ServerV", IP = "120.14.220.22" },
                };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }
    }
}
