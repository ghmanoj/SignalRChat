
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Services;

namespace SignalRChat.Hubs;

public class ChatHub : Hub
{
    private readonly NotificationService _notificationService;

    public ChatHub(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

}
