using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodExecutor
    {
        public static void Execute()
        {
            var oracleConnector = DbFactory.Database(DataBase.Oracle).CreateConnector();
            oracleConnector.Connect("oracleCN");
            oracleConnector.ExecuteSqlCommand("Select * from OracleTable");

            var mySqlConnector = DbFactory.Database(DataBase.MySql)
                .CreateConnector();
            mySqlConnector.Connect("mySqlCN");
            mySqlConnector.ExecuteSqlCommand("Select * from MysqlTable");

            Console.ReadKey();
        }        
    }
}
