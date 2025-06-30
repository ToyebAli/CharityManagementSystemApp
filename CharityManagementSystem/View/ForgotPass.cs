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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            textBox2.Clear();

            if(textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Your User ID For Generating Password");
            }
            else
            {
                LoginController lgc = new LoginController();
                Login login = lgc.SearchLoginByUserId(userId);
                if (login != null && login.UserId.Equals(userId))
                {
                    //MessageBox.Show("Your Password is: " + login.Password);
                    textBox2.Text = login.Password;
                }
                else
                {
                    MessageBox.Show("Invalid User ID");
                }
            }
        }
    }
}
