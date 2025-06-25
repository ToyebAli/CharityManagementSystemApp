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
    public partial class Contact_Us: Form
    {
        Login login;
        public Contact_Us(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Contact_Us_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm p = new ProfileForm(login);
            p.Show();
        }
    }
}
