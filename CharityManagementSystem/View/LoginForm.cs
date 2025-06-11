using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharityManagementSystem.Controller;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string password = textBox2.Text;

            if(userId == "" || password == "")
            {
                MessageBox.Show("Please Enter Your Username and Password");
            }

            else
            {
                LoginController lgc = new LoginController();
                Login login = lgc.SearchLogin(userId, password);

                if (login != null && login.UserId.Equals(userId) && login.Password.Equals(password))
                {
                    MessageBox.Show("Welcome " + login.Name);
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password ");
                }
            }
        }
    }
}
