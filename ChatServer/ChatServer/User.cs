using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatServer
{
    class User
    {
        public string Username{ get; set; }
        public string Password { get; set; }
        public string CallBackUrl { get; set; }
        public bool HasPermissionToChat {get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.HasPermissionToChat = false;
            this.CallBackUrl = string.Empty;
        }
    }
}
