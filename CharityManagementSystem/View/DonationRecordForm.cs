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
    public partial class DonationRecordForm : Form
    {
        private Login login;
        private int isButtonClicked = 0;
        public DonationRecordForm(Login login,int buttonClicked)
        {
            InitializeComponent();
            this.login = login;
            isButtonClicked = buttonClicked;
            if(buttonClicked == 3)
            {
                button2.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonationRecordForm_Load(object sender, EventArgs e)
        {
            if(isButtonClicked == 1)
            {
                MakeController mkc = new MakeController();
                dataGridView1.DataSource = mkc.GetMakeUserJoinTable();
            }
            else if(isButtonClicked == 2)
            {
                GivenController gvc = new GivenController();
                dataGridView1.DataSource = gvc.GetGivenUserJoinTable();
            }
            else if(isButtonClicked == 3)
            {
                RegisterController regController = new RegisterController();
                dataGridView1.DataSource = regController.GetUserEventApplications();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard adb = new adminDashboard(login);
            adb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string userId = selectedRow.Cells["userId"].Value.ToString();
                string eventId = selectedRow.Cells["eventId"].Value.ToString();

                RegisterController regController = new RegisterController();
                regController.DeleteRegister(userId, eventId);

                MessageBox.Show("Registration rejected and deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                dataGridView1.DataSource = regController.GetUserEventApplications();


                int notificationId = new Random().Next(1000, 10000);

                // Add notification
                NotificationController notificationController = new NotificationController();
                notificationController.AddNotification(new Notification
                {
                    NotificationId = notificationId,
                    UserId = userId,
                    Message = "Your registration has been rejected.",
                    IsRead = false,
                    CreatedAt = DateTime.Now
                });
            }
            else
            {
                MessageBox.Show("Please select a registration to reject.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
