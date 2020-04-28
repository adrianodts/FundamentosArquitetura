using System;

namespace DesignPatterns.Adapter
{
    public interface ILogNetMaster
    {
        void LogException(Exception exception);
    }
}