using System;

namespace Design_DbConnection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connection, TimeSpan timeout) 
            : base(connection, timeout)
        {
            
        }
        public override void Open()
        {
            Console.WriteLine($"Opening Sql Connection {ConnectionString} within {Timeout} milliseconds");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Sql Connection");
        }
    }
}