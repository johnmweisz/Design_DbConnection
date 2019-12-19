using System;

namespace Design_DbConnection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connection, TimeSpan timeout) 
            : base(connection, timeout)
        {
            
        }
        public override void Open()
        {
            Console.WriteLine($"Opening Oracle Connection {ConnectionString} within {Timeout} milliseconds");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle Connection");
        }
    }
}