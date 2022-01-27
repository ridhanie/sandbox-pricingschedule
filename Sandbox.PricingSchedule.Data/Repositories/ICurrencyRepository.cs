using System;
using System.Collections.Generic;
using Sandbox.PricingSchedule.Shared;

namespace Sandbox.PricingSchedule.Data.Repositories
{
	public interface ICurrencyRepository
	{
		IEnumerable<Currency> GetAllCurrencys();

		Currency GetCurrencyById(int id);

		Currency AddCurrency(Currency Currency);
	}
}

