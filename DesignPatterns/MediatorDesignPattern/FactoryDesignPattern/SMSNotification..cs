using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
	public class SMSNotification : Notification
	{
		public void notifyUser()
		{
			Console.Write("Sending an SMS notification");
		}

	}

}
