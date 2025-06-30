using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Controller
{
    public class DonationController
    {
        public void AddDonation(Donation donation)
        {
            Donations dns = new Donations();
            dns.AddDonation(donation);
        }

        public decimal GetTotalDonations()
        {
            Donations dns = new Donations();
            return dns.GetTotalDonations();
        }

        public int GetDonationCount()
        {
            Donations dns = new Donations();
            return dns.GetDonationCount();
        }

        public List<Donation> GetAllDonations()
        {
            Donations dns = new Donations();
            return dns.GetAllDonations();
        }
    }
}
