using DesingPatternsAsp.Configuration;
using DesingPatternsAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tools;

namespace DesingPatternsAsp.Controllers
{
	public class HomeController : Controller
	{
		//private readonly ILogger<HomeController> _logger;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}
		private readonly IOptions<MyConfig> _config;
		public HomeController(IOptions<MyConfig> config)
		{
			_config = config;
		}

		public IActionResult Index()
		{
			Log.GetInstance(_config.Value.PathLog).Sava("Intro a index");
			return View();
		}

		public IActionResult Privacy()
		{
			Log.GetInstance(_config.Value.PathLog).Sava("Intro a privacy");
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
