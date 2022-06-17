using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSaler
{
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientAdd clientAdd = new clientAdd();
            clientAdd.Show();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClerkAdd clerk = new ClerkAdd();
            clerk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();
            orders.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients clients = new Clients();
            clients.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
