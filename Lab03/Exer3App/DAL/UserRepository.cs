using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepository
    {
        public bool ValidateLogin(string username, string password)
        {
            string connectionString =
                ConfigurationManager
                    .ConnectionStrings["LoginDBConnectionString"]
                    .ConnectionString;

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    "SELECT COUNT(1) FROM tblUsers " +
                    "WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@Username", username);

                    command.Parameters.AddWithValue(
                        "@Password", password);

                    int count =
                        Convert.ToInt32(command.ExecuteScalar());

                    return count == 1;
                }
            }
        }
    }
}
