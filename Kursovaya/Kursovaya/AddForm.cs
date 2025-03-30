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
using System.Windows.Input;

namespace Kursovaya
{
    public partial class AddForm : Form
    {
        DataBase dataBase = new DataBase();
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            StudentCb.DropDownStyle = ComboBoxStyle.DropDownList;
            ThemeCb.DropDownStyle = ComboBoxStyle.DropDownList;
            TeacherCb.DropDownStyle = ComboBoxStyle.DropDownList;
            GradeCb.DropDownStyle = ComboBoxStyle.DropDownList;
            GroupCb.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusCb.DropDownStyle = ComboBoxStyle.DropDownList;

            dataBase.OpenConnection();

            FillFields("select student from Student", StudentCb);
            FillFields("select grade from Grade", GradeCb);
            FillFields("select [group] from [Group]", GroupCb);
            FillFields("select status from Status", StatusCb);
            FillFields("select theme from ProjectTheme", ThemeCb);
            FillFields("select teacher from Teacher", TeacherCb);

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



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var Student = StudentCb.SelectedItem;
            var Grade = GradeCb.SelectedItem;
            var Theme = ThemeCb.SelectedItem;
            var Status = StatusCb.SelectedItem;
            var Teacher = TeacherCb.SelectedItem;
            var Group = GroupCb.SelectedItem;

            string Date = DateTb.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            dataBase.OpenConnection();

            if (StudentCb.SelectedIndex == -1 || GradeCb.SelectedIndex == -1 || ThemeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1
                || string.IsNullOrEmpty(Date) || TeacherCb.SelectedIndex == -1 || GroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else
            {

                SqlCommand command = new SqlCommand($"select id from Student where student = '{Student}'", dataBase.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                try
                {
                    command = new SqlCommand($"insert into Projects_import(student_id, theme_id, status_id, grade_id, [date], teacher_id, group_id) " +
                        $"VALUES(" +
                        $"'{GetId($"select id from Student where student = '{Student}'")}'," +
                        $"'{GetId($"select id from ProjectTheme where theme = '{Theme}'")}'," +
                        $"'{GetId($"select id from Status where status = '{Status}'")}'," +
                        $"'{GetId($"select id from Grade where grade = '{Grade}'")}'," +
                        $"'{Date}'," +
                        $"'{GetId($"select id from Teacher where teacher = '{Teacher}'")}'," +
                        $"'{GetId($"select id from [Group] where [group] = '{Group}'")}')"
                        , dataBase.GetConnection());

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        dataBase.CloseConnection();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Запись не была создана", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                        dataBase.CloseConnection();
                        return;

                    }
                }
                catch
                {
                    MessageBox.Show("Неверный формат записи","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DateTb.Text = "";
                    dataBase.CloseConnection();
                    return;
                }
                dataBase.CloseConnection();

            }
        }

        public string GetId(string querry)
        {
            string querrystring = querry;
            string id;

            SqlCommand command = new SqlCommand(querrystring, dataBase.GetConnection());

            id = Convert.ToString(command.ExecuteScalar());

            return id;
        }

        public void ClearFields()
        {
            StudentCb.SelectedIndex = -1;
            GradeCb.SelectedIndex = -1;
            ThemeCb.SelectedIndex = -1;
            TeacherCb.SelectedIndex = -1;
            DateTb.Text = "";
            StatusCb.SelectedIndex = -1;
            GroupCb.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
