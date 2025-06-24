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

namespace CharityManagementSystem.View
{
    public partial class EditProfile : Form
    {
        private string address;
        private string dob;
        private string gender;
        private Login login;

        public EditProfile(Login login)
        {
            InitializeComponent();
            this.login = login;
            textBox1.Text = login.UserId;
            textBox2.Text = login.Name;
            textBox6.Text = login.Email;
            textBox7.Text = login.PhoneNumber;
            textBox1.Enabled = false;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm pf = new ProfileForm(this.login);
            pf.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
