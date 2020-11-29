using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Proxy_Server.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Server.Services
{
    public class CacheClient : ICacheClient
    {
        private IDistributedCache _cache;
        public bool GetDataByRequest(string request_path, ref HttpContext context)
        {
           // _cache.Remove("currency");
            var body = _cache.GetAsync(request_path).Result;
            if (body == null)
            {
                return false;
            }
            else
            {
                context.Response.Body.WriteAsync(body);
                return true;
            }
        }

        public void Initialize(IDistributedCache data)
        {
            _cache = data;
        }

        public void SetCache(string key, string body)
        {
            DistributedCacheEntryOptions options = new DistributedCacheEntryOptions();

            if(key.Contains("currency"))
            {
                options.SetAbsoluteExpiration(DateTime.Now.AddMinutes(60));
                options.SetSlidingExpiration(TimeSpan.FromMinutes(60));
            }
            else
            {
                options.SetAbsoluteExpiration(DateTime.Now.AddMinutes(5));
                options.SetSlidingExpiration(TimeSpan.FromMinutes(5));
            }
           
            _cache.SetAsync(key, Encoding.UTF8.GetBytes(body), options);
        }

        public bool IsCacheable(string service)
        {
            if(service.Contains("currency"))
            {
                return true;
            }
            return false;
        }
    }
}
