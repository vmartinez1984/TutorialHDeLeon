using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalAR;
using SignalAR.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TutorialHdLeon.Models;

namespace TutorialHdLeon.Controllers
{
    public class HomeController : Controller
    {
        public IHubContext<BeerHub> HubContext;
        public HomeController(IHubContext<BeerHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BeerForm()
        {
            return View(new Beer());
        }

        public async Task<IActionResult> AddBeer(Beer beer)
        {
            await HubContext.Clients.All.SendAsync("Receive", beer.Name, beer.Brand);
            return View("BeerForm");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
