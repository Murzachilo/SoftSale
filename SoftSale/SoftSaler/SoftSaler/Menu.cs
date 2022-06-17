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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientAdd cd = new clientAdd();
            cd.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
          
        }
    }
}
