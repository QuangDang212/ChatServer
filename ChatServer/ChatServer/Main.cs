using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ChatServer
{
    class MainProcess
    {
        static void Main(string[] args)
        {
            //testing if github works
            //testing if github works
            var baseAddress = new Uri("http://localhost:1337/ChatServer");
            var host = new ServiceHost(typeof(ChatServer), baseAddress);

            host.Open();

            Console.WriteLine("Service is running....press any key to terminate.");
            Console.ReadKey();
        }
    }
}
