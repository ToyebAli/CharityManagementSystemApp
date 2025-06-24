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
    public partial class ProfileForm : Form
    {
        private Login login;
        public ProfileForm(Login login)
        {
            InitializeComponent();
            this.login = login;
            lblWelcome.Text = $"Welcome, {login.Name}!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            EditProfile ep = new EditProfile(login);
            ep.Show();
        }
    }
}
