using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
namespace DoAn_Net
{
    class Connection
    {
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
        SqlConnection conn;
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

        public DataTable getDatatable(string sql)
        {
            conn = new SqlConnection(stringConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, stringConnection);
            da.Fill(dt);
            return dt;
        }


        public int updateDataBase(DataTable dt)
        {
            SqlDataAdapter ds_Products = new SqlDataAdapter("select * from orders", stringConnection);
            SqlCommandBuilder cb = new SqlCommandBuilder(ds_Products);
            int kq = ds_Products.Update(dt);
            return kq;
        }

        public int updateDataBaseCus(DataTable dt)
        {
            SqlDataAdapter ds_Products = new SqlDataAdapter("select * from customer", stringConnection);
            SqlCommandBuilder cb = new SqlCommandBuilder(ds_Products);
            int kq = ds_Products.Update(dt);
            return kq;
        }

        public int updateDataBaseCT(DataTable dt)
        {
            SqlDataAdapter ds_Products = new SqlDataAdapter("select * from orderDetails", stringConnection);
            SqlCommandBuilder cb = new SqlCommandBuilder(ds_Products);
            int kq = ds_Products.Update(dt);
            return kq;
        }

        public object getScalar(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object kq = cmd.ExecuteScalar();
            return kq;
            conn.Close();
        }

    }
}
