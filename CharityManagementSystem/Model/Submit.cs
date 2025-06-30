using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Submit
    {
        private string appId;
        private string userId;

        public Submit()
        {
        }

        public Submit(string appId, string userId)
        {
            this.appId = appId;
            this.userId = userId;
        }

        public string AppId { get => appId; set => appId = value; }
        public string UserId { get => userId; set => userId = value; }
    }
}
