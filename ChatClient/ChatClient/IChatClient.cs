using System.ServiceModel;

namespace ChatClient
{
    [ServiceContract]
    interface IChatClient
    {
        [OperationContract]
        ReceiveMessageResponse ReceiveMessage(string user, string msg);
    }
}
