using System;

namespace DesignPatterns.FactoryMethod
{
    public abstract class DbConnector
    {
        protected string ConnectionString { get; private set; }
        public abstract Connection Connect(string connectionString);

        public virtual void ExecuteSqlCommand(string sqlStatement)
        {
            Console.WriteLine("Executing query from abstract : [ " + sqlStatement + "]");
        }
    }
}