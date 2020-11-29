using BusinessLayer.BLModels;
using BusinessLayer.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementation
{
    public class CurrencyImplementation
    {
       internal async Task<CurrencyResponse> CurrencyAction()
        {
            try
            {
                MongoCRUD context = new MongoCRUD("PADLaboratories");

                var data = new Currency
                {
                    Eur = 1,
                    Ron = 2,
                    TimeCurrency = DateTime.Now,
                    Rub = 3,
                    Type = "SELL",
                    Uah = 13,
                    Usd = 4
                };
                var data1 = new Currency
                {
                    Eur = 1,
                    Ron = 2,
                    TimeCurrency = DateTime.Now,
                    Rub = 3,
                    Type = "BUY",
                    Uah = 13,
                    Usd = 4
                };
                context.InsertCurrency(data);
                context.InsertCurrency(data1);

                var sellCurrency =context.GetCurrency("SELL");
               var buyCurrency = context.GetCurrency("BUY");

                    if(sellCurrency==null && buyCurrency==null)
                    {
                        return new CurrencyResponse
                        {
                            Message = "ERROR! Currencies are null",
                            Time = DateTime.Now
                        };
                    }
                    else
                    {
                        var sell = new CurrencyItems
                        {
                            Eur = sellCurrency.Eur,
                            Ron = sellCurrency.Ron,
                            Rub = sellCurrency.Rub,
                            Usd = sellCurrency.Usd,
                            Uah = sellCurrency.Uah,
                            Type = sellCurrency.Type,
                            TimeCurrency = sellCurrency.TimeCurrency
                        };
                        var buy = new CurrencyItems
                        {
                            Eur = buyCurrency.Eur,
                            Ron = buyCurrency.Ron,
                            Rub = buyCurrency.Rub,
                            Usd = buyCurrency.Usd,
                            Uah = buyCurrency.Uah,
                            Type = buyCurrency.Type,
                            TimeCurrency = buyCurrency.TimeCurrency
                        };
                        return new CurrencyResponse
                        {
                            BuyCurrency = buy,
                            SellCurrency = sell,
                            Time = DateTime.Now,
                            Message = "Currency was updated successfully!"
                        };

                    
                }
                
            }
            catch(Exception ex)
            {
                return new CurrencyResponse
                {
                    Message = $"ERROR! {ex.Message}",
                    Time = DateTime.Now
                };

            }
        }
    }
}
