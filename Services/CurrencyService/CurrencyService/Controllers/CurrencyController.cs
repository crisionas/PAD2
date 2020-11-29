using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.BLModels;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        ICurrency currency;

        public CurrencyController()
        {
            var _bl = new BusinessManager();
            currency = _bl.Currency();
        }
        [HttpGet]
        public ActionResult<CurrencyResponse> Get()
        {
            var response = currency.GetCurrency();
            return response.Result;
        }
    }
}
