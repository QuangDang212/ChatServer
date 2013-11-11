using System.ServiceModel;

namespace ChatServer
{
    [ServiceContract]
    interface IChatServer
    {
        [OperationContract]
        LoginResponse LogIn(string callBackUrl, string user, string password);

        [OperationContract]
        SendMessageResponse SendMessage(string token, string message);

        [OperationContract]
        LogoutResponse LogOut(string userToLogOut);

    }
}
