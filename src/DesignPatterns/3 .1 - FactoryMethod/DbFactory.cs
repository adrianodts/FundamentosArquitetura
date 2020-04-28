using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector();

        public static DbFactory Database(DataBase dataBase)
        {
            if(dataBase == DataBase.Oracle)
                return new OracleDbFactory();
            else if (dataBase == DataBase.MySql)
                return new MySqlDbFactory();

            throw new ApplicationException("Database not configured!");
        }
    }
}
