using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.Controller
{
    public class NotificationController
    {
        public void AddNotification(Notification notification)
        {
            Notifications notifications = new Notifications();
            notifications.AddNotification(notification);
        }
        public List<Notification> GetUserNotifications(string userId)
        {
            Notifications notifications = new Notifications();
            return notifications.GetUserNotifications(userId);
        }
    }
}
