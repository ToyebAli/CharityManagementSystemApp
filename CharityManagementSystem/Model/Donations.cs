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
    public class Donations
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public void AddDonation(Donation donation)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Donation Values(@donationId, @amount, @paymentMethod, @donationDate);");
            cmd.Parameters.AddWithValue("@donationId", donation.DonationId);
            cmd.Parameters.AddWithValue("@amount", donation.Amount);
            cmd.Parameters.AddWithValue("@paymentMethod", donation.PaymentMethod);
            cmd.Parameters.AddWithValue("@donationDate", donation.DonationDate);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public decimal GetTotalDonations()
        {
            SqlCommand cmd = sda.GetQuery("SELECT ISNULL(SUM(amount), 0) FROM Donation");
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            decimal total = (decimal)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return total;
        }

        public int GetDonationCount()
        {
            SqlCommand cmd = sda.GetQuery("SELECT COUNT(*) FROM Donation");
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return count;
        }

        public List<Donation> GetAllDonations()
        {
            List<Donation> donations = new List<Donation>();
            SqlCommand cmd = sda.GetQuery("SELECT donationId, amount, paymentMethod, donationDate FROM Donation");
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                donations.Add(new Donation
                {
                    DonationId = reader["donationId"].ToString(),
                    Amount = Convert.ToDecimal(reader["amount"]),
                    PaymentMethod = reader["paymentMethod"].ToString(),
                    DonationDate = reader["donationDate"].ToString()
                });
            }
            cmd.Connection.Close();
            return donations;
        }
    }
}
