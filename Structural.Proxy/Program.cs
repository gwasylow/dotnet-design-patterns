﻿using Structural.Proxy.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
    /**
     *  Proxy (MathProxy):
     *      - maintains a reference that lets the proxy access the 
     *      real subject. Proxy may refer to a Subject if the 
     *      RealSubject and Subject interfaces are the same.
     *      - provides an interface identical to Subject's so that 
     *      a proxy can be substituted for for the real subject.
     *      - controls access to the real subject and may be 
     *      responsible for creating and deleting it.
     *      other responsibilites depend on the kind of proxy:
     *          - remote proxies are responsible for encoding a request and 
     *              its arguments and for sending the encoded request to the 
     *          - real subject in a different address space.
     *          - virtual proxies may cache additional information about 
     *              the real subject so that they can postpone accessing it. 
     *              For example, the ImageProxy from the Motivation caches 
     *              the real images's extent.
     *          - protection proxies check that the caller has the access 
     *              permissions required to perform a request.
     *    
     *  Subject (IMath):
     *      defines the common interface for RealSubject and Proxy so 
     *      that a Proxy can be used anywhere a RealSubject is expected.
     *
     *  RealSubject (Math):
     *      defines the real object that the proxy represents.
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Create math proxy
            MathProxy proxy = new MathProxy();

            //Do the math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            //Wait for user
            Console.ReadKey();
        }
    }
}
