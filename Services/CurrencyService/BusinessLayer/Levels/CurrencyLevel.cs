using BusinessLayer.BLModels;
using BusinessLayer.Implementation;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Levels
{
    public class CurrencyLevel : CurrencyImplementation, ICurrency
    {
        public Task<CurrencyResponse> GetCurrency()
        {
            return CurrencyAction();
        }
    }
}
