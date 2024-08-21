using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using YTMProject.Models.Commands;

namespace YTMProject.Models
{
	public class Bot
	{
        private static TelegramBotClient botClient;
		private static List<Command> commandsList;

		public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

		public static TelegramBotClient GetBotClient()
		{
			if (botClient != null)
			{
				return botClient;
			}
			//TODO: Add more commands

			botClient = new TelegramBotClient("APIKEY");
			return botClient;
		}
	}
}
