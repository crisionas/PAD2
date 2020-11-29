 using BusinessLayer.DBModels;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementation
{
    public class AccountImplementation
    {
        internal async Task<AccountResponse> AccountAction(AccountMessage data)
        {
            try
            {
                MongoCRUD context = new MongoCRUD("PADLaboratories");
              //  var data1 = new AccountMessage { FirstName = "Binzari", LastName = "Ionica", Phone = "123214", DateRegistered = DateTime.Now, Description = "Test", Balance = 14213.5 };
               // var data2 = new AccountMessage { FirstName = "Binzari", LastName = "Ionica", Phone = "123214", DateRegistered = DateTime.Now, Description = "Test", Balance = 14213.5 };

                var insert = context.InsertAccount(data);
              //  context.InsertAccount(data1);
              // context.InsertAccount(data2);
               var account = context.GetAccount(data);
                if (account == null)
                {
                    return new AccountResponse
                    {
                        Status = false,
                        Message = "Account doesn't exist.",
                        Account = null
                    };
                }
                else
                {
                    return new AccountResponse
                    {
                        Status = true,
                        Account = account,
                        Message = $"Account {data.AccountId} exists!"
                    };
                }
            }
            catch (Exception e)
            {
                return new AccountResponse
                {
                    Status = false,
                    Message = e.Message,
                    Account = null
                };
            }
        }
    }
}
