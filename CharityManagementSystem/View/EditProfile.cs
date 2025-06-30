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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CharityManagementSystem.View
{
    public partial class EditProfile : Form
    {
        private Login login;
        bool isModified = false;
        private bool isDateTimePickerModified = false;
        private DateTime initialDate;

        public EditProfile(Login login)
        {
            InitializeComponent();
            this.login = login;
            textBox1.Text = login.UserId;
            textBox2.Text = login.Name;
            textBox6.Text = login.Email;
            textBox7.Text = login.PhoneNumber;
            textBox8.Text = login.Password;
            textBox1.Enabled = false;

            // Attach event handlers for TextChanged events
            textBox2.TextChanged += TextBox_TextChanged;
            textBox3.TextChanged += TextBox_TextChanged;
            textBox5.TextChanged += TextBox_TextChanged;
            textBox6.TextChanged += TextBox_TextChanged;
            textBox7.TextChanged += TextBox_TextChanged;
            textBox8.TextChanged += TextBox_TextChanged;
        }

        private void ListBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            initialDate = dateTimePicker1.Value;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm pf = new ProfileForm(this.login);
            pf.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if textBox2 or textBox3 has been modified
                if (textBox2.Modified || textBox6.Modified || textBox7.Modified || textBox8.Modified)
                {
                    // Perform necessary actions if modified
                    string userId = textBox1.Text;
                    string name = textBox2.Text;
                    string email = textBox6.Text;
                    string phoneNumber = textBox7.Text;
                    string password = textBox8.Text;
                    string confirmPassword = textBox9.Text;

                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                    else if (!IsValidName(name))
                    {
                        MessageBox.Show("Please enter a valid name.");
                        return;
                    }

                    else if (!IsValidEmail(email))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }

                    else if (!IsValidPhone(phoneNumber))
                    {
                        MessageBox.Show("Please enter a valid phone number.");
                        return;
                    }

                    else if (password.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters long.");
                        return;
                    }

                    else if (password != confirmPassword)
                    {
                        MessageBox.Show("Passwords do not match.");
                        return;
                    }

                    else
                    {
                        Login login = new Login(userId, name, email, password, phoneNumber, 2);

                        LoginController lgc = new LoginController();
                        lgc.UpdateLogin(login);
                        MessageBox.Show("Profile Updated Successfully!");
                    }
                }
                else if (textBox3.Modified || isDateTimePickerModified || textBox5.Modified || isModified)
                {
                    string profileId = textBox5.Text;
                    string address = textBox3.Text;
                    string dob = dateTimePicker1.Text.ToString();
                    string gender = comboBox1.Text;

                    if (string.IsNullOrWhiteSpace(profileId) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(dob) || string.IsNullOrWhiteSpace(gender))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                    else if (!IsValidAddress(address))
                    {
                        MessageBox.Show("Please enter a valid address.");
                        return;
                    }

                    //else if (!IsValidDate(dob))
                    //{
                    //    MessageBox.Show("Please enter in Date format (yyyy-MM-dd).");
                    //    return;
                    //}

                    else
                    {
                        ProfileController pfc = new ProfileController();
                        Profile newProfile = new Profile(profileId, address, dob, gender);

                        pfc.AddProfile(newProfile);
                        MessageBox.Show("Profile Updated Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please update any field.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Id Must be Unique: " + ex.Message);
            }
        }

        // Event handler for TextChanged events
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes if needed
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidName(string name)
        {
            // Allows letters (upper/lower), spaces, hyphens, and apostrophes, at least 3 characters
            string pattern = @"^[A-Za-z\s'-]{3,}$";
            return Regex.IsMatch(name, pattern);
        }

        private bool IsValidAddress(string address)
        {
            // Allows letters (upper/lower), spaces, hyphens, and apostrophes, at least 3 characters
            string pattern = @"^[A-Za-z\s'-]{3,}$";
            return Regex.IsMatch(address, pattern);
        }

        private bool IsValidPhone(string phone)
        {
            // Validates Bangladeshi phone numbers: starts with 01, followed by 9 digits (total 11 digits)
            string pattern = @"^01[0-9]{9}$";
            return Regex.IsMatch(phone, pattern);
        }

        private bool IsValidDate(string date)
        {
            // Matches dates in yyyy-MM-dd format, years 1900-2099, months 01-12, days 01-31
            string pattern = @"^(19|20)\d\d-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$";
            return Regex.IsMatch(date, pattern);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            isDateTimePickerModified = (dateTimePicker1.Value != initialDate);
        }
    }
}
