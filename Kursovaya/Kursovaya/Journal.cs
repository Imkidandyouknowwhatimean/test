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

namespace Kursovaya
{
    public partial class Journal : Form
    {
        DataBase DataBase = new DataBase();
        public Journal()
        {
            InitializeComponent();
        }
        public string tableName = "Projects_import";

        public string login;
        public string password;



        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Студент", "Студент");
            dataGridView1.Columns.Add("Тема", "Тема проекта");
            dataGridView1.Columns.Add("Дата", "Дата");
            dataGridView1.Columns.Add("Статус", "Статус");
            dataGridView1.Columns.Add("Оценка", "Оценка");
            dataGridView1.Columns.Add("Преподаватель", "Преподаватель");
            dataGridView1.Columns.Add("Группа", "Группа");

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 170;
            dataGridView1.Columns[7].Width = 55;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDateTime(3), record.GetString(4), record.GetInt32(5),
                record.GetString(6), record.GetString(7));


        }

        private string querrystring = $"SELECT s.id " +
                $"AS Projects_import, a.student, b.theme, s.date, c.[status], d.grade, e.teacher, f.[group]" +
                $"FROM Projects_import s " +
                $"JOIN Student a ON s.student_id = a.id " +
                $"JOIN ProjectTheme b ON s.theme_id = b.id " +
                $"JOIN [Status] c ON s.status_id = c.id " +
                $"JOIN Grade d ON s.grade_id = d.id " +
                $"JOIN Teacher e ON s.teacher_id = e.id " +
                $"JOIN [Group] f ON s.group_id = f.id ";


        public void RefreshDataGrid(DataGridView dgw, string tableName, string querrystring)
        {
            dgw.Rows.Clear();

            /*
            string querrystring = $"SELECT s.id " +
                $"AS Projects_import, a.student, b.theme, s.date, c.[status], d.grade, e.teacher, f.[group]" +
                $"FROM Projects_import s " +
                $"JOIN Student a ON s.student_id = a.id " +
                $"JOIN ProjectTheme b ON s.theme_id = b.id " +
                $"JOIN [Status] c ON s.status_id = c.id " +
                $"JOIN Grade d ON s.grade_id = d.id " +
                $"JOIN Teacher e ON s.teacher_id = e.id " +
                $"JOIN [Group] f ON s.group_id = f.id ";
            */

            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());

            DataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

            DataBase.CloseConnection();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1, tableName, querrystring);
            if (tableName == "Projects_import")
            {
                label1.Text = $"Проекты группы - Все проекты";
            }

            FillFields("select [group] from [Group]", SortCb);

        }

        public string FillFields(string querry, ComboBox NameCb)
        {
            DataBase.OpenConnection();

            string querrystring = querry;

            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            { NameCb.Items.Add(reader.GetValue(0).ToString()); }
            reader.Close();

            DataBase.CloseConnection();
            return querry;

        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, tableName, querrystring);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var DelNumber = DeleteRowTb.Text;

            if (CheckId(DelNumber, DeleteRowTb) == false)
            {
                string querrystring = $"Delete from {tableName} where id = '{DelNumber}'";

                DataBase.OpenConnection();

                SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(dt);
                RefreshDataGrid(dataGridView1, tableName, querrystring);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Строка не была удалена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DataBase.CloseConnection();
                    return;
                }
                else
                {

                    MessageBox.Show("Строка успешно удалена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBase.CloseConnection();
                    DeleteRowTb.Text = "";
                    return;

                }
            }
            else
            {
                DataBase.CloseConnection();
            }

            DataBase.CloseConnection();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var RowNum = EditTb.Text;

            DataBase.OpenConnection();

            if (CheckId(RowNum, EditTb) == false)
            {
                EditForm editForm = new EditForm();
                editForm.RowNum = RowNum;

                editForm.ShowDialog();
                return;

            }
            else
            {
                DataBase.CloseConnection();
                return;
            }
            DataBase.CloseConnection();
        }

        private void EditTb_TextChanged(object sender, EventArgs e)
        {

        }

        public bool CheckId(string Num, TextBox txtBox)
        {
            var NumRow = Num;

            string querrystring = $"select * from {tableName} where id = '{NumRow}'";

            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Номера не существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.Text = "";
                return true;
            }

        }

        private void editTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != '.' || EditTb.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void DeleteRowTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                // Запрет на ввод более одной десятичной точки
                if (e.KeyChar != '.' || DeleteRowTb.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            //RefreshDataGrid(dataGridView1, tableName);
            //Search(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            var SearchText = FindTb.Text;

            string searchstring = $"select * from {tableName} where concat (id, student_id, theme_id, status_id, grade_id, [date], teacher_id, group_id)" +
                $"like '%" + SearchText + "%'";

            DataBase.OpenConnection();

            SqlCommand command = new SqlCommand(searchstring, DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            DataBase.CloseConnection();
            reader.Close();
        }

        private void FindTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            string Role_Id = "";
            string UserRole = "";

            string querrystring = $"select role_id from Teacher where login = '{login}'";
            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Role_Id = reader.GetValue(0).ToString();
            }
            reader.Close();

            querrystring = $"select role from Role where id = '{Role_Id}'";

            command = new SqlCommand(querrystring, DataBase.GetConnection());

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserRole = reader.GetValue(0).ToString();
            }

            if (UserRole == "Администратор")
            {
                MessageBox.Show("Вы успешно вошли", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DataBase.CloseConnection();

                AddUserForm Add = new AddUserForm();
                Add.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Недостаточно прав!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataBase.CloseConnection();
                return;
            }

            DataBase.CloseConnection();


        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string Student = NewStudentTb.Text;

            string querrystring = $"insert into Student(student) values('{Student}')";

            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());
            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Student))
            {
                MessageBox.Show("Вы не ввели данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewStudentTb.Text = "";
                return;
            }
            else
            {
                if (CheckExistRow($"select * from Student where student = '{Student}'") == true)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewStudentTb.Text = "";
                    return;
                }
                else
                {

                }
            }
            DataBase.CloseConnection();
        }
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            string Group = NewGroupTb.Text;

            string querrystring = $"insert into [Group]([group]) values('{Group}')";

            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());
            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Group))
            {
                MessageBox.Show("Вы не ввели данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewGroupTb.Text = "";
                return;
            }
            if (Group.Length >= 6)
            {
                MessageBox.Show("Название группы слишком длинное", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewGroupTb.Text = "";
                return;
            }
            else
            {
                if (CheckExistRow($"select * from [Group] where [group] = '{Group}'") == true)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewGroupTb.Text = "";
                    return;
                }
                else
                {

                }
            }
            DataBase.CloseConnection();
        }

        private void AddThemeButton_Click(object sender, EventArgs e)
        {
            string Theme = NewThemeTb.Text;

            string querrystring = $"insert into ProjectTheme(theme) values('{Theme}')";

            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());
            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Theme))
            {
                MessageBox.Show("Вы не ввели данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewThemeTb.Text = "";
                return;
            }
            else
            {
                if (CheckExistRow($"select * from ProjectTheme where theme = '{Theme}'") == true)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewThemeTb.Text = "";
                    return;
                }
                else
                {

                }
            }
            DataBase.CloseConnection();
        }

        bool CheckExistRow(string querry)
        {
            SqlCommand command = new SqlCommand(querry, DataBase.GetConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            DataBase.OpenConnection();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string Group = SortCb.Text;
            string querrystring;

            DataBase.OpenConnection();

            SqlCommand command = new SqlCommand();
            if (string.IsNullOrEmpty(Group))
            {
                querrystring = $"SELECT s.id " +
                $"AS Projects_import, a.student, b.theme, s.date, c.[status], d.grade, e.teacher, f.[group]" +
                $"FROM Projects_import s " +
                $"JOIN Student a ON s.student_id = a.id " +
                $"JOIN ProjectTheme b ON s.theme_id = b.id " +
                $"JOIN [Status] c ON s.status_id = c.id " +
                $"JOIN Grade d ON s.grade_id = d.id " +
                $"JOIN Teacher e ON s.teacher_id = e.id " +
                $"JOIN [Group] f ON s.group_id = f.id ";

                command = new SqlCommand(querrystring, DataBase.GetConnection());
                RefreshDataGrid(dataGridView1, tableName, querrystring);

                DataBase.CloseConnection();
                return;
            }
            else
            {

                querrystring = $"select id from [Group] where [group] = '{Group}'";
                command = new SqlCommand(querrystring, DataBase.GetConnection());

                querrystring = $"SELECT s.id " +
                    $"AS Projects_import, a.student, b.theme, s.date, c.[status], d.grade, e.teacher, f.[group]" +
                    $"FROM Projects_import s " +
                    $"JOIN Student a ON s.student_id = a.id " +
                    $"JOIN ProjectTheme b ON s.theme_id = b.id " +
                    $"JOIN [Status] c ON s.status_id = c.id " +
                    $"JOIN Grade d ON s.grade_id = d.id " +
                    $"JOIN Teacher e ON s.teacher_id = e.id " +
                    $"JOIN [Group] f ON s.group_id = f.id " +
                    $"where [group] = '{Group}'";
                command = new SqlCommand(querrystring, DataBase.GetConnection());

                RefreshDataGrid(dataGridView1, tableName, querrystring);

                DataBase.CloseConnection();
                return;
            }
            DataBase.CloseConnection();

        }
    }
}
