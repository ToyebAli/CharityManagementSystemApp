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

namespace CharityManagementSystem.View
{
    public partial class UserListForm: Form
    {
        private Login login;
        public UserListForm(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            LoginController lgc = new LoginController();
            dataGridView.DataSource = lgc.GetAllLogin();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = dataGridView.Rows[e.RowIndex];
                userIdBox.Text = dvr.Cells[0].Value.ToString();
                nameBox.Text = dvr.Cells[1].Value.ToString();
                emailBox.Text = dvr.Cells[2].Value.ToString();
                passwordBox.Text = dvr.Cells[3].Value.ToString();
                phoneBox.Text = dvr.Cells[4].Value.ToString();
                roleBox.Text = dvr.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard ad = new adminDashboard(login);
            ad.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            userIdBox.Clear();
            nameBox.Clear();
            emailBox.Clear();
            phoneBox.Clear();
            roleBox.Clear();
            passwordBox.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = userIdBox.Text;
                string name = nameBox.Text;
                string email = emailBox.Text;
                string phone = phoneBox.Text;
                string role = roleBox.Text;
                string password = passwordBox.Text;
                if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) ||
                     string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                else if (!IsValidPhone(phone))
                {
                    MessageBox.Show("Please enter a valid phone number.");
                    return;
                }

                else if (int.Parse(role) < 1 || int.Parse(role) > 4)
                {
                    MessageBox.Show("Please select a valid role (1-Admin, 2-Donor, 3-Volunteer, 4-Beneficiary).");
                    return;
                }

                else if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.");
                    return;
                }

                else
                {
                    Login login = new Login(userId, name, email, password, phone, int.Parse(role));

                    LoginController lgc = new LoginController();
                    lgc.AddLogin(login);

                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserListForm_Load(sender, e); // Refresh the user list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The User Already Exist: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = userIdBox.Text;
                string name = nameBox.Text;
                string email = emailBox.Text;
                string phone = phoneBox.Text;
                string role = roleBox.Text;
                string password = passwordBox.Text;

                if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) ||
                     string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                else if (!IsValidPhone(phone))
                {
                    MessageBox.Show("Please enter a valid phone number.");
                    return;
                }

                else if(int.Parse(role) < 1 || int.Parse(role) > 4)
                {
                    MessageBox.Show("Please select a valid role (1-Admin, 2-Donor, 3-Volunteer, 4-Beneficiary).");
                    return;
                }

                else if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.");
                    return;
                }

                else
                {
                    Login login = new Login(userId, name, email, password, phone, int.Parse(role));
                    LoginController lgc = new LoginController();
                    lgc.UpdateLogin(login);
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserListForm_Load(sender, e); // Refresh the user list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = userIdBox.Text;
                if (string.IsNullOrWhiteSpace(userId))
                {
                    MessageBox.Show("Please enter a User ID to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    LoginController lgc = new LoginController();
                    lgc.DeleteLogin(userId);
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserListForm_Load(sender, e); // Refresh the user list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginController lgc = new LoginController();
            int selectedRole = 0;

            // Map comboBox1 selection to role
            // Adjust the items in comboBox1 to match these names or use indices as needed
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "All")
            {
                // Show all users
                dataGridView.DataSource = lgc.GetAllLogin();
                return;
            }
            else if (comboBox1.SelectedItem.ToString() == "Admin")
            {
                selectedRole = 1;
            }
            else if (comboBox1.SelectedItem.ToString() == "Donor")
            {
                selectedRole = 2;
            }
            else if (comboBox1.SelectedItem.ToString() == "Beneficiary")
            {
                selectedRole = 3;
            }
            else if (comboBox1.SelectedItem.ToString() == "Volunteer")
            {
                selectedRole = 4;
            }

            // Filter users by role
            var allUsers = lgc.GetAllLogin();
            var filteredUsers = allUsers.Where(u => u.Role == selectedRole).ToList();
            dataGridView.DataSource = filteredUsers;
        }
    }
}
