using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccount account;

        public AccountController()
        {
            var _bl = new BusinessManager();
            account = _bl.Account();
        }

        [HttpPost]
        public ActionResult<AccountResponse> Post([FromBody] AccountMessage data)
        {
            var response = account.GetAccount(data);
            return response.Result;
        }
    }
}
