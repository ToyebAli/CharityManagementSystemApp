using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Given
    {
        private string camId;
        private string title;
        private string description;
        private decimal goalAmount;
        private decimal collectedAmount;
        private string startDate;
        private string endDate;
        private string donationId;

        public Given() { }

        public Given(string camId, string title, string description, decimal goalAmount, decimal collectedAmount, string startDate, string endDate,string donationId)
        {
            this.camId = camId;
            this.title = title;
            this.description = description;
            this.goalAmount = goalAmount;
            this.collectedAmount = collectedAmount;
            this.startDate = startDate;
            this.endDate = endDate;
            this.donationId = donationId;
        }

        public string CamId { get => camId; set => camId = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public decimal GoalAmount { get => goalAmount; set => goalAmount = value; }
        public decimal CollectedAmount { get => collectedAmount; set => collectedAmount = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string DonationId { get => donationId; set => donationId = value; }

    }
}
