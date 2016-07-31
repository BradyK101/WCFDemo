using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCF_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for hosting service
            //or to start service
            ServiceHost host = new ServiceHost(typeof(service));
            host.Open();
            Console.WriteLine("Sevice started...");
            Console.ReadKey();
        }
    }
}
