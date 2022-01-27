using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sandbox.PricingSchedule.Shared;

namespace Sandbox.PricingSchedule.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Currency> Currencies { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Currency>().HasData(new List<Currency>()
			{
				new Currency()
				{
					Country = "USA",
					CurrencyId = 1,
					Name = "USD",
					USExchange = 1
				},				
				new Currency()
				{
					Country = "Germany",
					CurrencyId = 2,
					Name = "Euro",
					USExchange = 0.88
				},
				new Currency()
				{
					Country = "Canada",
					CurrencyId = 3,
					Name = "CAD",
					USExchange = 1.26
				},
				new Currency()
				{
					Country = "UK",
					CurrencyId = 4,
					Name = "GBP",
					USExchange = 0.74
				},
				new Currency()
				{
					Country = "India",
					CurrencyId = 5,
					Name = "INR",
					USExchange = 74.80
				},
				new Currency()
				{
					Country = "Indonesia",
					CurrencyId = 6,
					Name = "IDR",
					USExchange = 14334.8
				}
			});
		}
	}
}

