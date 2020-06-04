using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace TotechsDotNet.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMess(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}