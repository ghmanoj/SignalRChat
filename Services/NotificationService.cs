using Microsoft.AspNetCore.SignalR;

using SignalRChat.Hubs;

namespace SignalRChat.Services
{
    public class NotificationService
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public NotificationService(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }
    }
}
