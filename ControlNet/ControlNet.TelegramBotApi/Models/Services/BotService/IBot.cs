﻿using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace ControlNet.TelegramBotApi.Models.Services.BotService
{
    public interface IBot
    {
        #region Methods

        Task SetWebhookAsync(string webhookUrl);

        Task MessageHandling(Update update);

        Task SendMessage(int chatId, string message);

        #endregion
    }
}
