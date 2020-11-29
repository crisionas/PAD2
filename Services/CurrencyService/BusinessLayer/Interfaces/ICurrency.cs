using BusinessLayer.BLModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ICurrency
    {
        public Task<CurrencyResponse> GetCurrency();
    }
}
