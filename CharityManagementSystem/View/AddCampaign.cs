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
using System.Globalization;

namespace CharityManagementSystem.View
{
    public partial class AddCampaign : Form
    {
        private Login login;
        private Campaign campaign;
        private bool flag = false;
        public AddCampaign(Login login, Campaign campaign)
        {
            InitializeComponent();
            this.login = login;
            this.campaign = campaign;
            textBox1.Text = campaign.Title;
            richTextBox1.Text = campaign.Description;
            textBox2.Text = campaign.GoalAmount.ToString();
            textBox3.Text = campaign.CollectedAmount.ToString();
            // Fix for CS0029: Convert the string StartDate to DateTime using DateTime.ParseExact
            dateTimePicker1.Value = DateTime.ParseExact(campaign.StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public AddCampaign(Login login)
        {
            InitializeComponent();
            this.login = login;
            flag = true;
        }

        private void AddCampaign_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Text = "Add Campaign";
                button2.Text = "Add Campaign";
            }
            else
            {
                this.Text = "Update Campaign";
                button2.Text = "Apply Changes";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Enter a Valid Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox1.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Enter a Valid Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate textBox2 and textBox3: only numbers
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^\d+$"))
            {
                MessageBox.Show("Goal Amount must contain only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^\d+$"))
            {
                MessageBox.Show("Collected Amount must contain only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("The campaign end date cannot be in the past.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if(flag)
                {   // Create a new Campaign object
                    Campaign newCampaign = new Campaign
                    {
                        CamId = GenerateCamId(), // Generate a new Campaign ID
                        Title = textBox1.Text,
                        Description = richTextBox1.Text,
                        GoalAmount = decimal.Parse(textBox2.Text),
                        CollectedAmount = decimal.Parse(textBox3.Text),
                        StartDate = DateTime.Now.ToString("yyyy-MM-dd"),
                        EndDate = dateTimePicker1.Value.ToString("yyyy-MM-dd")
                    };
                    // Add the new campaign using the CampaignController
                    CampaignController campaignController = new CampaignController();
                    campaignController.AddCampaign(newCampaign);
                    MessageBox.Show("Campaign added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Set the dialog result to OK
                    this.Close(); // Close the form after adding
                }
                else
                {
                    // Update the existing campaign
                    campaign.Title = textBox1.Text;
                    campaign.Description = richTextBox1.Text;
                    campaign.GoalAmount = decimal.Parse(textBox2.Text);
                    campaign.CollectedAmount = decimal.Parse(textBox3.Text);
                    campaign.EndDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    // Update the campaign using the CampaignController
                    CampaignController campaignController = new CampaignController();
                    campaignController.UpdateCampaign(campaign);
                    MessageBox.Show("Campaign updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Set the dialog result to OK
                    this.Close(); // Close the form after updating
                }
            }
        }

        private string GenerateCamId()
        {
            Random random = new Random();
            int number = random.Next(0, 10000); // Generates a number from 0 to 9999
            return $"CAM{number:D4}"; // Pads with leading zeros if necessary
        }
    }
}
