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
using System.Data.SqlClient;
using System.Drawing.Text;

namespace DiplomProject
{
    public partial class regForm : Form
    {
        DataBase database = new DataBase();
        public regForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = idTb.Text;
            var name = nameTb.Text;
            var login = loginTb.Text;
            var password = passwordTb.Text;

            string querrystring = $"insert into Personal(id, ФИО, Логин, Пароль) VALUES('{id}','{name}','{login}','{password}')";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());
            try
            {
                Convert.ToInt32(id);
            }
            catch (System.FormatException)
            {
                idTb.Clear();
                MessageBox.Show("Ошибка!","Вы ввели символ в id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Convert.ToString(id);
            }

            database.openConnection();
            if (string.IsNullOrEmpty(idTb.Text))
            {
                MessageBox.Show("Аккаунт не был зарегистрирован", "Поле не содержит id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nameTb.Text))
            {
                MessageBox.Show("Аккаунт не был зарегистрирован", "Поле не содержит ФИО", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(loginTb.Text))
            {
                MessageBox.Show("Аккаунт не был зарегистрирован", "Поле не содержит логин", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(passwordTb.Text))
            {
                MessageBox.Show("Аккаунт не был зарегистрирован", "Поле не содержит пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                if (CheckUser() == false)
                {

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт не был зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    database.closeConnection();
                }
                else
                {
                    database.closeConnection();
                }
            }
        }

        private void idTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // разрешает только буквы
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private Boolean CheckUser()
        {
            var login = loginTb.Text;

            string querrystring = $"select ФИО, Логин, Пароль from Personal where Логин = '{login}'";

            SqlCommand command = new SqlCommand(querrystring , database.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();  
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт уже существует!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
