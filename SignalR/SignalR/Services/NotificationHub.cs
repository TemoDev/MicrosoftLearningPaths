using Microsoft.AspNetCore.SignalR;
using SignalR.Models;

namespace SignalR.Services;

public class NotificationHub : Hub
{
    public Task NotifyAll(Notification notification) => 
        Clients.All.SendAsync("NotificationReceived", notification);
}