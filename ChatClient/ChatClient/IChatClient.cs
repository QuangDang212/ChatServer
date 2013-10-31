using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ChatClient
{
    [ServiceContract]
    interface IChatClient
    {
        [OperationContract]
        void SendMessage(string use, string msg);
    }
}
