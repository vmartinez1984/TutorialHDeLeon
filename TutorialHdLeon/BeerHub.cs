using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalAR
{
    public class BeerHub:Hub
    {
        public async Task Send(string Name, string Brand)
        {
            await Clients.All.SendAsync("Receiver",Name, Brand);
        }
    }
}
