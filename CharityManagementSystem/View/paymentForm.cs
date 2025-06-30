using CharityManagementSystem.Controller;
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
    public partial class paymentForm : Form
    {
        private Login login;
        private string selectedPaymentMethod;
        private Campaign selectedCampaign;
        public decimal DonatedAmount { get; private set; }

        public paymentForm(Login login, Campaign campaign)
        {
            InitializeComponent();
            this.login = login;
            this.selectedCampaign = campaign;
        }

        private void paymentForm_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty (textBox3.Text))
            {
                MessageBox.Show("Please enter all the fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!decimal.TryParse(textBox1.Text, out _) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(selectedPaymentMethod))
            {
                MessageBox.Show("Please select a payment method.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(textBox2.Text) || !IsValidPhone(textBox2.Text))
            {
                MessageBox.Show("Please enter valid " + selectedPaymentMethod + " Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(textBox3.Text) || textBox3.Text.Length < 4)
            {
                MessageBox.Show("Please enter 4 digits " + selectedPaymentMethod + " Pin", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (decimal.TryParse(textBox1.Text, out decimal amount))
                {
                    string donationId = GenerateDonationrId();
                    string donationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    Donation dn = new Donation 
                    {
                        DonationId = donationId,
                        Amount = amount,
                        PaymentMethod = selectedPaymentMethod,
                        DonationDate = donationDate
                    };
                    DonationController dnc = new DonationController();
                    dnc.AddDonation(dn);

                    Make mk = new Make
                    {
                        DonationId = donationId,
                        Amount = amount,
                        PaymentMethod = selectedPaymentMethod,
                        DonationDate = donationDate,
                        DonorId = login.UserId
                    };
                    MakeController mkc = new MakeController();
                    mkc.AddMake(mk);

                    Given gvn = new Given
                    {
                        CamId = selectedCampaign.CamId,
                        Title = selectedCampaign.Title,
                        Description = selectedCampaign.Description,
                        GoalAmount = selectedCampaign.GoalAmount,
                        CollectedAmount = selectedCampaign.CollectedAmount,
                        StartDate = selectedCampaign.StartDate,
                        EndDate = selectedCampaign.EndDate,
                        DonationId = donationId
                    };
                    GivenController gvc = new GivenController();
                    gvc.AddGiven(gvn);

                    DonatedAmount = amount;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Payment Successful! Thank you for your donation.", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "1000";
        }

        private void lowestAmount_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "5000";
        }

        private void middleAmount_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "10000";
        }

        private void highestAmount_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "20000";
        }

        private void bkash_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod = "Bkash";
        }

        private void nagad_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod = "Nagad";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod = "Upay";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            lowestAmount.Checked = false;
            middleAmount.Checked = false;
            highestAmount.Checked = false;
        }

        private bool IsValidPhone(string phone)
        {
            // Validates Bangladeshi phone numbers: starts with 01, followed by 9 digits (total 11 digits)
            string pattern = @"^01[0-9]{9}$";
            return Regex.IsMatch(phone, pattern);
        }

        private string GenerateDonationrId()
        {
            Random random = new Random();
            int number = random.Next(9999,100000); // Generates a number from 0 to 9999
            return $"DON{number:D5}"; // Pads with leading zeros if necessary
        }
    }
}
