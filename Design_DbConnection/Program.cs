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
            sql.Open();
            sql.Close();
            var oracle = new OracleConnection("stringtotest", TimeSpan.FromMilliseconds(5000));
            oracle.Open();
            oracle.Close();
        }
    }
}
