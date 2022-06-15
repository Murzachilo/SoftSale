﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftSaler
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName +
                ";Initial Catalog=SoftSale;Integrated Security=True";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("логин или пароль пуст", textBox1.Text);
                return;
            }  // Проверка на заполнение
            else
            {
                if (con.State == ConnectionState.Closed) con.Open();

                DataTable useresTable = new DataTable();
                SqlCommand comm = new SqlCommand("SELECT * FROM ДанныеДляВхода WHERE Логин = '" + textBox1.Text + "' AND Пароль = '" + textBox2.Text + "' And Должность = 'admin'", con);

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                adapter.Fill(useresTable);
                if (useresTable.Rows.Count > 0)
                {
                    this.Hide();
                    MessageBox.Show("Заебись"); 
                    adminMenu dlg = new adminMenu();
                    dlg.Show(this);
                    //Вход как админ

                    // Проверка на админа
                }
/*                else
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM ДанныеДляВхода WHERE Логин = '" + textBox1.Text + "' AND Пароль = '" + textBox2.Text + "'", conn);
                    DataTable useresTabl = new DataTable();

                    SqlDataAdapter adapte = new SqlDataAdapter(com);
                    com.ExecuteNonQuery();
                    adapte.Fill(useresTabl);
                    if (useresTabl.Rows.Count > 0)
                    {
                        this.Hide();
                        Menu dlg = new Menu();
                        dlg.Show(this);
                        // Вход как пользователя
                    }*/
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        // Уведомление о не входе
                    }

                }
                // Проверка на пользователя

            }
        }
}
