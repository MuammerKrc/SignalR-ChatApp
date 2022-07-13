using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ChatAppClient.Hubs
{
    public class MyHub:Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("GetMessage", message,"mesaj geldi");
        }
    }
}
