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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CharityManagementSystem.View
{
    public partial class ResigstrationForm: Form
    {
        public ResigstrationForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegistor_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = Guid.NewGuid().ToString(); // Generate a unique user ID
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phoneNumber = txtPhone.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                else if (!IsValidName(name))
                {
                    nameIsValidLabel.Text = "Please enter a valid name.";
                    return;
                }

                else if (!IsValidEmail(email))
                {
                    emailIsValidLabel.Text = "Please enter a valid email address.";
                    return;
                }
                
                else if (!IsValidPhone(phoneNumber))
                {
                    phoneIsValidLabel.Text = "Please enter a valid phone number.";
                    return;
                }

                else if (password.Length < 6)
                {
                    passwordIsValidLabel.Text = "Password must be at least 6 characters long.";
                    return;
                }

                else if (password != confirmPassword)
                {
                    confirmPassIsValidLabel.Text = "Passwords do not match.";
                    return;
                }

                else
                {
                    nameIsValidLabel.Text = string.Empty;
                    emailIsValidLabel.Text = string.Empty;
                    phoneIsValidLabel.Text = string.Empty;
                    passwordIsValidLabel.Text = string.Empty;
                    confirmPassIsValidLabel.Text = string.Empty;

                    LoginController loginController = new LoginController();
                    Login newLogin = new Login
                    {
                        UserId = userId,
                        Name = name,
                        Email = email,
                        PhoneNumber = phoneNumber,
                        Password = password,
                        Role = 2 // Assuming 2 is the role for a donor
                    };
                    bool isRegistered = loginController.AddLogin(newLogin);
                    if (isRegistered)
                    {
                        MessageBox.Show("Registration successful! You can now log in.");
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }

                    //Login login = new Login(userId, name, email, password, phoneNumber, 1);

                    //LoginController lgc = new LoginController();
                    //lgc.AddLogin(login);

                    //MessageBox.Show("User Added");
                    //this.Hide();
                    //LoginForm loginForm = new LoginForm();
                    //loginForm.ShowDialog();
                }

            }

            catch (Exception x)
            {
                MessageBox.Show(x.StackTrace);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ResigstrationForm_Load(object sender, EventArgs e)
        {

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

        private bool IsValidPhone(string phone)
        {
            // Validates Bangladeshi phone numbers: starts with 01, followed by 9 digits (total 11 digits)
            string pattern = @"^01[0-9]{9}$";
            return Regex.IsMatch(phone, pattern);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
