using System;

namespace ChatClient
{
    
    class ChatClient : IChatClient
    {

        public void ReceiveMessage(string user, string message)
        {
            Console.WriteLine("({0}) >>> {1}", user, message);
        }
    }
}
