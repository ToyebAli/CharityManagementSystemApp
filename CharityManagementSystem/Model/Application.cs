using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Application
    {
        private string appId;
        private string aidType;
        private string appDate;
        private string status;
        private string desc;
        private string targetAmount;

        public Application() { }

        public Application(string appId, string aidType, string appDate, string status, string desc, string targetAmount)
        {
            this.appId = appId;
            this.aidType = aidType;
            this.appDate = appDate;
            this.status = status;
            this.desc = desc;
            this.targetAmount = targetAmount;
        }

        public string AppId { get => appId; set => appId = value; }

        public string AidType { get => aidType; set => aidType = value; }

        public string AppDate { get => appDate; set => appDate = value; }

        public string Status { get => status; set => status = value; }

        public string Desc { get => desc; set => desc = value; }

        public string TargetAmount { get => targetAmount; set => targetAmount = value; }

        }
}
