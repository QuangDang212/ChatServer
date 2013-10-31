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

        public string LogIn(string callBackUrl, string username, string password)
        {
            User userToLogin = UserDB.GetUserByUsername(username);

            if (userToLogin != null && userToLogin.password.Equals(password))
            {
                userToLogin.callBackURL = callBackUrl;
                userToLogin.hasPermissionToChat = true;
                UserDB.LogUserInSystem(userToLogin);

                return "Login Efectuado com sucesso!";
            }

            return "Login Falhou!";
        }

        public string SendMessage(string sender, string message)
        {
            Thread broadcastThread = new Thread(() =>
                {
                    using (BroadcastService broadcast = new BroadcastService())
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
