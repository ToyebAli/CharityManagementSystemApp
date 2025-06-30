using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharityManagementSystem.Model;
using CharityManagementSystem.Controller;

namespace CharityManagementSystem.View
{
    public partial class ApplicationListForm : Form
    {
        private Login login;
        public ApplicationListForm(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void ApplicationListForm_Load(object sender, EventArgs e)
        {
            LoadPendingApplications();
        }

        private void LoadPendingApplications()
        {
            ApplicationController appController = new ApplicationController();
            List<Model.Application> pendingApps = appController.GetPendingApplications(); // Implement this method

            flowLayoutPanelApplications.Controls.Clear();

            if (pendingApps.Count == 0)
            {
                Label lblNoApp = new Label
                {
                    Text = "No pending applications.",
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                flowLayoutPanelApplications.Controls.Add(lblNoApp);
                return;
            }

            foreach (var app in pendingApps)
            {
                Panel panel = new Panel
                {
                    Width = 400,
                    Height = 150,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                Label lblDetails = new Label
                {
                    Text = $"Aid Type: {app.AidType}\nDate: {app.AppDate}\nReason: {app.Desc}\nNeed Amount: {app.TargetAmount}",
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Button btnAccept = new Button
                {
                    Text = "Accept",
                    Location = new Point(10, 100),
                    Width = 80
                };
                btnAccept.Click += (s, ev) =>
                {
                    appController.UpdateApplicationStatus(app.AppId, "Accepted");

                    // Find the userId of the applicant (you may need to join with Submit table)
                    SubmitController submitController = new SubmitController();
                    string userId = submitController.GetUserIdByAppId(app.AppId); // Implement this method

                    int notificationId = new Random().Next(1000, 10000);

                    // Add notification
                    NotificationController notificationController = new NotificationController();
                    notificationController.AddNotification(new Notification
                    {
                        NotificationId = notificationId,
                        UserId = userId,
                        Message = "Your application has been accepted.",
                        IsRead = false,
                        CreatedAt = DateTime.Now
                    });

                    // Update user role to 3 (Beneficiary)
                    LoginController loginController = new LoginController();
                    var user = loginController.GetAllLogin().FirstOrDefault(u => u.UserId == userId);
                    if (user != null && user.Role != 3)
                    {
                        user.Role = 3;
                        loginController.UpdateLogin(user);
                    }

                    MessageBox.Show("Application accepted.");
                    LoadPendingApplications();
                };

                Button btnReject = new Button
                {
                    Text = "Reject",
                    Location = new Point(100, 100),
                    Width = 80
                };
                btnReject.Click += (s, ev) =>
                {
                    appController.UpdateApplicationStatus(app.AppId, "Rejected");
                    // Find the userId of the applicant (you may need to join with Submit table)
                    SubmitController submitController = new SubmitController();
                    string userId = submitController.GetUserIdByAppId(app.AppId); // Implement this method

                    int notificationId = new Random().Next(1000, 10000);

                    // Add notification
                    NotificationController notificationController = new NotificationController();
                    notificationController.AddNotification(new Notification
                    {
                        NotificationId = notificationId,
                        UserId = userId,
                        Message = "Your application has been Rejected.",
                        IsRead = false,
                        CreatedAt = DateTime.Now
                    });
                    MessageBox.Show("Application rejected.");
                    LoadPendingApplications();
                };

                panel.Controls.Add(lblDetails);
                panel.Controls.Add(btnAccept);
                panel.Controls.Add(btnReject);

                flowLayoutPanelApplications.Controls.Add(panel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard adb = new adminDashboard(login);
            adb.Show();
        }

    }
}
