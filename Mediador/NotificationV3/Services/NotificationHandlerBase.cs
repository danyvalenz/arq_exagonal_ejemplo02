namespace NotificationV3.Services
{
    public abstract class NotificationHandlerBase
    {
        public virtual void HandlerMessage(string message)
        {
            Console.WriteLine($"{GetType()} ==> {message}");
        }

    }
}
