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

        private void textBox1_TextChanged(object sender, EventArgs e)
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

                Login login = new Login(userId, name,email,password,phoneNumber,1);

                LoginController lgc = new LoginController();
                lgc.AddLogin(login);

                MessageBox.Show("User Added");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
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
    }
}
