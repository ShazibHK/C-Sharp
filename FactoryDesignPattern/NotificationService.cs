using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
	public class NotificationService
	{
		public static void Main(String[] args)
		{
			NotificationFactory notificationFactory = new NotificationFactory();
			Notification notification = notificationFactory.createNotification("SMS");
			notification.notifyUser();
		}
	}

}
