using System.Data.SqlClient;

public static class SQL
{
    private static string connectionString = "Data Source=RIDMA_LAPTOP;Initial Catalog=lpda;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public static void ExecuteQuery(string query)
    {
        using (SqlConnection connection = GetConnection())
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static SqlDataReader ExecuteReader(string query)
    {
        SqlConnection connection = GetConnection();
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();
        return command.ExecuteReader();
    }
}
