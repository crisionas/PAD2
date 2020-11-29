using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ITransaction
    {
        Task<TransactionResponse> GetTransaction(TransactionMessage transaction);
    }
}
