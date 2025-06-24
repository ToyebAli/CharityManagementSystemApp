using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementSystem.View
{
    public partial class ProfileForm : Form
    {
        private string name;
        public ProfileForm(string name)
        {
            InitializeComponent();
            this.name = name;
            lblWelcome.Text = $"Welcome, {this.name}!";
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
            EditProfile ep = new EditProfile();
            ep.Show();
        }
    }
}
