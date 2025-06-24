using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class SqlDbDataAccess
    {
        private const string connectionString = @"Data Source = LAPTOP-R2N8TUN4\SQLEXPRESS; Initial Catalog= Charity Management System; Trusted_Connection=True";
        public SqlCommand GetQuery(string query)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
    }
}
