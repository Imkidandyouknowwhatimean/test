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

namespace DiplomProject
{
    public partial class createTable : Form
    {
        DataBase database = new DataBase();
        public createTable()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var table = tableTb.Text;

            string querrystring = $"create table {table} (" +
                $"id int NOT NULL PRIMARY KEY," +
                $"ФИО_Студента varchar(60) NOT NULL," +
                $"Группа nchar(10) NOT NULL," +
                $"Тема_проекта varchar(100) NOT NULL," +
                $"Статус_приемки varchar(10) NOT NULL," +
                $"Дата_сдачи_проекта varchar(10) NOT NULL," +
                $"Оценка_за_проект int NOT NULL" +
                $");";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            database.openConnection();
            if (CheckTable() == false)
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Табилца не была зарегистрирована", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Таблица зарегистрирована", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string plusstring = $"insert into tableNames(tableName) VALUES ('{table}')";
                    SqlCommand commandplus = new SqlCommand(plusstring, database.getConnection());
                    commandplus.ExecuteNonQuery();

                    this.Hide();
                }
                database.closeConnection();
            }
            else
            {
                database.closeConnection();
            }

        }

        private Boolean CheckTable()
        {
            var table = tableTb.Text;

            if (string.IsNullOrEmpty(table))
            {
                MessageBox.Show("Имя таблицы отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                table = "";
                tableTb.Text = "";

                return true;
            }

            string querrystring = $"select tableName from tableNames where tableName = '{table}'";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tb = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("Таблица уже существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tableTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void createTable_Load(object sender, EventArgs e)
        {
            string querrystring = $"select tableName from tableNames";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tablesLb.Items.Add(reader.GetValue(0).ToString());
            }
            database.closeConnection();
        }

        private void tablesLb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
