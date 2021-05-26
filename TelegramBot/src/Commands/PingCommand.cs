using System.Collections.Generic;
using System.Threading.Tasks;

namespace TelegramBot.Commands
{
    public class PingCommand : IBotCommand
    {
        public string Command => "ping";

        public string Description => "This is a simple command that can be used to test if the bot is online";

        public bool InternalCommand => false;

        public async Task Execute(IChatService chatService, long chatId, int userId, int messageId, string commandText)
        {
            await chatService.SendMessage(chatId, "pong");
            string s = await chatService.GetChatMemberName(chatId, userId);

            Dictionary<string, string> buttons = new Dictionary<string, string>();
            buttons.Add("Допомога", "/help");
            buttons.Add("2", "button2");
            buttons.Add("3", "button3");
            buttons.Add("4", "button4");
    
            await chatService.SendMessage(chatId, s, buttons);

            await chatService.SendInvoice(chatId);
        }
    }
}