using Microsoft.AspNetCore.SignalR;

namespace Codepic.StarCitizen.Mfd.Server.Services.Hubs;

public class Mfd : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
