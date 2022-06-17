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
    public partial class ProgTZ : Form
    {
        SqlConnection con;
        public ProgTZ()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName +
                ";Initial Catalog=SoftSale;Integrated Security=True";
            InitializeComponent();
            progerFill();
            managerFill();
            clientFill();
        }
        public ProgTZ(int i)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName +
                ";Initial Catalog=SoftSale;Integrated Security=True";
            InitializeComponent();
            progerFill();
            managerFill();
            clientFill();
            comboClient.SelectedIndex = i;
        }
        private void progerFill() {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from Сотрудник WHERE Должность = 3";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            proger.ValueMember = "Код";
            proger.DisplayMember = "ФИО";
            proger.DataSource = dt;
            con.Close();
        }
        private void managerFill()
        {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from Сотрудник WHERE Должность = 2";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            manager.ValueMember = "Код";
            manager.DisplayMember = "ФИО";
            manager.DataSource = dt;
            con.Close();
        }
        private void clientFill()
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
                comboClient.ValueMember = "Код";
               comboClient.DisplayMember = "ФИО";
              comboClient.DataSource = dt;
                con.Close();


            
        }
        private void ProgTZ_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || tz.Text == "" || manager.Text == "" || sum.Text == "" )
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return;
            }

            try
            {
                con.Open();
                string com = "INSERT INTO Программа (Название, Тз, Сотрудник, СтатусЗаказа) " +
                    "values('" + name.Text + "', '" +
                    tz.Text + "', '" + proger.SelectedValue.ToString() + "', '1');" +
                    "declare @ews int set @ews = (select max(Код) from Программа); insert into Договор" +
                    "(Сумма, Программа, ДатаНачала, ДатаОкончания, Клиент, Сотрудник) values('" + sum.Text + "', @ews, '" +
                    startDate.Value.Date.ToString() + "', '" + finishDate.Value.Date.ToString() + "', '" +
                    comboClient.SelectedValue.ToString() + "', '" + manager.SelectedValue.ToString() + "');";
                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show("Заказ успешно добавлен");
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                Menu Menu = new Menu();
                Menu.Show();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
            
        }
    }
}
