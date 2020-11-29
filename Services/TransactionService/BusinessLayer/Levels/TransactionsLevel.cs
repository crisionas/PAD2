using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Levels
{
    public class TransactionsLevel : TransactionsImplementation, ITransaction
    {
        public Task<TransactionResponse> GetTransaction(TransactionMessage transaction)
        {
            return TransactionAction(transaction);
        }
    }
}
