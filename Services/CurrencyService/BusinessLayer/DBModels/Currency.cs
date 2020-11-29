using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace BusinessLayer.DBModels
{
    public partial class Currency
    {
        [BsonId]
        public string ID { get; set; }
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }
        public double Ron { get; set; }
        public double Uah { get; set; }
        public string Type { get; set; }
        public DateTime? TimeCurrency { get; set; }
    }
}
