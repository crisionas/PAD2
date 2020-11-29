using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace BusinessLayer.DBModels
{
    public partial class Transactions
    {
        [BsonId]
        public string TransactionId { get; set; }
        public string AccountOwnerId { get; set; }
        public string AccountReceiverId { get; set; }
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }

    }
}
