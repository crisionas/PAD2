using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TransactionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        ITransaction transaction;
        public TransactionController()
        {
            var _bl = new BusinessManager();
            transaction = _bl.Transaction();
        }
        [HttpPost]
        public ActionResult<TransactionResponse> Post([FromBody] TransactionMessage message)
        {
            var response = transaction.GetTransaction(message);
            return response.Result;
        }
    }
}
