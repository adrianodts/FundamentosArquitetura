namespace DesignPatterns.FactoryMethod
{
    public class OracleDbFactory : DbFactory
    {
        public override DbConnector CreateConnector()
        {
            return new OracleDbConnector();
        }
    }
}