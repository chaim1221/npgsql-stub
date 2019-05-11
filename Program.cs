using System;
using Npgsql;

namespace stub
{
    class Program
    {
        static void Main(string[] args)
        {
var connString = "Host=postgresql;Username=postgres;Password=passw0rD!;Database=mydatabase";

using (var conn = new NpgsqlConnection(connString))
{
    conn.Open();

    // Insert some data
    using (var cmd = new NpgsqlCommand())
    {
        cmd.Connection = conn;
        cmd.CommandText = "INSERT INTO data (some_field) VALUES (@p)";
        cmd.Parameters.AddWithValue("p", "Hello world");
        cmd.ExecuteNonQuery();
    }

    // Retrieve all rows
    using (var cmd = new NpgsqlCommand("SELECT some_field FROM data", conn))
    using (var reader = cmd.ExecuteReader())
        while (reader.Read())
            Console.WriteLine(reader.GetString(0));
}
        }
    }
}
