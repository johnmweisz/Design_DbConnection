using System;

namespace Design_DbConnection
{
    class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _instruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentNullException(instruction, "Instruction must not be empty");
            this._connection = connection ?? throw new NullReferenceException(instruction);
            this._instruction = instruction;
        }

        public void Execute()
        {
            _connection.Open();
            Console.WriteLine($"Running the command {_instruction}");
            _connection.Close();
        }
    }
}