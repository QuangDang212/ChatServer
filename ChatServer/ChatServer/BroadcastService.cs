using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            Dispose();
        }
    }
}
