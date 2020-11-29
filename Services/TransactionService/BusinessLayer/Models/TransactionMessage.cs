using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class TransactionMessage
    {
        public string AccountOwnerId { get; set; }
        public string AccountReceiverId { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }

    }
}
