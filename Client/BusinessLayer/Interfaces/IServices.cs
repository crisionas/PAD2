using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
   public interface IServices
    {
        public Task<AccountResponse> GetAccount(AccountMessage account);
        public Task<CurrencyResponse> GetCurrency();
        public Task<TransactionResponse> GetTransaction(TransactionMessage transaction);

    }
}
