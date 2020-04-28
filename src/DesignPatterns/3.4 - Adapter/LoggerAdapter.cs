using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class LoggerAdapter : ILogger
    {
        private ILogNetMaster _logNetMaster;

        public LoggerAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        public void Log(string message)
        {
            _logNetMaster.LogException(new Exception(message));
        }
    }
}
