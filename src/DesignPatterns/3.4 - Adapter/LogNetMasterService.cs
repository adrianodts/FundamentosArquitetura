using System;

namespace DesignPatterns.Adapter
{
    internal class LogNetMasterService : ILogNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("[Log Customizado - " + exception.Message + "]");
        }
    }
}