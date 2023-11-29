namespace Notification_mediator.Services
{
    public abstract class NotificationHandlerBase
    {
        public virtual void HandlerMessage(string message)
        {
            Console.WriteLine($"{GetType()} ==> {message}");
        }
    }
}
