using CharityManagementSystem.Controller;
using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementSystem.View
{
    public partial class NotificationForm : Form
    {
        private Login login;
        public NotificationForm(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            if (listView1.Columns.Count == 0)
            {
                listView1.View = System.Windows.Forms.View.Details; // Correct namespace for 'View.Details'
                listView1.FullRowSelect = true;
                listView1.Columns.Add("Message", 300);
                listView1.Columns.Add("Date", 150);
                listView1.Columns.Add("Status", 80);
            }

            // Clear previous items
            listView1.Items.Clear();

            // Load notifications
            NotificationController notificationController = new NotificationController();
            var userNotifications = notificationController.GetUserNotifications(login.UserId);

            foreach (var notification in userNotifications)
            {
                var item = new ListViewItem(notification.Message);
                item.SubItems.Add(notification.CreatedAt.ToString("g")); // "g" = general date/time pattern
                item.SubItems.Add(notification.IsRead ? "Read" : "Unread");
                if (!notification.IsRead)
                {
                    item.Font = new Font(item.Font, FontStyle.Bold);
                }
                listView1.Items.Add(item);
            }

            // Mark all as read AFTER displaying
            var notifications = new Notifications();
            notifications.MarkAllAsRead(login.UserId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm pf = new ProfileForm(login);
            pf.ShowDialog();
        }
    }
}
