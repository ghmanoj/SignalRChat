using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;

namespace SignalRChat.Services;

public class NotificationService
{
    private readonly IHubContext<ChatHub> _hubContext;

    private bool _KeepRunning = true;

    public NotificationService(IHubContext<ChatHub> hubContext)
    {
        _hubContext = hubContext;

        startPublishing();
    }

    ~NotificationService()
    {
        _KeepRunning = false;
    }

    public async Task SendNotification(string user, string message)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
    }


    private void startPublishing()
    {
        Thread th = new Thread(new ThreadStart(async () =>
        {
            while (_KeepRunning)
            {
                Console.WriteLine("Sending...");
                await SendNotification("Hello", "World");
                Thread.Sleep(2000);
            }
        }));
        th.Start();
    }
}
