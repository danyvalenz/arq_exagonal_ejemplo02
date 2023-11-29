namespace Notifications.Services
{
    public abstract class NotificationHandlerBase
    {
        public virtual void HandlerMessage(string message)
        {
            Console.WriteLine($"{this.GetType()} ==> {message}");
        }
    }
}
