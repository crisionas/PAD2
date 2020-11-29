using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class CurrencyResponse
    {
        public CurrencyItems BuyCurrency { get; set; }
        public CurrencyItems SellCurrency { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
}
