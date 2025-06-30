using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Register
    {
        private string userId;
        private string eventId;

        public Register()
        {
        }

        public Register(string userId, string eventId)
        {
            this.userId = userId;
            this.eventId = eventId;
        }

        public string UserId { get => userId; set => userId = value; }
        public string EventId { get => eventId; set => eventId = value; }
    }
}
