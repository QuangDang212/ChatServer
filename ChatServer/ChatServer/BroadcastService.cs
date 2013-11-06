using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatServer.ChatClientReference;

namespace ChatServer
{
    class BroadcastService : IDisposable
    {
        internal bool SendMessageToEveryone(string sender, string message)
        {
            try
            {
                List<User> loggedUsers = UserDB.GetLoggedInUsers();
                loggedUsers.Remove(UserDB.GetUserByUsername(sender));

                foreach (User user in loggedUsers)
                {
                    //ChatClientNotificationClient c = new ServiceReference1.ChatClientNotificationClient();

                    //// para alterar o endpoint que o proxy ira usar
                    //c.Endpoint.Address = new System.ServiceModel.EndpointAddress(user.url);

                    //c.notifySendMessage(_user, _message);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {

        }
    }
}
