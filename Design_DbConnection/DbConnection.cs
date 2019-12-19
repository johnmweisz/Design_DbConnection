using System;

namespace Design_DbConnection
{
    abstract class DbConnection
    {
        protected string ConnectionString { get; }
        protected TimeSpan Timeout { get; }

        protected DbConnection(string connection)
            : this(connection, TimeSpan.FromMilliseconds(2000))
        {
        }

        protected DbConnection(string connection, TimeSpan timeout)
        {
            if (string.IsNullOrWhiteSpace(connection))
                throw new ArgumentNullException(connection, "Connection string must not be empty");
            this.ConnectionString = connection;
            this.Timeout = timeout;
        }

        public abstract void Open();

        public abstract void Close();
    }
}