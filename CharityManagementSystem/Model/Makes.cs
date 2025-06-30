using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Makes
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddMake(Make make)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Make Values(@donationId, @amount, @paymentMethod, @donationDate, @userId);");
            cmd.Parameters.AddWithValue("@donationId", make.DonationId);
            cmd.Parameters.AddWithValue("@amount", make.Amount);
            cmd.Parameters.AddWithValue("@paymentMethod", make.PaymentMethod);
            cmd.Parameters.AddWithValue("@donationDate", make.DonationDate);
            cmd.Parameters.AddWithValue("@userId", make.DonorId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public DataTable GetMakeUserJoinTable()
        {
            SqlCommand cmd = sda.GetQuery(
                "SELECT m.donationId, m.amount, m.paymentMethod, m.donationDate, m.userId, u.name, u.email, u.phoneNumber " +
                "FROM Make m INNER JOIN [User] u ON m.userId = u.userId"
            );
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
