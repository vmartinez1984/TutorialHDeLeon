using DesingPattern.FactoryPattern;
using System;

namespace DesingPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			SaleFactory storeSaleFactory = new StoreSaleFactory(10);
			SaleFactory internetStoreSaleFactory = new InternetSaleFactory(10);

			ISale sale1 = storeSaleFactory.GetSale();
			sale1.Sell(15);

			ISale sale2 = internetStoreSaleFactory.GetSale();
			sale2.Sell(15);
		}
	}
}
