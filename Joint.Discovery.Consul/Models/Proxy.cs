using System.Collections.Generic;

namespace Joint.Discovery.Consul.Models
{
    public class Proxy
    {
        public List<Upstream> Upstreams { get; set; }
    }
}