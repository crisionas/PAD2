using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IAccount
    {
        public Task<AccountResponse> GetAccount(AccountMessage account);
    }
}
