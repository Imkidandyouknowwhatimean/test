using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DiplomProject
{
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var login = loginTb.Text;
            var password = passwordTb.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable(); 

            string querrystring = $"select id, ФИО, Логин, Пароль from Personal where Логин = '{login}' and Пароль = '{password}'";

            SqlCommand command = new SqlCommand(querrystring, dataBase.getConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен","Вы Успешно вошли!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form = new Form2();
                form.ShowDialog();  
                this.Close();
            }

            else
            {
                MessageBox.Show("Вход не выполнен","Неверный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loginTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
