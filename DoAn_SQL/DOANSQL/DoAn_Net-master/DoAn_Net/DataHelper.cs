using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Net
{
    public class DataHelper
    {
        private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
        public Account GetUserInfo(string userName)
        {
            Account user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Username, Displayname, Email FROM Account WHERE Username = @UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string displayName = reader["Displayname"].ToString();
                        string email = reader["Email"].ToString();

                        user = new Account(userName, displayName, email);
                    }
                }

                connection.Close();
            }

            return user;
        }
    }

}
