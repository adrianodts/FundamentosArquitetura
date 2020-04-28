using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class MySqlDbConnector : DbConnector
    {
        public override Connection Connect(string connectionString)
        {
            Console.WriteLine("Connecting to MySql database : [" + connectionString + "]");
            return new Connection(ConnectionString);
        }
    }
}
