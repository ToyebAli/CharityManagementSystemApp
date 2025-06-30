using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharityManagementSystem.Controller;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.View
{
    public partial class Volunteer : Form
    {
        Login login;
        public Volunteer(Login login)
        {
            InitializeComponent();
            this.login = login;
            if(login.Role == 1) // Assuming 1 is the role for admin
            {
                button2.Visible = true; // Show the button for admin users
            }
            else
            {
                button2.Visible = false; // Hide the button for non-admin users
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(login.Role == 1) // Assuming 1 is the role for admin
            {
                adminDashboard adb = new adminDashboard(login);
                adb.Show();
            }
            else
            {
                ProfileForm pf = new ProfileForm(login);
                pf.Show();
            }
        }

        private void Volunteer_Load(object sender, EventArgs e)
        {
            LoadEvent();
        }

        public void LoadEvent()
        {
            EventController eventRepo = new EventController();
            List<Event> events = eventRepo.GetAllEvents();
            flowLayoutPanelEvents.Controls.Clear();

            if (events.Count == 0)
            {
                Label lblNoEvent = new Label
                {
                    Text = "No Event Available Now.",
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                flowLayoutPanelEvents.Controls.Add(lblNoEvent);
                return;
            }

            foreach (var evnt in events)
            {
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    AutoSize = true,
                };

                Label lblTitle = new Label
                {
                    Text = evnt.Title,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblDesc = new Label
                {
                    Text = evnt.Description,
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                Label lblDates = new Label
                {
                    Text = "Date: " + evnt.Date,
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                Label lblLocation = new Label
                {
                    Text = "Location: " + evnt.Location,
                    Location = new Point(10, 85),
                    AutoSize = true
                };

                Button btnApply = new Button
                {
                    Text = "Apply Now",
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

                btnApply.Click += (s, ev) =>
                {
                    Register reg = new Register
                    {
                        UserId = login.UserId,
                        EventId = evnt.EventId,
                    };
                    RegisterController rgc = new RegisterController();
                    rgc.AddRegister(reg);

                    // Update user role to 4 (Volunteer)
                    if (login.Role != 4)
                    {
                        login.Role = 4;
                        LoginController loginController = new LoginController();
                        loginController.UpdateLogin(login); // Update in database
                    }

                    MessageBox.Show("You have successfully applied for the event!");
                };

                btnDelete.Click += (s, ev) =>
                {
                    // Confirm deletion
                    var result = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        eventRepo.DeleteEvent(evnt.EventId);
                        flowLayoutPanelEvents.Controls.Remove(panel);
                    }
                };

                btnEdit.Click += (s, ev) =>
                {
                    using (AddEvent adv = new AddEvent(login, evnt))
                    {
                        if (adv.ShowDialog() == DialogResult.OK)
                        {
                            LoadEvent(); // Reload campaigns after edit
                        }
                    }
                };

                panel.Controls.Add(lblTitle);
                panel.Controls.Add(lblDesc);
                panel.Controls.Add(lblDates);
                panel.Controls.Add(lblLocation);

                if (login.Role == 1) // Assuming 1 is the role for admin
                {
                    panel.Controls.Add(btnDelete);
                    panel.Controls.Add(btnEdit);
                }
                else
                {
                    panel.Controls.Add(btnApply);
                }

                flowLayoutPanelEvents.Controls.Add(panel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AddEvent adv = new AddEvent(login))
            {
                if (adv.ShowDialog() == DialogResult.OK)
                {
                    LoadEvent(); // Reload campaigns after edit
                }
            }
        }
    }
}
