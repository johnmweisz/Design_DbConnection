using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("testingconnectionstring", TimeSpan.FromMilliseconds(10000));
            var oracle = new OracleConnection("stringtotest", TimeSpan.FromMilliseconds(5000));
            var sqlCommand = new DbCommand(sql, "Some beautiful query here");
            var oracleCommand = new DbCommand(oracle, "Some amazing query here");
            sqlCommand.Execute();
            oracleCommand.Execute();
        }
    }
}
