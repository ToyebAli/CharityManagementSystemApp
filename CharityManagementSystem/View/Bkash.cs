using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementSystem.View
{
    public partial class Bkash : Form
    {
        private Login login;
        public Bkash(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter Number and PIN", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!IsValidPhone(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid Bangladeshi phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Length < 4)
            {
                MessageBox.Show("PIN must be at least 4 digits long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Payment Successful! Thank you for your donation.", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu menu = new Menu(login);
                menu.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentForm paymentForm = new paymentForm(login);
            paymentForm.ShowDialog();
        }

        private bool IsValidPhone(string phone)
        {
            // Validates Bangladeshi phone numbers: starts with 01, followed by 9 digits (total 11 digits)
            string pattern = @"^01[0-9]{9}$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}
