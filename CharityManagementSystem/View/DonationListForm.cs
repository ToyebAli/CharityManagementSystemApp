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
    public partial class DonationListForm : Form
    {
        private Login login;
        public DonationListForm(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void DonationListForm_Load(object sender, EventArgs e)
        {
            DonationController donationController = new DonationController();
            // You may want to add a method to get all donations as a list
            List<Donation> donations = donationController.GetAllDonations();
            dataGridView1.DataSource = donations;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard adb = new adminDashboard(login);
            adb.Show();
        }
    }
}
