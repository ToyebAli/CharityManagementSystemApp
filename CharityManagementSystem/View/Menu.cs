using CharityManagementSystem.Controller;
using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementSystem.View
{
    public partial class Menu : Form
    {
        private Login login;
        public Menu(Login login)
        {
            InitializeComponent();
            this.login = login;
            if (login.Role == 1) // Admin role
            {
                button1.Visible = true; // Show Add Campaign button
            }
            else
            {
                button1.Visible = false; // Hide Add Campaign button for users
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadCampaigns();
        }

        private void LoadCampaigns()
        {
            CampaignController cpc = new CampaignController();
            List<Campaign> campaigns = cpc.GetAllCampaigns();
            flowLayoutPanelCampaigns.Controls.Clear();

            if (campaigns.Count == 0)
            {
                Label lblNoCampaign = new Label
                {
                    Text = "No campaign available now.",
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                flowLayoutPanelCampaigns.Controls.Add(lblNoCampaign);
                return;
            }

            foreach (var campaign in campaigns)
            {
                Panel panel = new Panel
                {
                    Width = 350,
                    Height = 170,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    Tag = campaign // Store campaign in Tag for later use
                };

                Label lblTitle = new Label
                {
                    Text = campaign.Title,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblDesc = new Label
                {
                    Text = campaign.Description,
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                Label lblDates = new Label
                {
                    Text = $"Dates: {campaign.StartDate} - {campaign.EndDate}",
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                Label lblNeedAmount = new Label
                {
                    Text = "Need Amount: " + campaign.GoalAmount,
                    Location = new Point(10, 85),
                    AutoSize = true
                };

                Label lblCollectedAmount = new Label
                {
                    Text = "Collected Amount: " + campaign.CollectedAmount,
                    Location = new Point(10, 110),
                    AutoSize = true,
                    Name = "lblCollectedAmount"
                };

                Button btnDonate = new Button
                {
                    Text = "Donate Now",
                    Location = new Point(10, 135),
                    Width = 120
                };

                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Location = new Point(10, 135),
                    Width = 120
                };

                Button btnEdit = new Button
                {
                    Text = "Edit",
                    Location = new Point(150, 135),
                    Width = 120
                };

                btnDonate.Click += (s, ev) =>
                {
                    // Open payment form and pass campaign
                    using (var payment = new paymentForm(login, campaign))
                    {
                        if (payment.ShowDialog() == DialogResult.OK)
                        {
                            // After donation, update collected amount label and database
                            decimal donated = payment.DonatedAmount;
                            campaign.CollectedAmount += donated;
                            lblCollectedAmount.Text = "Collected Amount: " + campaign.CollectedAmount;
                            // Update in database
                            cpc.UpdateCollectedAmount(campaign.CamId, campaign.CollectedAmount);
                        }
                    }
                };

                btnDelete.Click += (s, ev) =>
                {
                    // Confirm deletion
                    var result = MessageBox.Show("Are you sure you want to delete this campaign?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cpc.DeleteCampaign(campaign.CamId);
                        flowLayoutPanelCampaigns.Controls.Remove(panel);
                    }
                };

                btnEdit.Click += (s, ev) =>
                {
                    using (AddCampaign adc = new AddCampaign(login, campaign))
                    {
                        if (adc.ShowDialog() == DialogResult.OK)
                        {
                            LoadCampaigns(); // Reload campaigns after edit
                        }
                    }
                };

                panel.Controls.Add(lblTitle);
                panel.Controls.Add(lblDesc);
                panel.Controls.Add(lblDates);
                panel.Controls.Add(lblNeedAmount);
                panel.Controls.Add(lblCollectedAmount);

                if (login.Role == 1) // Admin role
                {
                    panel.Controls.Add(btnDelete);
                    panel.Controls.Add(btnEdit);
                }
                else // User role
                {
                    panel.Controls.Add(btnDonate);
                }

                flowLayoutPanelCampaigns.Controls.Add(panel);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(login.Role != 1)
            {
                ProfileForm pf = new ProfileForm(login);
                pf.Show();
            }
            else
            {
                adminDashboard adb = new adminDashboard(login);
                adb.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddCampaign adc = new AddCampaign(login))
            {
                if (adc.ShowDialog() == DialogResult.OK)
                {
                    LoadCampaigns(); // Reload campaigns after edit
                }
            }
        }
    }
}
