using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalRNotification.Data
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string sender, string receiver, string msgTitle, string msgBody)
        {
            await Clients.All.SendAsync("ReceiverMessage", sender, receiver, msgTitle, msgBody);
        }
    }
}