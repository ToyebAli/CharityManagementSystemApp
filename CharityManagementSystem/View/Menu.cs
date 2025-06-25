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
    public partial class Menu : Form
    {
        private Login login;
        public Menu(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }   

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
                    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentForm pf = new paymentForm(login);
            pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentForm pf = new paymentForm(login);
            pf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentForm pf = new paymentForm(login);
            pf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentForm pf = new paymentForm(login);
            pf.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm pf = new ProfileForm(login);
            pf.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
