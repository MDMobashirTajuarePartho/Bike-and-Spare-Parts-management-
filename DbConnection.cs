using System;
using System.Data.SqlClient;

public static class DbConnection
{
    private static string connectionString = @"Data Source=DESKTOP-JNA3O30\\SQLEXPRESS;Initial Catalog=BikePartsDB;Integrated Security=True";

    // This method only creates a new SqlConnection, without opening it
    public static SqlConnection GetConnection()
    {
        try
        {
            return new SqlConnection(connectionString);
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Connection Error: " + ex.Message);
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Connection Error: " + ex.Message);
            throw;
        }
    }
}
