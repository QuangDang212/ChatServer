using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatClient
{
    
    class ChatClient : IChatClient
    {
        
        public void SendMessage(string user, string msg)
        {
            //if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(msg))
            //{
            //    Console.WriteLine("User {0} says: {1}", user, msg);
            //}
        }
    }
}
