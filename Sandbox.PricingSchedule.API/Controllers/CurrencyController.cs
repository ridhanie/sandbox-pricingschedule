using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandbox.PricingSchedule.Data.Repositories;
using Sandbox.PricingSchedule.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sandbox.PricingSchedule.API.Controllers
{
    [Route("api/[controller]")]
    public class CurrencyController : Controller
    {
        private readonly ICurrencyRepository _CurrencyRepository;

        public CurrencyController(ICurrencyRepository currencyRepository)
        {
            _CurrencyRepository = currencyRepository;
        }

        [HttpGet]
        public IActionResult GetCurrencys()
        {
            return Ok(_CurrencyRepository.GetAllCurrencys());
        }

        [HttpGet("{id}")]
        public IActionResult GetCurrencyById(int id)
        {
            return Ok(_CurrencyRepository.GetCurrencyById(id));
        }

        [HttpPost]
        public IActionResult CreateCurrency([FromBody] Currency Currency)
        {
            if (Currency == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdCurrency = _CurrencyRepository.AddCurrency(Currency);

            return Created("Currency", createdCurrency);
        }
    }
}

