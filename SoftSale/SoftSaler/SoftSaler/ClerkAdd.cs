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
    public partial class ClerkAdd : Form
    {
        SqlConnection con;
        public ClerkAdd()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName +
                ";Initial Catalog=SoftSale;Integrated Security=True";
            InitializeComponent();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Сотрудник";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Width = 15;
            con.Close();
        }
        private void ClerksCombo()
        {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from Сотрудник";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            comboClerk.ValueMember = "Код";
            comboClerk.DisplayMember = "ФИО";
            comboClerk.DataSource = dt;
            con.Close();


        }
        private void Combodolg()
        {
            con.Open();
            string query = "select Код, Должность from Должность";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("Должность", typeof(string));
            dt.Load(rdr);
            comboDolg.ValueMember = "Код";
            comboDolg.DisplayMember = "Должность";
            comboDolg.DataSource = dt;
            con.Close();

        }
        private void StatusFill() {
            con.Open();
            string query = "select Код, Статус from Статус";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("Статус", typeof(string));
            dt.Load(rdr);
            comboStatus.ValueMember = "Код";
            comboStatus.DisplayMember = "Статус";
            comboStatus.DataSource = dt;
            con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fam.Text == "" || name.Text == "" || otch.Text == "" || num.Text == "" || mail.Text == "" || login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return;
            }

            try
            {
                con.Open();
                string com = "INSERT INTO Сотрудник (Фамилия, Имя, Отчество, Телефон," +
                    " АдресЭлектроннойПочты, Логин, Пароль, Статус, Должность) values('" + fam.Text + "', '" +
                    name.Text + "', '" + otch.Text + "', '" + num.Text + "', '" + mail.Text +
                    "', '" + login.Text + "', '" + password.Text + "', '" + comboStatus.SelectedValue.ToString() + "', '" + comboDolg.SelectedValue.ToString() + "')";

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show("Сотрудник успешно добавлен");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
            populate();
            ClerksCombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminMenu adminMenu = new adminMenu();
            adminMenu.Show();
        }

        private void ClerkAdd_Load(object sender, EventArgs e)
        {
            populate();
            ClerksCombo();
            Combodolg();
            StatusFill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string com = "UPDATE Сотрудник SET Фамилия = '" + fam.Text + "', Имя  = '" + name.Text + "', Отчество = '" + otch.Text + "', Телефон = '" + num.Text + "'," +
                    " Статус  = '" + comboStatus.SelectedValue.ToString() + "', АдресЭлектроннойПочты = '" + mail.Text + "', Логин = '" + login.Text + "'," +
                    " Пароль = '" + password.Text + "', Должность = '" + comboDolg.SelectedValue.ToString() + "' WHERE Код = " + comboClerk.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show("Сотрудник успешно изменён");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
            populate();
            ClerksCombo();

        }
        private void select()
        {
            con.Open();
            string query = "select * from Сотрудник Where Код = " + comboClerk.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("Фамилия", typeof(string));
            dt.Columns.Add("Имя", typeof(string));
            dt.Columns.Add("Отчество", typeof(string));
            dt.Columns.Add("Телефон", typeof(string));
            dt.Columns.Add("Статус", typeof(string));
            dt.Columns.Add("АдресЭлектроннойПочты", typeof(string));
            dt.Columns.Add("Логин", typeof(string));
            dt.Columns.Add("Пароль", typeof(string));
            dt.Columns.Add("Должность", typeof(string)); //9

            dt.Load(rdr);
            fam.Text = Convert.ToString(dt.Rows[0][1]);
            name.Text = Convert.ToString(dt.Rows[0][2]);
            otch.Text = Convert.ToString(dt.Rows[0][3]);
            num.Text = Convert.ToString(dt.Rows[0][4]);
            comboStatus.SelectedValue = Convert.ToString(dt.Rows[0][5]);
            mail.Text = Convert.ToString(dt.Rows[0][6]);
            login.Text = Convert.ToString(dt.Rows[0][7]);
            password.Text = Convert.ToString(dt.Rows[0][8]);
            comboDolg.SelectedValue = Convert.ToString(dt.Rows[0][9]);
            con.Close();
        }

        private void comboClerk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            select();
        }
    }
}
