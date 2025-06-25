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
    public partial class Faq: Form
    {
        Login login;
        public Faq(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm p = new ProfileForm(login);
            p.Show();
        }

        private void Faq_Load(object sender, EventArgs e)
        {

        }
    }
}
