using Db3.Model;
using MySql.Data.MySqlClient;
using System;

public class DbConnector : IDisposable
{
    private MySqlConnection connection;

    public DbConnector()
    {
        string connectionString = "server=127.0.0.1;port=3306;username=root;password=159951159951mM;database=kruglikov_matvey";
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    public void Dispose()
    {
        CloseConnection();
    }
    //NameBox.Text, PassBox.Text, AddressBox.Text, currentCustomer.Phone
    public void UpdateUserData(string username, string password, string address, string phone)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE customer SET password = @password, address = @address, phone = @phone WHERE nickname = @username";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void DeleteUserData(string username)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "DELETE FROM customer WHERE nickname = @username";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
