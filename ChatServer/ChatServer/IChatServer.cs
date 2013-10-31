using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ChatServer
{
    [ServiceContract]
    interface IChatServer
    {
        [OperationContract]
        string LogIn(string callBackUrl, string user, string password);

        [OperationContract]
        string SendMessage(string token, string message);

        [OperationContract]
        string LogOut(string token);

    }
}
