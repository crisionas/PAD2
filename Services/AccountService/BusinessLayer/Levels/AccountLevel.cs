using BusinessLayer.Implementation;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Levels
{
    public class AccountLevel : AccountImplementation, IAccount
    {
        public Task<AccountResponse> GetAccount(AccountMessage account)
        {
            return AccountAction(account);
        }
    }
}
