using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductBusiness
    {

        public int AddProduct(string name, decimal price)
        {
            string connectionString = @"Data Source=(localdb)\Mssqllocaldb;Initial Catalog=vakifShopdb;Integrated Security=True";
            string commandText = "INSERT into Products (Name, Price, Discount) VALUES (@name, @price,0.0)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            SqlHelper helper = new SqlHelper(connectionString);
            var result = helper.ExecuteNonQuery(commandText, parameters);

            return result;
        }

        public int UpdateProduct(int id, string name, decimal price)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\Mssqllocaldb;Initial Catalog=vakifShopdb;Integrated Security=True");
            SqlCommand command = new SqlCommand("UPDATE Products SET Name = @name, Price = @price WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);

            connection.Open();
            var result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }

        public int DeleteProduct(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\Mssqllocaldb;Initial Catalog=vakifShopdb;Integrated Security=True");
            SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);

            connection.Open();
            var result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }


    }
}
