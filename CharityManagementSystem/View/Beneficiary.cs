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
using System.Xml.Linq;
using CharityManagementSystem.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CharityManagementSystem.View
{
    public partial class Beneficiary: Form
    {
        private Login login;
        public Beneficiary(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string appId = GenerateAppId();
            string aidType = comboBox1.Text.ToString();
            string appDate = DateTime.Now.ToString();
            string status = "Pending";
            string description = richTextBox1.Text.ToString();
            string targetAmount = textBox1.Text;

            if (string.IsNullOrWhiteSpace(aidType) || string.IsNullOrWhiteSpace(targetAmount) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Validate aidType: must be selected from ComboBox items
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid aid type from the list.");
                return;
            }

            // Validate targetAmount: must contain only numbers and letters
            else if (!System.Text.RegularExpressions.Regex.IsMatch(targetAmount, @"^[A-Za-z0-9]+$"))
            {
                MessageBox.Show("Amount must contain only letters and numbers.");
                return;
            }

            // Validate description: must contain only English letters and spaces
            else if (!System.Text.RegularExpressions.Regex.IsMatch(description, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Description must contain only English letters.");
                return;
            }

            else
            {
                Model.Application newApp = new Model.Application(appId,aidType,appDate,status,description,targetAmount);
                ApplicationController apc = new ApplicationController();
                apc.AddApplication(newApp);

                SubmitController sbc = new SubmitController();
                Submit s = new Submit { AppId = appId, UserId = login.UserId };
                sbc.AddSubmit(s);

                MessageBox.Show("Your application is submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ProfileForm profileForm = new ProfileForm(login);
                profileForm.ShowDialog();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(login);
            profileForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string GenerateAppId()
        {
            Random random = new Random();
            int number = random.Next(0, 10000); // Generates a number from 0 to 9999
            return $"APP{number:D4}"; // Pads with leading zeros if necessary
        }
    }
}
