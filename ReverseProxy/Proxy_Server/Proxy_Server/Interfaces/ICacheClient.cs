using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Proxy_Server.Interfaces
{
     interface ICacheClient
    {
        public bool GetDataByRequest(string request_path, ref HttpContext context);
        public void Initialize(IDistributedCache data);
        public void SetCache(string key, string body);
        public bool IsCacheable(string service);
    }
}
