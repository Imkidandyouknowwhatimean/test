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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiplomProject
{
    enum RowState
    {
        New,
        Modified,
        ModifiedNow,
        Deleted

    }
    public partial class Form2 : Form
    {
        DataBase database = new DataBase();
        public Form2()
        {
            InitializeComponent();
        }
        public string tablename = "DiplomProjects";

        public void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");                                  //int
            dataGridView1.Columns.Add("ФИО_Студента", "ФИО Студента");              //string
            dataGridView1.Columns.Add("Группа", "Группа");                          //string 
            dataGridView1.Columns.Add("Тема_проекта", "Тема проекта");              //string
            dataGridView1.Columns.Add("Статус_приемки", "Статус приемки");          //string
            dataGridView1.Columns.Add("Дата_сдачи_проекта", "Дата сдачи проекта");  //string
            dataGridView1.Columns.Add("Оценка_за_проект", "Оценка за проект");      //int
        }

        private void readSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4),
                record.GetString(5), record.GetInt32(6));
        }
        public void RefreshDataGrid(DataGridView dgw, string tablename)
        {
            dgw.Rows.Clear();

            string querrystring = $"select * from {tablename}";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRow(dgw, reader);
            }
            reader.Close();
            tableLabel.Text = $"Имя таблицы - {tablename}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1, tablename);
        }
        public void Refresh()
        {
            RefreshDataGrid(dataGridView1, tablename);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            addProject.tablenameAdd = tablename;
            addProject.ShowDialog();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DelProject delProject = new DelProject();
            delProject.tablenameDel = tablename;
            delProject.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, tablename);
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            regForm regForm = new regForm();
            regForm.ShowDialog();
        }

        private void tableUpButton_Click(object sender, EventArgs e)
        {
            transition transition = new transition();
            transition.ShowDialog();
        }

        private void clsButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newTableButton_Click(object sender, EventArgs e)
        {
            createTable createTable = new createTable();
            createTable.ShowDialog();
        }

        private void delTableButton_Click(object sender, EventArgs e)
        {
            deleteTable deleteTable = new deleteTable();
            deleteTable.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            if (CheckId() == false)
            {
                editRow editRow = new editRow();
                editRow.rowNum = editTb.Text;
                editRow.tableName = tablename;
                editRow.ShowDialog();
            }
            else
            {
                database.closeConnection();
            }
            database.closeConnection();
        }

        private void editTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Если это не цифра
            if (!Char.IsDigit(e.KeyChar))
            {
                // Запрет на ввод более одной десятичной точки
                if (e.KeyChar != '.' || editTb.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }
        }


        private Boolean CheckId()
        {
            var numRow = editTb.Text;

            string querrystring = $"select id from {tablename} where id = '{numRow}'";

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
                MessageBox.Show("Номера не существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editTb.Text = "";
                return true;
            }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchstring = $"select * from {tablename} where concat (id, ФИО_Студента, Группа, Тема_проекта, Статус_приемки, Дата_сдачи_проекта, Оценка_за_проект" +
                $") like '%" + searchTb.Text + "%'";

            SqlCommand com = new SqlCommand(searchstring, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                readSingleRow(dgw, read);
            }

            read.Close();
        }
    }
}
