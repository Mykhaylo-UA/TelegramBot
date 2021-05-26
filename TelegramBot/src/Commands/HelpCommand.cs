using System;
using System.Threading.Tasks;

namespace TelegramBot.Commands
{
    public class HelpCommand : IBotCommand
    {
        private readonly IServiceProvider _serviceProvider;

        public string Command => "help";

        public string Description => "Отримати описання команд";

        public bool InternalCommand => false;

        public HelpCommand(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Execute(IChatService chatService, long chatId, int userId, int messageId, string commandText)
        {
            await chatService.SendMessage(chatId, "/ping - пінг");
        }
    }
}