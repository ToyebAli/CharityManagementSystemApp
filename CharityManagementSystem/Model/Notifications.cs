using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.Model
{
    public class Notifications
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddNotification(Notification notification)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Notification (userId, message, isRead, createdAt) VALUES (@userId, @message, @isRead, @createdAt)");
            cmd.Parameters.AddWithValue("@userId", notification.UserId);
            cmd.Parameters.AddWithValue("@message", notification.Message);
            cmd.Parameters.AddWithValue("@isRead", notification.IsRead);
            cmd.Parameters.AddWithValue("@createdAt", notification.CreatedAt);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Notification> GetUserNotifications(string userId)
        {
            List<Notification> notifications = new List<Notification>();
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Notification WHERE userId = @userId ORDER BY createdAt DESC");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                notifications.Add(new Notification
                {
                    NotificationId = Convert.ToInt32(reader["notificationId"]),
                    UserId = reader["userId"].ToString(),
                    Message = reader["message"].ToString(),
                    IsRead = Convert.ToBoolean(reader["isRead"]),
                    CreatedAt = Convert.ToDateTime(reader["createdAt"])
                });
            }
            cmd.Connection.Close();
            return notifications;
        }

        public void MarkAllAsRead(string userId)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Notification SET isRead = 1 WHERE userId = @userId AND isRead = 0");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
