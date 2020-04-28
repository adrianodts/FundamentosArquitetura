using System;

namespace DesignPatterns.FactoryMethod
{
    public class Connection
    {
        private string connectionString;

        public Connection(string connectionString)
        {
            this.connectionString = connectionString;
        }        
    }
}