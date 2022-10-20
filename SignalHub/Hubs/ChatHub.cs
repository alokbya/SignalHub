using Microsoft.AspNetCore.SignalR;
using SignalHub.Models;

namespace SignalHub.Hubs;

public class ChatHub : Hub
{
    public Task SendMessage(BaseMessage message)
    {
        return Clients.All.SendAsync("ReceiveMessage", message);
    }
}