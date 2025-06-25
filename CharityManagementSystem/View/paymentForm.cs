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

namespace CharityManagementSystem.View
{
    public partial class paymentForm: Form
    {
        private Login login;
        public paymentForm(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void paymentForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(login);
            menu.Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successful! Thank you for your donation.", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
