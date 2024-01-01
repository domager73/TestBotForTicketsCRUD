using Telegram.Bot;

namespace TestBotForTicketsCRUD;

public class TgBot
{
    private TelegramBotClient _botClient;

    public TgBot()
    {
        _botClient = new TelegramBotClient("6100935167:AAGn80IMbK-IUNuYPiglNrFwQb19aKNUZSY");
    }

    public void SendOrderToChat(String name)
    {
        Task.Run(() =>
            _botClient.SendTextMessageAsync(
                chatId: 879223741,
                text: name
            ));
    }
}