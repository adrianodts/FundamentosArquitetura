using System;

namespace DesignPatterns.FactoryMethod
{
    public class OracleDbConnector : DbConnector
    {
        public override Connection Connect(string connectionString)
        {
            Console.WriteLine("Connecting to Oracle database : [" + connectionString + "]");
            return new Connection(ConnectionString);
        }

        public override void ExecuteSqlCommand(string sqlStatement)
        {
            Console.WriteLine("Executing query from concrete : [ " + sqlStatement + "]");
        }
    }
}