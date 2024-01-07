using System;
using Microsoft.Data.SqlClient;

partial class Program
{
    static void Main()
    {
        var connectionString = "Server=localhost;User Id=SA;Password=YourStrong(!)Password;"; // Modify as needed
        try
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection successful.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

