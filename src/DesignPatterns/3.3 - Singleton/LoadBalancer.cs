using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();
        private Random _random = new Random(1);

        public List<Server> _server { get; private set; }

        private LoadBalancer() => _server = new List<Server>
        {
            new Server { Id = Guid.NewGuid(), Name = "Berlin", IpAddress = "192.168.1.2" },
            new Server { Id = Guid.NewGuid(), Name = "Tokio", IpAddress = "192.168.1.3" },
            new Server { Id = Guid.NewGuid(), Name = "Rio", IpAddress = "192.168.1.4" },
            new Server { Id = Guid.NewGuid(), Name = "Lisboa", IpAddress = "192.168.1.5" },
            new Server { Id = Guid.NewGuid(), Name = "Denver", IpAddress = "192.168.1.6" }
        };

        public static LoadBalancer GetInstance()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_server.Count);
                return _server[r];
            }
        }
    }
}
