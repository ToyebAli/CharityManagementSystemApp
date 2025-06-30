using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Make
    {
        private string donationId;
        private decimal amount;
        private string paymentMethod;
        private string donationDate;
        private string donorId;

        public Make() { }

        public Make(string donationId, decimal amount, string paymentMethod, string donationDate, string donorId)
        {
            this.donationId = donationId;
            this.amount = amount;
            this.paymentMethod = paymentMethod;
            this.donationDate = donationDate;
            this.donorId = donorId;
        }

        public string DonationId { get => donationId; set => donationId = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public string DonationDate { get => donationDate; set => donationDate = value; }
        public string DonorId { get => donorId; set => donorId = value; }
    }
}
