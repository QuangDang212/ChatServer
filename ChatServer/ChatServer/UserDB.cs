using System.Collections.Generic;
using System.Linq;

namespace ChatServer
{
    internal static class UserDB
    {
        static readonly List<User> UserDb = new List<User>();

        static readonly List<User> LoggedInUsers = new List<User>();
        
        public static List<User> GetLoggedInUsers()
        {
            return LoggedInUsers;
        }

        public static bool LogUserInSystem(User user)
        {
            try
            {
                LoggedInUsers.Add(user);
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
                UserDb.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static User GetUserByUsername(string username)
        {
            return UserDb.FirstOrDefault(u => u.Username.Equals(username));
        }
    }
}
