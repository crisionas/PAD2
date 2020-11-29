
using BusinessLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class ServicesImplementation
    {

        internal async Task<AccountResponse> AccountAction(AccountMessage data)
        {
            var data_req = JsonConvert.SerializeObject(data);
            var content = new StringContent(data_req, Encoding.UTF8, "application/json");

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            handler.AllowAutoRedirect = true;
            var client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://localhost:44363/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = client.PostAsync("api/account", content);
            var regresp = new AccountResponse();

            try
            {
                var data_resp = await response.Result.Content.ReadAsStringAsync();
                regresp = JsonConvert.DeserializeObject<AccountResponse>(data_resp);

            }
            catch (AggregateException e)
            {
            }
            return new AccountResponse
            {
                Account = regresp.Account,
                Message = regresp.Message,
                Status = regresp.Status
            };
        }
        internal async Task<CurrencyResponse> CurrencyAction()
        {

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            handler.AllowAutoRedirect = true;
            var client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://localhost:44363/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync("api/currency");
            var regresp = new CurrencyResponse();

            try
            {
                var data_resp = await response.Result.Content.ReadAsStringAsync();
                regresp = JsonConvert.DeserializeObject<CurrencyResponse>(data_resp);

            }
            catch (AggregateException e)
            {
            }
            return new CurrencyResponse
            {
                BuyCurrency=regresp.BuyCurrency,
                Message=regresp.Message,
                SellCurrency=regresp.SellCurrency,
                Time=regresp.Time
            };
        }
        internal async Task<TransactionResponse> TransactionAction(TransactionMessage data)
        {
            var data_req = JsonConvert.SerializeObject(data);
            var content = new StringContent(data_req, Encoding.UTF8, "application/json");

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            handler.AllowAutoRedirect = true;
            var client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://localhost:44363/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = client.PostAsync("api/transaction", content);
            var regresp = new TransactionResponse();

            try
            {
                var data_resp = await response.Result.Content.ReadAsStringAsync();
                regresp = JsonConvert.DeserializeObject<TransactionResponse>(data_resp);

            }
            catch (AggregateException e)
            {
            }
            return new TransactionResponse
            {
                Message=regresp.Message,
                Status=regresp.Status
            };
        }
    }
}
