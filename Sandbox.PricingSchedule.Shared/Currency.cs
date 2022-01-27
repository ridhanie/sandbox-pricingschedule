﻿using System;
namespace Sandbox.PricingSchedule.Shared
{
	public class Currency
	{
		public int CurrencyId { get; set; }
		public string? Name { get; set; }
		public string? Country { get; set; }
		public double USExchange { get; set; }
	}
}

