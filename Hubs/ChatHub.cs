
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Services;
using SignalRChat.Models;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly NotificationService _notificationService;

        public ChatHub(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task SendMessage(ChatModel model)
        {
            await Clients.All.SendAsync("ReceiveMessage", model);
        }

    }
}
