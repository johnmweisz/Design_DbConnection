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
            var Sql = new SqlConnection("testingconnectionstring", TimeSpan.FromMilliseconds(10000));
            Sql.Open();
            Sql.Close();
            var Oracle = new OracleConnection("stringtotest", TimeSpan.FromMilliseconds(5000));
            Oracle.Open();
            Oracle.Close();
        }
    }
}
