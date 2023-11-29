﻿namespace NotificationV3.Services
{
    public class EmailNotificationHandler : NotificationHandlerBase
    {

        public override void HandlerMessage(string message)
        {
            message = message.Trim() + "EmailNotification";
            base.HandlerMessage(message);
        }
    }
}
