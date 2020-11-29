using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLModels
{
   public class CurrencyItems
    {
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }
        public double Ron { get; set; }
        public double Uah { get; set; }
        public string Type { get; set; }
        public DateTime? TimeCurrency { get; set; }

    }
}
