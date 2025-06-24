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
        //private string userId;
        //private string name;
        //private string address;
        //private string dob;
        //private string gender;
        //private string email;
        //private string phoneNo;

        //string userId, string name, string address, string dob, string gender, string email, string phoneNo
        public EditProfile()
        {
            InitializeComponent();
            //this.userId = userId;
            //this.name = name;
            //this.address = address;
            //this.dob = dob;
            //this.gender = gender;
            //this.email = email;
            //this.phoneNo = phoneNo;
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
            ProfileForm pf = new ProfileForm("User Name"); // Replace "User Name" with actual user name
            pf.Show();
        }
    }
}
