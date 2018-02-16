namespace Messaging
{
    public class MessageService<T> : INotificationService<T> where T : Message
    {
        public void SendBulkMessage(string[] recipients, string sender, string message)
        {
            foreach(var recipient in recipients) {
                System.Console.WriteLine($"Sending Message: {message}, From: {sender}, To: {recipient} ");
            }
        }

        public void SendBulkMessage(T[] msgs)
        {
            foreach(var msg in msgs) {
                System.Console.WriteLine($"Sending Message: {msg.MessageContent}, From: {msg.Sender}, To: {msg.Recipient} ");
            }
        }

        public void SendSingleMessage(string recipient, string message, string sender)
        { 
            System.Console.WriteLine($"Sending Message: {message}, From: {sender}, To: {recipient} ");
        }

        public void SendSingleMessage(T msg)
        {
                System.Console.WriteLine($"Sending Message: {msg.MessageContent}, From: {msg.Sender}, To: {msg.Recipient} ");
            
        }
    }
}