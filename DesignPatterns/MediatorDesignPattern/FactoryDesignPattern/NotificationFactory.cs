using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
     class NotificationFactory
    {
		public Notification createNotification(String channel)
			{
				if (channel == null || string.IsNullOrEmpty(channel))
					return null;
				if (string.Equals("SMS",channel))
				{
					return new SMSNotification();
				}
				else if (string.Equals("EMAIL", channel))
				{
					return new EmailNotification();
				}
				else if (string.Equals("PUSH", channel))
				{
					return new PushNotification();
				}
				return null;
			}
		}
	}

