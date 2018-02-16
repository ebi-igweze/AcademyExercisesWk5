namespace Messaging
{
    public interface INotificationService<T> where T: Message
    {
        void SendSingleMessage(string recipient, string sender, string message);
        void SendBulkMessage(string[] recipients, string sender, string message);
        void  SendSingleMessage(T msg);
        void SendBulkMessage(T[] msg);
    }

}