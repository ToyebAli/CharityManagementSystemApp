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
        private string selectedPaymentMethod;
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
            if(selectedPaymentMethod == "Bkash")
            {   
                if(string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    Bkash bkash = new Bkash(login);
                    bkash.ShowDialog();
                }
            }
            else if(selectedPaymentMethod == "Nagad")
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    Nagad nagad = new Nagad(login);
                    nagad.ShowDialog();
                }
            }
            else if(selectedPaymentMethod == "Upay")
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    Upay upay = new Upay(login);
                    upay.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "1000"; // Default amount for radio button 1
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
    }
}
