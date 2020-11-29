using Proxy_Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy_Server.Interfaces
{
   interface IServerStorage
    {
        public Server GetServer(string service);   
    }
}
