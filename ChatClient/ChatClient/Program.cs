using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = "";
            // Perguntar ao utilizador qual o endereco deste cliente para as notificacoes
            //Console.WriteLine("Introduza um identificador para o URL das notificacoes");
            string url = "c1"; //Console.ReadLine();
            end = "http://localhost:1099/ChatClient/" + url;
            Console.WriteLine("URL = {0}", end);

            // Arrancar o servidor para receber notificacoes no cliente
            Uri baseAddress = new Uri(end);
            ServiceHost host = new ServiceHost(typeof(ChatClient), baseAddress);
            host.Open();

            Console.WriteLine("Prima qq tecla para inicar a aplicacao cliente");
            Console.ReadKey();

        }
    }
}
