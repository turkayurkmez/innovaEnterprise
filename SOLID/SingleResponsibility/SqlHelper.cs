using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SqlHelper
    {
        private SqlConnection connection;
        public SqlHelper(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }
        
        public int ExecuteNonQuery(string commandText, Dictionary<string,object> parameters)
        {
            SqlCommand command = CreateCommand(commandText, parameters);
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        private SqlCommand CreateCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            AddParametersToCommand(command, parameters);
            return command;
                
                
        }

        private void AddParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
            
        }
    }
}
