using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatServer
{
    static class UserDB
    {
        static List<User> userDB = new List<User>();

        static List<User> loggedInUsers = new List<User>();
        
        public static List<User> GetLoggedInUsers()
        {
            return loggedInUsers;
        }

        public static bool LogUserInSystem(User user)
        {
            try
            {
                loggedInUsers.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddUser(User user)
        {
            try
            {
                userDB.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static User GetUserByUsername(string username)
        {
            return userDB.Where(u => u.username.Equals(username)).FirstOrDefault();
        }
    }
}
