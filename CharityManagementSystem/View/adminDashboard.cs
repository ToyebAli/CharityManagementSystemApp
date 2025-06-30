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
    public partial class adminDashboard: Form
    {
        private Login login;
        private int isButtonClicked = 0; // Variable to track button clicks
        public adminDashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
            userShow.Text = $"User {login.Name}";
        }

        private void adminDasboard_Load(object sender, EventArgs e)
        {
            // Clear existing controls if needed
            flowLayoutPanelDashboard.Controls.Clear();

            // --- Volunteering Events Panel ---
            EventController eventController = new EventController();
            List<Event> events = eventController.GetAllEvents();
            int eventCount = events.Count;

            Panel panelEvents = new Panel
            {
                Width = 250,
                Height = 120,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblEventsTitle = new Label
            {
                Text = "Volunteering Events",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblEventsCount = new Label
            {
                Text = $"Total Event: {eventCount}",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Location = new Point(10, 40),
                AutoSize = true
            };

            Button btnViewEvents = new Button
            {
                Text = "View Events",
                Location = new Point(10, 70),
                Width = 120
            };
            btnViewEvents.Click += (s, ev) =>
            {
                this.Hide();
                Volunteer volunteerForm = new Volunteer(login); // Pass login if needed
                volunteerForm.ShowDialog();
            };

            panelEvents.Controls.Add(lblEventsTitle);
            panelEvents.Controls.Add(lblEventsCount);
            panelEvents.Controls.Add(btnViewEvents);

            // --- Ongoing Campaigns Panel ---
            CampaignController campaignController = new CampaignController();
            List<Campaign> campaigns = campaignController.GetAllCampaigns();
            int campaignCount = campaigns.Count;

            Panel panelCampaigns = new Panel
            {
                Width = 250,
                Height = 120,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblCampaignsTitle = new Label
            {
                Text = "Ongoing Campaigns",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblCampaignsCount = new Label
            {
                Text = $"Total Campaign: {campaignCount}",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Location = new Point(10, 40),
                AutoSize = true
            };

            Button btnViewCampaigns = new Button
            {
                Text = "View Campaigns",
                Location = new Point(10, 70),
                Width = 120
            };
            btnViewCampaigns.Click += (s, ev) =>
            {
                this.Hide();
                Menu menuForm = new Menu(login); // Pass login if needed
                menuForm.ShowDialog();
            };

            panelCampaigns.Controls.Add(lblCampaignsTitle);
            panelCampaigns.Controls.Add(lblCampaignsCount);
            panelCampaigns.Controls.Add(btnViewCampaigns);

            // --- Donation Statistics Panel ---
            DonationController donationController = new DonationController();
            decimal totalDonations = donationController.GetTotalDonations();
            int donationCount = donationController.GetDonationCount();

            Panel panelDonations = new Panel
            {
                Width = 250,
                Height = 120,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblDonationsTitle = new Label
            {
                Text = "Donation Statistics",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblTotalDonations = new Label
            {
                Text = $"Total Amount: {totalDonations} BDT",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Location = new Point(10, 40),
                AutoSize = true
            };

            Label lblDonationCount = new Label
            {
                Text = $"Total Donations: {donationCount}",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Location = new Point(10, 65),
                AutoSize = true
            };

            Button btnViewDonations = new Button
            {
                Text = "View Donations",
                Location = new Point(10, 90),
                Width = 120
            };
            btnViewDonations.Click += (s, ev) =>
            {
                this.Hide();
                DonationListForm donationListForm = new DonationListForm(login);
                donationListForm.ShowDialog();
            };

            panelDonations.Controls.Add(btnViewDonations);
            panelDonations.Controls.Add(lblDonationsTitle);
            panelDonations.Controls.Add(lblTotalDonations);
            panelDonations.Controls.Add(lblDonationCount);

            // --- Application Request Panel ---
            ApplicationController applicationController = new ApplicationController();
            int pendingAppCount = applicationController.GetPendingApplicationCount();

            Panel panelApplications = new Panel
            {
                Width = 250,
                Height = 120,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblApplicationsTitle = new Label
            {
                Text = "Beneficiary Application Request",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblPendingAppCount = new Label
            {
                Text = $"Pending: {pendingAppCount}",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Location = new Point(10, 40),
                AutoSize = true
            };

            Button btnViewApplications = new Button
            {
                Text = "View",
                Location = new Point(10, 70),
                Width = 120
            };
            btnViewApplications.Click += (s, ev) =>
            {
                using (var appListForm = new ApplicationListForm(login))
                {
                    this.Hide();
                    appListForm.ShowDialog();
                }
            };

            panelApplications.Controls.Add(lblApplicationsTitle);
            panelApplications.Controls.Add(lblPendingAppCount);
            panelApplications.Controls.Add(btnViewApplications);

            // Add panels to the flowLayoutPanel
            flowLayoutPanelDashboard.Controls.Add(panelEvents);
            flowLayoutPanelDashboard.Controls.Add(panelCampaigns);
            flowLayoutPanelDashboard.Controls.Add(panelDonations);
            flowLayoutPanelDashboard.Controls.Add(panelApplications);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void viewlistbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserListForm userListForm = new UserListForm(login);
            userListForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonationRecordForm drf = new DonationRecordForm(login,1);
            drf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonationRecordForm drf = new DonationRecordForm(login, 2);
            drf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonationRecordForm drf = new DonationRecordForm(login, 3);
            drf.ShowDialog();
        }
    }
}
