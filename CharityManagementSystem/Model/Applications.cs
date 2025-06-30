using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Applications
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddApplication(Application app)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Application Values(@appId, @aidType, @appDate, @status, @description, @targetAmount);");
            cmd.Parameters.AddWithValue("@appId", app.AppId);
            cmd.Parameters.AddWithValue("@aidType", app.AidType);
            cmd.Parameters.AddWithValue("@appDate", app.AppDate);
            cmd.Parameters.AddWithValue("@status", app.Status);
            cmd.Parameters.AddWithValue("@description", app.Desc);
            cmd.Parameters.AddWithValue("@targetAmount", app.TargetAmount);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public int GetPendingApplicationCount()
        {
            SqlCommand cmd = sda.GetQuery("SELECT COUNT(*) FROM Application WHERE status = 'Pending'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return count;
        }

        public List<Application> GetPendingApplications()
        {
            List<Application> apps = new List<Application>();
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Application WHERE status = 'Pending'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                apps.Add(new Application
                {
                    AppId = reader["appId"].ToString(),
                    AidType = reader["aidType"].ToString(),
                    AppDate = reader["appDate"].ToString(),
                    Status = reader["status"].ToString(),
                    Desc = reader["description"].ToString(),
                    TargetAmount = reader["targetAmount"].ToString()
                });
            }
            cmd.Connection.Close();
            return apps;
        }

        public void UpdateApplicationStatus(string appId, string status)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Application SET status = @status WHERE appId = @appId");
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@appId", appId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
