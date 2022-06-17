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
    public partial class Clients : Form
    {
        SqlConnection con;
        public Clients()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName +
                ";Initial Catalog=SoftSale;Integrated Security=True";
            InitializeComponent();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Клиент";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Width = 15;
            con.Close();

        }
        private void ClientCombo()
        {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from Клиент";
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
            this.Hide();
            adminMenu adminMenu = new adminMenu();
            adminMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
            ClientCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select();
        }
        private void select() {
            con.Open();
            string query = "select * from Клиент Where Код = " + comboBox1.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("Фамилия", typeof(string));
            dt.Columns.Add("Имя", typeof(string));
            dt.Columns.Add("Отчество", typeof(string));
            dt.Columns.Add("Телефон", typeof(string));
            dt.Columns.Add("НаименованиеКомпании", typeof(string));
            dt.Columns.Add("ИНН", typeof(string));
            dt.Columns.Add("БИК", typeof(string));
            dt.Columns.Add("ЮридическийАдрес", typeof(string));
            dt.Columns.Add("Паспорт", typeof(string));
            dt.Columns.Add("АдресЭлектроннойПочты", typeof(string));//10

            dt.Load(rdr);
            tx1.Text = Convert.ToString(dt.Rows[0][1]);
            tx2.Text = Convert.ToString(dt.Rows[0][2]);
            tx3.Text = Convert.ToString(dt.Rows[0][3]);
            tx4.Text = Convert.ToString(dt.Rows[0][4]);
            tx5.Text = Convert.ToString(dt.Rows[0][10]);
            tx6.Text = Convert.ToString(dt.Rows[0][9]);
            tx7.Text = Convert.ToString(dt.Rows[0][5]);
            tx8.Text = Convert.ToString(dt.Rows[0][6]);
            tx9.Text = Convert.ToString(dt.Rows[0][7]);
            tx10.Text = Convert.ToString(dt.Rows[0][8]);
            con.Close();
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            select();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            populate();
           ClientCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string com = "UPDATE Клиент SET Фамилия = '"+ tx1.Text + "', Имя  = '" + tx2.Text + "', Отчество = '" + tx3.Text + "', Телефон = '" + tx4.Text + "'," +
                    " АдресЭлектроннойПочты  = '" + tx5.Text + "', Паспорт = '" + tx6.Text + "', НаименованиеКомпании = '" + tx7.Text + "'," +
                    " ИНН = '" + tx8.Text + "', БИК = '" + tx9.Text + "', ЮридическийАдрес = '" + tx10.Text + "' WHERE Код = " + comboBox1.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show("Клиент успешно изменён");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
