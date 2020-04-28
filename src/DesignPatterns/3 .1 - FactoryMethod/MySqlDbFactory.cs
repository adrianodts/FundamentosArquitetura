namespace DesignPatterns.FactoryMethod
{
    public class MySqlDbFactory : DbFactory
    {
        public override DbConnector CreateConnector()
        {
            return new MySqlDbConnector();
        }
    }
}