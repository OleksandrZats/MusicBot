using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Generic;
using YTMProject.Models;
using YTMProject.Controllers;

namespace YTMProject
{
	public class Resive
	{
		public static string messagesText;
		public static async void Bot_OnMessage(object sender, MessageEventArgs e)
		{
			var rmu = new ReplyKeyboardMarkup();

			rmu.Keyboard =
				new KeyboardButton[][]
				{
					new KeyboardButton[]
					{
						new KeyboardButton("⏮"),
						new KeyboardButton("⏯"),
						new KeyboardButton("⏭")
					},
					new KeyboardButton[]
					{
						new KeyboardButton("🔉+"),
						new KeyboardButton("🔉-"),
						new KeyboardButton("🔉0")
					},
				};
			rmu.ResizeKeyboard = true;
			var text = e?.Message?.Text;
			if (text == null)
				return;

			await Bot.GetBotClient().SendTextMessageAsync(
				chatId: e.Message.Chat,
				text: $" Vot {text}",
				replyMarkup: rmu).ConfigureAwait(false);
			messagesText = text;
			TempMessage.Refresh();
		}
	}
}
