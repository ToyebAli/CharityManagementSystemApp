using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Campaigns
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddCampaign(Campaign cam)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Campaign Values(@camId,@title,@description,@goalAmount,@collectedAmount,@startDate,@endDate);");
            cmd.Parameters.AddWithValue("@camId", cam.CamId);
            cmd.Parameters.AddWithValue("@title", cam.Title);
            cmd.Parameters.AddWithValue("@description", cam.Description);
            cmd.Parameters.AddWithValue("@goalAmount", cam.GoalAmount);
            cmd.Parameters.AddWithValue("@collectedAmount", cam.CollectedAmount);
            cmd.Parameters.AddWithValue("@startDate", cam.StartDate);
            cmd.Parameters.AddWithValue("@endDate", cam.EndDate);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Campaign> GetAllCampaigns()
        {
            List<Campaign> campaigns = new List<Campaign>();
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Campaign");
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Campaign c = new Campaign();
                c.CamId = reader.GetString(0);
                c.Title = reader.GetString(1);
                c.Description = reader.GetString(2);
                c.GoalAmount = reader.GetDecimal(3);
                c.CollectedAmount = reader.GetDecimal(4);
                c.StartDate = reader.GetString(5);
                c.EndDate = reader.GetString(6);
                // Add other fields as needed
                campaigns.Add(c);
            }
            reader.Close();
            cmd.Connection.Close();
            return campaigns;
        }

        public void UpdateCampaign(Campaign cam)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Campaign SET  title=@title, description=@description, goalAmount = @goalAmount, collectedAmount = @collectedAmount, endDate = @endDate WHERE camId=@camId;");
            cmd.Parameters.AddWithValue("@camId", cam.CamId);
            cmd.Parameters.AddWithValue("@title", cam.Title);
            cmd.Parameters.AddWithValue("@description", cam.Description);
            cmd.Parameters.AddWithValue("@goalAmount", cam.GoalAmount);
            cmd.Parameters.AddWithValue("@collectedAmount", cam.CollectedAmount);
            cmd.Parameters.AddWithValue("@endDate", cam.EndDate);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateCollectedAmount(string camId, decimal newCollectedAmount)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Campaign SET collectedAmount = @collected WHERE camId = @id");
            cmd.Parameters.AddWithValue("@collected", newCollectedAmount);
            cmd.Parameters.AddWithValue("@id", camId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteCampaign(string camId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Campaign WHERE camId=@camId;");
            cmd.Parameters.AddWithValue("@camId", camId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
