using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Submits
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddSubmit(Submit submit)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Submit Values(@appId, @userId);");
            cmd.Parameters.AddWithValue("@appId", submit.AppId);
            cmd.Parameters.AddWithValue("@userId", submit.UserId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public string GetUserIdByAppId(string appId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT userId FROM Submit WHERE appId = @appId");
            cmd.Parameters.AddWithValue("@appId", appId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            var result = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return result?.ToString();
        }
    }
}
