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
    public class Profiles
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddProfile(Profile profile)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Profile Values(@profileId, @address, @gender, @dob);");
            cmd.Parameters.AddWithValue("@profileId", profile.ProfileId);
            cmd.Parameters.AddWithValue("@address", profile.Address);
            cmd.Parameters.AddWithValue("@gender", profile.Gender);
            cmd.Parameters.AddWithValue("@dob", profile.DateOfBirth);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Profile> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Profile> pfs = new List<Profile>();

            using (reader)
            {
                while (reader.Read())
                {
                    Profile pf = new Profile();
                    pf.ProfileId = reader.GetString(0);
                    pf.Address = reader.GetString(1);
                    pf.Gender = reader.GetString(2);
                    pf.DateOfBirth = reader.GetString(3);

                    pfs.Add(pf);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return pfs;

        }

        public Profile SearchProfile(string profileId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Profile WHERE profileId=@profileId;");
            cmd.Parameters.AddWithValue("@profile", profileId);
            cmd.CommandType = CommandType.Text;
            List<Profile> pfs = GetData(cmd);

            if (pfs.Count > 0)
            {
                return pfs[0];
            }
            else
            {
                return null;
            }
        }
    }
}
