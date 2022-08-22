using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

Message message = await botClient.SendTextMessageAsync(
    chatId: chatId,
    text: "Trying *all the parameters* of `sendMessage` method",
    parseMode: ParseMode.MarkdownV2,
    disableNotification: true,
    replyToMessageId: update.Message.MessageId,
    replyMarkup: new InlineKeyboardMarkup(
        InlineKeyboardButton.WithUrl(
            "Check sendMessage method",
            "https://core.telegram.org/bots/api#sendmessage")),
    cancellationToken: cancellationToken);
