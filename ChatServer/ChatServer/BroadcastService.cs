using System;
using System.Collections.Generic;

namespace ChatServer
{
    class BroadcastService : IDisposable
    {
        internal bool SendMessageToEveryone(string sender, string message)
        {
            try
            {
                List<User> loggedUsers = UserDB.GetLoggedInUsers();

                foreach (User user in loggedUsers)
                {
                    if (!user.Username.Equals(sender))
                    {
                        var client = new ChatClientReference.ChatClientClient();
                        client.Endpoint.Address = new System.ServiceModel.EndpointAddress(user.CallBackUrl);
                        client.ReceiveMessage(sender, message);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
                return false;
            }
        }

        public void Dispose()
        {

        }
    }
}
