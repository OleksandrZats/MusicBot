using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YTMProject.Models
{
	public class TempMessage
	{
		public string FirstName;

		public string Text;
		public TempMessage(long? chatId, string firstName, string text)
		{
			FirstName = firstName;
			Text = text;
		}

		public static void Refresh()
		{
			if (Resive.messagesText != null)
			{
				StringBuilder mess = new StringBuilder(Resive.messagesText);
				TempMessages.Add(mess?.ToString());
			}				
		}

		public static void Clear()
		{
			TempMessages.Clear();
		}



		public static List<string> TempMessages = new List<string>();
	}
}
