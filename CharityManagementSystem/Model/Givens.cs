using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Givens
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddGiven(Given given)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Given Values(@camId, @title, @description, @goalAmount, @collectedAmount, @startDate, @endDate, @donationId);");
            cmd.Parameters.AddWithValue("@camId", given.CamId);
            cmd.Parameters.AddWithValue("@title", given.Title);
            cmd.Parameters.AddWithValue("@description", given.Description);
            cmd.Parameters.AddWithValue("@goalAmount", given.GoalAmount);
            cmd.Parameters.AddWithValue("@collectedAmount", given.CollectedAmount);
            cmd.Parameters.AddWithValue("@startDate", given.StartDate);
            cmd.Parameters.AddWithValue("@endDate", given.EndDate);
            cmd.Parameters.AddWithValue("@donationId", given.DonationId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public DataTable GetGivenUserJoinTable()
        {
            SqlCommand cmd = sda.GetQuery(
                "SELECT " +
                "g.camId, g.title, g.description, g.goalAmount, g.collectedAmount, " +
                "g.startDate, g.endDate, g.donationId, " +
                "u.userId, u.name, u.email, u.phoneNumber " +
                "FROM Given g " +
                "INNER JOIN Donation d ON g.donationId = d.donationId " +
                "INNER JOIN Make m ON d.donationId = m.donationId " +
                "INNER JOIN [User] u ON m.userId = u.userId"
            );
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
