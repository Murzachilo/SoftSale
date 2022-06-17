using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSaler
{
    public partial class clientAdd : Form
    {
        SqlConnection con;
        public clientAdd()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName +
                ";Initial Catalog=SoftSale;Integrated Security=True";
            InitializeComponent();
        }

        private void clientAdd_Load(object sender, EventArgs e)
        {
            fillClientCombo();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void fillClientCombo()
        {
            con.Open();
            string query = "select Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from Клиент";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            comboBox1.ValueMember = "Код";
            comboBox1.DisplayMember = "ФИО";
            comboBox1.DataSource = dt;
            con.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tx1.Text == "" || tx2.Text == "" || tx3.Text == "" || tx4.Text == "" || tx5.Text == "" || tx6.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return;
            }

            try
            {
                con.Open();
                string com = "INSERT INTO Клиент (Фамилия, Имя, Отчество, Телефон," +
                    " АдресЭлектроннойПочты, Паспорт, НаименованиеКомпании," +
                    " ИНН, БИК, ЮридическийАдрес) values('" + tx1.Text + "', '" +
                    tx2.Text + "', '" + tx3.Text + "', '" + tx4.Text + "', '" + tx5.Text +
                    "', '" + tx6.Text + "', '" + tx7.Text + "', '" + tx8.Text + "', '" + tx9.Text + "', '" + tx10.Text + "')";

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show("Клиент успешно добавлен");
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                ProgTZ dlg = new ProgTZ();
                dlg.Show(this);
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
            fillClientCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgTZ dlg = new ProgTZ(comboBox1.SelectedIndex);
            dlg.Show(this);
        }
    }
}
