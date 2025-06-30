using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Events
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddEvent(Event e)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Event Values(@eventId, @title, @description, @date, @location);");
            cmd.Parameters.AddWithValue("@eventId", e.EventId);
            cmd.Parameters.AddWithValue("@title", e.Title);
            cmd.Parameters.AddWithValue("@description", e.Description);
            cmd.Parameters.AddWithValue("@date", e.Date);
            cmd.Parameters.AddWithValue("@location", e.Location);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateEvent(Event e)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Event SET title=@title, description=@description, date=@date, location=@location WHERE eventId=@eventId;");
            cmd.Parameters.AddWithValue("@eventId", e.EventId);
            cmd.Parameters.AddWithValue("@title", e.Title);
            cmd.Parameters.AddWithValue("@description", e.Description);
            cmd.Parameters.AddWithValue("@date", e.Date);
            cmd.Parameters.AddWithValue("@location", e.Location);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Event");
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Event e = new Event();
                e.EventId = reader.GetString(0);
                e.Title = reader.GetString(1);
                e.Description = reader.GetString(2);
                e.Date = reader.GetString(3);
                e.Location = reader.GetString(4);
                // Add other fields as needed
                events.Add(e);
            }
            reader.Close();
            cmd.Connection.Close();
            return events;
        }

        public void DeleteEvent(string eventId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Event WHERE eventId=@eventId;");
            cmd.Parameters.AddWithValue("@eventId", eventId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
