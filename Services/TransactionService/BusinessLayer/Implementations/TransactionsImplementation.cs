using BusinessLayer.DBModels;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class TransactionsImplementation
    {
        internal async Task<TransactionResponse> TransactionAction(TransactionMessage data)
        {
            try
            {

                MongoCRUD context = new MongoCRUD("PADLaboratories");
                var response = context.InsertTransaction(data);
                if (response)
                    return new TransactionResponse
                    {
                        Status = true,
                        Message = "Transaction has been successfully processed."
                    };

                else
                {
                    return new TransactionResponse
                    {
                        Status = false,
                        Message = "Transaction failed."
                    };
                }
            }
            catch (Exception ex)
            {
                return new TransactionResponse
                {
                    Status = false,
                    Message = $"{ex.Message}"
                };
            }
        }
    }
}
