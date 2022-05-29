using Microsoft.AspNetCore.SignalR;

namespace SimpleChat.Hubs
{
    public class SimpleChat : Hub
    {
        public async Task SendMessage(string user, string messgage)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, messgage);
        }
    }
}
