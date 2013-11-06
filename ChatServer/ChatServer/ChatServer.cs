using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ChatServer
{
    class ChatServer : IChatServer
    {
        public ChatServer()
        {
            UserDB.AddUser(new User("u1", "p1"));
            UserDB.AddUser(new User("u2", "p2"));
            UserDB.AddUser(new User("u3", "p3"));
        }

        public bool LogIn(string callBackUrl, string username, string password)
        {
            var userToLogin = UserDB.GetUserByUsername(username);

            if (userToLogin != null && userToLogin.Password.Equals(password))
            {
                userToLogin.CallBackUrl = callBackUrl;
                userToLogin.HasPermissionToChat = true;
                UserDB.LogUserInSystem(userToLogin);

                return true;
            }
            return false;
        }

        public string SendMessage(string sender, string message)
        {
            var broadcastThread = new Thread(() =>
                {
                    using (var broadcast = new BroadcastService())
                    {
                        broadcast.SendMessageToEveryone(sender, message);
                    }
                }
            );

            broadcastThread.Start();

            return "Mesnsagem Enviada!";
        }

        public string LogOut(string token)
        {
            return "LogOut efectuado com sucesso!";
        }
    }
}
