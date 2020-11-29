using Microsoft.Extensions.Configuration;
using Proxy_Server.Helpers;
using Proxy_Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy_Server.Services
{
    public class ServerStorage : IServerStorage
    {
        private readonly IConfiguration _config;
        private Dictionary<string, List<Server>> storage;
        private Dictionary<string, RoundRobin> _load_balancing;
        public ServerStorage(IConfiguration configuration, IServiceProvider _serviceProvider)
        {

            _config = configuration;
            storage = new Dictionary<string, List<Server>>();
            ParseServerList();
        }

        public Server GetServer(string service)
        {
            // Regex regex = new Regex(@"^[a-zA-Z\s]*");
          //  Regex regex = new Regex(@"^[a-zA-Z\s]*");
            //var parsed = regex.Match(service.TrimStart("/api/".ToCharArray())).Value;
           
            var branch = _load_balancing
                .Where(m => m.Key == service)
                .Select(m => m.Value)
                .FirstOrDefault();

            if(branch==null)
            {
                branch = _load_balancing.Where(m => m.Key == "").Select(m => m.Value)
                    .FirstOrDefault();
            }
            var selected = branch.GetServer();
            return selected;
        }

        private void ParseServerList()
        {
            List<Server> serverlist = new List<Server>();
            _config.GetSection("servers").Bind(serverlist);
            // Dictionary selection group by Service.
            storage = serverlist.GroupBy(m => m.Service)
                .ToDictionary(g => g.Key, g => g.ToList());
            AsignServersToRoundRobin();
        }
        private void AsignServersToRoundRobin()
        {
            _load_balancing = new Dictionary<string, RoundRobin>();
            foreach(var item in storage)
            {
                _load_balancing.Add(item.Key, new RoundRobin(item.Value));
            }
        }
    }
}
