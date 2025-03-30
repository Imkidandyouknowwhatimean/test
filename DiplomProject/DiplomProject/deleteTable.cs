using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiplomProject
{
    public partial class deleteTable : Form
    {
        DataBase database = new DataBase();
        public deleteTable()
        {
            InitializeComponent();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            var table = tableTb.Text;

            string querrystring = $"drop table {table}";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            database.openConnection();
            if (CheckTable() == false)
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Таблица не была удалена", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Табилца удалена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string plusstring = $"delete from tableNames WHERE tableName = '{table}'";
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
            if (table == "DiplomProjects")
            {
                MessageBox.Show("Нельзя удалить начальную таблицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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

                return false;
            }
            else
            {
                MessageBox.Show("Таблица не существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                table = "";
                tableTb.Text = "";

                return true;
            }
        }

        private void deleteTable_Load(object sender, EventArgs e)
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
    }
}
