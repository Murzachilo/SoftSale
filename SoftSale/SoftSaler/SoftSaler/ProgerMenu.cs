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
    public partial class ProgerMenu : Form
    {
        SqlConnection con;
        private String s;
        public ProgerMenu(String s)
        {
            this.s = s;
            String str = s;
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName +
                ";Initial Catalog=SoftSale;Integrated Security=True";
            InitializeComponent();
            
           
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Программа where Сотрудник = " + s;
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }
        private void ProgaCombo()
        {
            con.Open();
            string query = "select Код, Название from Программа where Сотрудник = " + s;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("Название", typeof(string));

            dt.Load(rdr);
            comboBox1.ValueMember = "Код";
            comboBox1.DisplayMember = "Название";
            comboBox1.DataSource = dt;
            con.Close();


        }
        private void StatusCombo()
        {
            con.Open();
            string query = "select Код, Статус from СтатусЗаказа";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("Статус", typeof(string));

            dt.Load(rdr);
            comboBox2.ValueMember = "Код";
            comboBox2.DisplayMember = "Статус";
            comboBox2.DataSource = dt;
            con.Close();


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
            try
            {
                con.Open();
                string com = "UPDATE Программа SET СтатусЗаказа = '" + comboBox2.SelectedValue.ToString() + "' WHERE Код = " + comboBox1.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show("Статус успешно изменён");
                cmd.ExecuteNonQuery();
                con.Close();
                populate();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void ProgerMenu_Load(object sender, EventArgs e)
        {
            populate();
            ProgaCombo();
            StatusCombo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
