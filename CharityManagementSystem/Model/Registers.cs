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
    public class Registers
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddRegister(Register reg)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Register Values(@userId, @eventId);");
            cmd.Parameters.AddWithValue("@userId", reg.UserId);
            cmd.Parameters.AddWithValue("@eventId", reg.EventId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public DataTable GetUserEventApplications()
        {
            SqlCommand cmd = sda.GetQuery(
                "SELECT r.userId, u.name, u.email, u.phoneNumber, r.eventId, e.title AS eventTitle, e.date AS eventDate, e.location " +
                "FROM Register r " +
                "INNER JOIN [User] u ON r.userId = u.userId " +
                "INNER JOIN Event e ON r.eventId = e.eventId"
            );
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void DeleteRegister(string userId, string eventId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Register WHERE userId = @userId AND eventId = @eventId");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@eventId", eventId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
