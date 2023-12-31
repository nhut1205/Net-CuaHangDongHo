using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DoAn_Net
{
    internal class Modify
    {
        SqlCommand sqlCommand;//dung de truy van cau lenh VD : insert , update , delete
        SqlDataReader dataReader;//doc du lieu trong bang
        public List<Account> Users(string query) 
        { 
        List<Account> users = new List<Account>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    users.Add(new Account(dataReader.GetString(0),dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return users;
        }

        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thực thi câu truy vấn
                sqlConnection.Close();
            }
        }

    }
}
