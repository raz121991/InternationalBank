
using System.Data.SqlClient;

string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

// Define the query to retrieve data
string query = "SELECT ProductId, ProductName, Price FROM Products";

// Create a SqlConnection to the database
using (SqlConnection connection = new SqlConnection(connectionString))
{
    try
    {
     
        connection.Open();


        using (SqlCommand command = new SqlCommand(query, connection))
        {
           
            using (SqlDataReader reader = command.ExecuteReader())
            {
               
                if (reader.HasRows)
                {
                  
                    while (reader.Read())
                    {
                        
                        int productId = reader.GetInt32(0);   
                        string productName = reader.GetString(1);  
                        decimal price = reader.GetDecimal(2);  

                     
                        Console.WriteLine($"ID: {productId}, Name: {productName}, Price: {price:C}");
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
        }
    }
    catch (Exception ex)
    {
        
        Console.WriteLine($"Error: {ex.Message}");
    }
    finally
    {
       
        Console.WriteLine("Connection closed.");
    }
}