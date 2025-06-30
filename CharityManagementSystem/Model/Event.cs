using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Event
    {
        private string eventId;
        private string title;
        private string description;
        private string date;
        private string location;

        public Event()
        {

        }

        public Event(string eventId, string title, string description, string date, string location)
        {
            this.eventId = eventId;
            this.title = title;
            this.description = description;
            this.date = date;
            this.location = location;
        }

        public string EventId { get => eventId; set => eventId = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Date { get => date; set => date = value; }
        public string Location { get => location; set => location = value; }

    }
}
