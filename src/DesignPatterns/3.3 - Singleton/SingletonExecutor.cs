using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class SingletonExecutor
    {
        public static void Execute()
        {
            var b1 = LoadBalancer.GetInstance();
            var b2 = LoadBalancer.GetInstance();
            var b3 = LoadBalancer.GetInstance();
            var b4 = LoadBalancer.GetInstance();
            var b5 = LoadBalancer.GetInstance();

            if (b1 == b2 && b2 == b3 && b3 == b4 && b4 == b5)
            {
                Console.WriteLine("Mesma instância\n");
            }

            LoadBalancer.GetInstance()._server.ForEach(s => 
            {
                Console.WriteLine("[ Id = " + s.Id + " ] -> Disparando request para " + s.Name);
            });
        }        
    }
}
