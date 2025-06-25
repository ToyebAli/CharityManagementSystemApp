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
            this.Hide();
            Beneficiary beneficiary = new Beneficiary(login);
            beneficiary.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            EditProfile ep = new EditProfile(login);
            ep.Show();
        }

        private void FAQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faq faq = new Faq(this.login);
            faq.Show();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Us C = new Contact_Us(login);
            C.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volunteer vltr = new Volunteer(login);
            vltr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu(login);
            mn.Show();
        }
    }
}
