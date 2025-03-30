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
namespace Kursovaya
{
    public partial class AddUserForm : Form
    {
        DataBase dataBase = new DataBase();
        public AddUserForm()
        {
            InitializeComponent();
        }

        public string TableName = "Teacher";

        private void AddButton_Click(object sender, EventArgs e)
        {
            var Username = UserNameTb.Text;
            var Password = PasswordTb.Text;
            var Login = LoginTb.Text;
            var Role = RoleCb.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            dataBase.OpenConnection();
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Login) || RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LoginCheck() == false)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataBase.OpenConnection();

                string querrystring = $"select id from Role where role = '{Role}'";
                SqlCommand command = new SqlCommand(querrystring, dataBase.GetConnection());
                var RoleId = command.ExecuteScalar();

                command = new SqlCommand($"select id from Teacher where teacher = '{Username}'", dataBase.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                command = new SqlCommand($"insert into Teacher(teacher, role_id, login, password) " +
                    $"VALUES('{Username}','{RoleId}','{Login}','{Password}')", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь не был создан", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                    dataBase.CloseConnection();
                    return;
                }
                else
                {
                    MessageBox.Show("Пользователь успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    dataBase.CloseConnection();
                    return;

                }
                dataBase.CloseConnection();
            }
        }

        private bool LoginCheck()
        {
            var Login = LoginTb.Text;

            string querrystring = $"select * from Teacher where login = '{Login}'";

            dataBase.OpenConnection();

            SqlCommand command = new SqlCommand(querrystring, dataBase.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataBase.CloseConnection();
                return false;
            }
            else
            {
                ClearFields();
                dataBase.CloseConnection();
                return true;
            }

        }
        private void ClearFields()
        {
            UserNameTb.Text = "";
            PasswordTb.Text = "";
            LoginTb.Text = "";
            RoleCb.SelectedIndex = -1;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1, TableName);
            string querrystring = $"select role from Role";

            RoleCb.DropDownStyle = ComboBoxStyle.DropDownList;
            FillFields(querrystring, RoleCb);
        }

        public string FillFields(string querry, ComboBox NameCb)
        {
            dataBase.OpenConnection();

            string querrystring = querry;

            SqlCommand command = new SqlCommand(querrystring, dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            { NameCb.Items.Add(reader.GetValue(0).ToString()); }
            reader.Close();

            dataBase.CloseConnection();
            return querry;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Преподаватель", "Преподаватель");
            dataGridView1.Columns.Add("Должность", "Должность");
            dataGridView1.Columns.Add("Логин", "Логин");
            dataGridView1.Columns.Add("Пароль", "Пароль");

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4));


        }

        public void RefreshDataGrid(DataGridView dgw, string tableName)
        {
            dgw.Rows.Clear();

            string querrystring = $"SELECT s.id " +
                $"AS Teacher, s.teacher, a.role, s.login, s.password " +
                $"FROM Teacher s " +
                $"JOIN Role a ON s.role_id = a.id ";

            SqlCommand command = new SqlCommand(querrystring, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

            dataBase.CloseConnection();
        }
    }

}
