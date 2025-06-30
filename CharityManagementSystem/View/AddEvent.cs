using CharityManagementSystem.Controller;
using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CharityManagementSystem.View
{
    public partial class AddEvent : Form
    {
        private Login login;
        private Event evnt;
        private bool flag = false;
        public AddEvent(Login login, Event evnt)
        {
            InitializeComponent();
            this.login = login;
            this.evnt = evnt;
            textBox1.Text = evnt.Title;
            richTextBox1.Text = evnt.Description;
            textBox2.Text = evnt.Location;
            // Fix for CS0029: Convert the string StartDate to DateTime using DateTime.ParseExact
            dateTimePicker1.Value = DateTime.ParseExact(evnt.Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public AddEvent(Login login)
        {
            InitializeComponent();
            this.login = login;
            flag = true;
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Text = "Add Event";
                button1.Text = "Add Event";
            }
            else
            {
                this.Text = "Update Event";
                button1.Text = "Apply Changes";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string description = richTextBox1.Text.Trim();
            string location = textBox2.Text.Trim();
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(title, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Enter a Valid Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(description, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Enter a Valid Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((!System.Text.RegularExpressions.Regex.IsMatch(location, @"^[A-Za-z0-9\s]+$")))
            {
                MessageBox.Show("Enter a Valid Location", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("The event date cannot be in the past.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (flag)
            {
                // Add new event
                Event newEvent = new Event
                {
                    EventId = GenerateEventId(),
                    Title = title,
                    Description = description,
                    Location = location,
                    Date = date
                };
                EventController eventController = new EventController();
                eventController.AddEvent(newEvent);
                MessageBox.Show("Event added successfully.");
            }
            else
            {
                // Update existing event
                evnt.Title = title;
                evnt.Description = description;
                evnt.Location = location;
                evnt.Date = date;
                EventController eventController = new EventController();
                eventController.UpdateEvent(evnt);
                MessageBox.Show("Event updated successfully.");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private string GenerateEventId()
        {
            Random random = new Random();
            int number = random.Next(0, 10000); // Generates a number from 0 to 9999
            return $"EVN{number:D4}"; // Pads with leading zeros if necessary
        }

        
    }
}
