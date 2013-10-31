using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatServer
{
    class User
    {
        public string username{ get; set; }
        public string password { get; set; }
        public string callBackURL { get; set; }
        public bool hasPermissionToChat {get; set; }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.hasPermissionToChat = false;
            this.callBackURL = string.Empty;
        }
    }
}
