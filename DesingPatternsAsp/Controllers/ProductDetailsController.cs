using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPatternsAsp.Controllers
{
	public class ProductDetailsController : Controller
	{
		public IActionResult Index(decimal total)
		{
			//Factories
			LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
			ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30M, 20);

			//Products
			var localEarn = localEarnFactory.GetEarn();
			var foreignEarn = foreignEarnFactory.GetEarn();

			//total
			ViewBag.TotalLocal = total+ localEarn.Earn(total);
			ViewBag.TotalForeign = total+ foreignEarn.Earn(total);

			return View();
		}
	}
}
