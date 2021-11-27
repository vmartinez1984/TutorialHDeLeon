using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPatternsAsp.Controllers
{
	public class ProductDetailsController : Controller
	{
		private EarnFactory _localEarnFactory;

		public ProductDetailsController(LocalEarnFactory localEarnFactory)
		{
			_localEarnFactory = localEarnFactory;
		}
		public IActionResult Index(decimal total)
		{
			//Factories
			ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30M, 20);

			//Products
			var localEarn = _localEarnFactory.GetEarn();
			var foreignEarn = foreignEarnFactory.GetEarn();

			//total
			ViewBag.TotalLocal = total+ localEarn.Earn(total);
			ViewBag.TotalForeign = total+ foreignEarn.Earn(total);

			return View();
		}
	}
}
