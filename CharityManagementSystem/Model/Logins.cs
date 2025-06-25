using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CharityManagementSystem.Model
{
    public class Logins
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddLogin(Login login)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO [User] Values(@userId, @name, @email, @password, @phoneNumber, @role);");
            cmd.Parameters.AddWithValue("@userId", login.UserId);
            cmd.Parameters.AddWithValue("@name", login.Name);
            cmd.Parameters.AddWithValue("@email", login.Email);
            cmd.Parameters.AddWithValue("@Password", login.Password);
            cmd.Parameters.AddWithValue("@phoneNumber", login.PhoneNumber);
            cmd.Parameters.AddWithValue("@role", login.Role);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Login> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Login> logins = new List<Login>();

            using (reader)
            {
                while (reader.Read())
                {
                    Login login = new Login();
                    login.UserId = reader.GetString(0);
                    login.Name = reader.GetString(1);
                    login.Email = reader.GetString(2);
                    login.Password = reader.GetString(3);
                    login.PhoneNumber = reader.GetString(4);
                    login.Role = reader.GetInt32(5);

                    logins.Add(login);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return logins;

        }
        public Login SearchLogin(string userId, string password)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM [User] WHERE userId=@userId AND password=@password;");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.CommandType = CommandType.Text;
            List<Login> logins = GetData(cmd);

            if (logins.Count > 0)
            {
                return logins[0];
            }
            else
            {
                return null;
            }
        }

        public void UpdateLogin(Login login)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE [User] SET  name=@name, email=@email, password=@password, phoneNumber = @phoneNumber WHERE userId=@userId;");
            cmd.Parameters.AddWithValue("@userId", login.UserId);
            cmd.Parameters.AddWithValue("@name", login.Name);
            cmd.Parameters.AddWithValue("@email", login.Email);
            cmd.Parameters.AddWithValue("@password", login.Password);
            cmd.Parameters.AddWithValue("@phoneNumber", login.PhoneNumber);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Login> GetAllLogin()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM [User];");
            cmd.CommandType = CommandType.Text;
            List<Login> userList = GetData(cmd);
            return userList;
        }
    }
}
