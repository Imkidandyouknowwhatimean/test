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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiplomProject
{
    public partial class AddProject : Form
    {
        DataBase database = new DataBase();
        public AddProject()
        {
            InitializeComponent();


        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            statusCb.Items.Add("Принято");
            statusCb.Items.Add("Не принято");

            gradeCb.Items.Add("2");
            gradeCb.Items.Add("3");
            gradeCb.Items.Add("4");
            gradeCb.Items.Add("5");

            gradeCb.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public string tablenameAdd;
        private void addButton_Click(object sender, EventArgs e)
        {
            int number;
            var student = studentTb.Text;
            var group = groupTb.Text;
            var theme = themeTb.Text;
            var status = statusCb.Text;
            var date = dateTb.Text;
            var grade = gradeCb.Text;

            database.openConnection();


            if (int.TryParse(numberTb.Text, out number))
            {

                if (string.IsNullOrEmpty(student))
                {
                    MessageBox.Show("Поле ФИО Студента не содержит символов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    studentTb.Text = "";
                    return;
                }
                if (string.IsNullOrEmpty(group))
                {
                    MessageBox.Show("Поле Группа не содержит символов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    groupTb.Text = "";
                    return;
                }
                if (string.IsNullOrEmpty(theme))
                {
                    MessageBox.Show("Поле Тема не содержит символов!", "Поле Тема не содержит символов!Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    themeTb.Text = "";
                    return;
                }

                if (checkId() == false)
                {
                    Form2 form = new Form2();

                    string querrystring = $"insert into {tablenameAdd}(id, ФИО_Студента, Группа, Тема_проекта, Статус_приемки, Дата_сдачи_проекта, Оценка_за_проект) " +
                        $"VALUES ('{number}', '{student}', '{group}', '{theme}', '{status}', '{date}', '{grade}')";
                    SqlCommand command = new SqlCommand(querrystring, database.getConnection());

                    MessageBox.Show("Поле успешно добавлено", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    command.ExecuteNonQuery();
                    this.Close();
                }
                else
                {
                    database.closeConnection();
                }

            }
            else
            {
                MessageBox.Show("Запись не была создана", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label9.Visible = true;

            }
            database.closeConnection();
        }

        private bool checkId()
        {
            var number = numberTb.Text;

            string querrystring = $"select id from {tablenameAdd} where id = '{number}'";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tb = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("Номер уже существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            numberTb.Text = "";
            studentTb.Text = "";
            groupTb.Text = "";
            themeTb.Text = "";
            statusCb.Text = "";
            dateTb.Text = "";
            gradeCb.Text = "";
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gradeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
