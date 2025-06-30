using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Donation
    {
        private string donationId;
        private decimal amount;
        private string paymentMethod;
        private string donationDate;

        public Donation() { }

        public Donation(string donationId, decimal amount, string paymentMethod, string donationDate)
        {
            this.donationId = donationId;
            this.amount = amount;
            this.paymentMethod = paymentMethod;
            this.donationDate = donationDate;
        }

        public string DonationId { get => donationId; set => donationId = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public string DonationDate { get => donationDate; set => donationDate = value; }

    }
}
