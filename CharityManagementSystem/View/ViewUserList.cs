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
    public partial class ViewUserList : Form
    {
        public ViewUserList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUserList_Load(object sender, EventArgs e)
        {
            LoginController lgc = new LoginController();
            dataGridView1.DataSource = lgc.GetAllLogin();
        }
    }
}
