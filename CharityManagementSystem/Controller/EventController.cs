using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Controller
{
    public class EventController
    {
        public void AddEvent(Event ev)
        {
            Events evs = new Events();
            evs.AddEvent(ev);
        }

        public void UpdateEvent(Event ev)
        {
            Events evs = new Events();
            evs.UpdateEvent(ev);
        }

        public List<Event> GetAllEvents()
        {
            Events evs = new Events();
            List<Event> eventList = evs.GetAllEvents();
            return eventList;
        }

        public void DeleteEvent(string eventId)
        {
            Events evs = new Events();
            evs.DeleteEvent(eventId);
        }
    }
}
