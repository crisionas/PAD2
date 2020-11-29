using Proxy_Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy_Server.Helpers
{
    public class RoundRobin
    {
        private List<Server> _servers;
        private int i; //last choosen server
        private int gcd;//GCD
        private int cw;//current dispatch weight
        private int max;
        private int n;//server count
        private object _lock;
        public RoundRobin(List<Server> servers)
        {
            if (_servers == null)
            {
                _lock = new object();
                _servers = servers;
                Init();
            }

        }
        private void Init()
        {
            i = -1;
            gcd = GetGcd(_servers);
            cw = 0;
            max = GetMaxWeight(_servers);
            n = _servers.Count();
        }
        public Server GetServer()
        {
            lock (_lock)
            {
                while (true)
                {
                    i = (i + 1) % n;
                    if (i == 0)
                    {
                        cw = cw - gcd;
                        if (cw <= 0)
                        {
                            cw = max;
                            if (cw == 0)
                                return null;
                        }
                    }
                    if (_servers[i].Weight >= cw)
                    {
                        return _servers[i];
                    }
                }
            }
        }
        private int GetGcd(List<Server> servers)
        {
            return 1;
        }
        private  int GetMaxWeight(List<Server> servers)
        {
            int max = 0;
            foreach (var s in servers)
            {
                if (s.Weight > max)
                    max = s.Weight;
            }
            return max;
        }
    }


}

