using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    public partial class Form4 : Form
    {
        public static string str = @"Data Source=wsr-srv\sqlexpress;Initial Catalog=crklkzlfeyjd;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);
        public Form4()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string midname = textBox3.Text;
            string pas = textBox4.Text;
            string pasn = textBox5.Text;
                // проверяет соответвие текстбоксов и столбцов БД
                if(textBox1.Text != " " || textBox2.Text != " " || textBox3.Text != " " || textBox4.Text != " " || textBox5.Text != " ")
            {
                string Query2 = $"INSERT INTO [dbo].[Лист1$]([ФИО],[Дата_рождения],[пол],[серия пас],[номер пас]) " +
        $"values ('" + id + "','" + name + "','" + midname + "','" + pas + "','" + pasn + "')";
                SqlCommand Command2 = new SqlCommand(Query2, con);
                Command2.ExecuteNonQuery();
            }
                else
            {
                MessageBox.Show("NE");
            }
                
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
