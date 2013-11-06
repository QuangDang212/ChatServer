using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.ServiceModel;
using ChatClient.ChatServerReference;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string clienturl = new Random().Next(0, 1000).ToString(CultureInfo.InvariantCulture);

            const string baseCallBackUrl = "http://localhost:1099/ChatClient/";

            var completeCallBackUrl = baseCallBackUrl + clienturl;

            Console.WriteLine("URL = {0}", completeCallBackUrl);

            // Start Client Proxy
            var baseAddress = new Uri(baseCallBackUrl);
            var host = new ServiceHost(typeof(ChatClient), baseAddress);
            host.Open();

            Console.WriteLine("Prima qq tecla para inicar a aplicacao cliente");
            Console.ReadKey();

            var serverReference = new ChatServerClient();

            Console.WriteLine("Introduza o utilizador:");
            string user = Console.ReadLine();
            Console.WriteLine("Introduza a palavra passe:");
            string pass = Console.ReadLine();

            serverReference.Endpoint.Address = new System.ServiceModel.EndpointAddress("http://localhost:1337/ChatServer");

            if (serverReference.LogIn(completeCallBackUrl, user, pass))
            {
                Console.WriteLine("Introduze a menssagem a enviar ou 'exit' para abandonar...");

               var  message = Console.ReadLine();

                while (!string.IsNullOrEmpty(message) && !message.Equals("exit"))
                {

                    // Vamos enviar uma mensagem
                    serverReference.SendMessage("", message);

                    message = Console.ReadLine();

                }

                serverReference.LogOut("string");
            }

        }
    }
}
