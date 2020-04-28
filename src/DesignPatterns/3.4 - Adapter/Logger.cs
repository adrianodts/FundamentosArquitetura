using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    //Target Class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("[Log padrão: " + message + "]");
        }
    }
}
