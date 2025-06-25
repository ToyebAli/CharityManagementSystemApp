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
    public partial class adminDashboard: Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void adminDasboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

        }

        private void viewlistbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewUserList viewUserList = new ViewUserList();
            viewUserList.Show();
        }
    }
}
