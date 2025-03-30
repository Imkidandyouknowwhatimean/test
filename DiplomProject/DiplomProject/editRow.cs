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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace DiplomProject
{
    public partial class editRow : Form
    {
        DataBase database = new DataBase();
        public editRow()
        {
            InitializeComponent();
        }
        public string tableName;
        public string rowNum;

        private void rowTable_Click(object sender, EventArgs e)
        {
        }

        private void editRow_Load(object sender, EventArgs e)
        {
            
            labelTable.Text = $"Таблица - {tableName}";
            rowTable.Text = $"Редактируемая строка - {rowNum}";

            statusCb.Items.Add("Принято");
            statusCb.Items.Add("Не принято");

            gradeCb.Items.Add("2");
            gradeCb.Items.Add("3");
            gradeCb.Items.Add("4");
            gradeCb.Items.Add("5");

            gradeCb.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCb.DropDownStyle = ComboBoxStyle.DropDownList;

            database.openConnection();


            string querrystring = $"select ФИО_Студента from {tableName} where id = '{rowNum}'";
            SqlCommand commandName = new SqlCommand(querrystring, database.getConnection());
            SqlDataReader readerName = commandName.ExecuteReader();
            while (readerName.Read()) { nameTb.Text = readerName.GetValue(0).ToString(); }
            readerName.Close();

            querrystring = $"select Группа from {tableName} where id = '{rowNum}'";
            SqlCommand commandGroup = new SqlCommand(querrystring, database.getConnection());
            SqlDataReader readerGroup = commandGroup.ExecuteReader();
            while (readerGroup.Read()) { groupTb.Text = readerGroup.GetValue(0).ToString(); }
            readerGroup.Close();

            querrystring = $"select Тема_Проекта from {tableName} where id = '{rowNum}'";
            SqlCommand commandTheme = new SqlCommand(querrystring, database.getConnection());
            SqlDataReader readerTheme = commandTheme.ExecuteReader();
            while (readerTheme.Read()) { themeTb.Text = readerTheme.GetValue(0).ToString(); }
            readerTheme.Close();

            querrystring = $"select Статус_приемки from {tableName} where id = '{rowNum}'";
            SqlCommand commandStatus = new SqlCommand(querrystring, database.getConnection());
            SqlDataReader readerStatus = commandStatus.ExecuteReader();
            while (readerStatus.Read()) { statusCb.Text = readerStatus.GetValue(0).ToString(); }
            readerStatus.Close();

            querrystring = $"select Дата_сдачи_проекта from {tableName} where id = '{rowNum}'";
            SqlCommand commandDate = new SqlCommand(querrystring, database.getConnection());
            SqlDataReader readerDate = commandDate.ExecuteReader();
            while (readerDate.Read()) { dateTb.Text = readerDate.GetValue(0).ToString(); }
            readerDate.Close();

            querrystring = $"select Оценка_за_проект from {tableName} where id = '{rowNum}'";
            SqlCommand commandGrade = new SqlCommand(querrystring, database.getConnection());
            SqlDataReader readerGrade = commandGrade.ExecuteReader();
            while (readerGrade.Read()) { gradeCb.Text = readerGrade.GetValue(0).ToString(); }
            readerGrade.Close();

            database.closeConnection();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var student = nameTb.Text;
            var group = groupTb.Text;
            var theme = themeTb.Text;
            var date = dateTb.Text;
            var status = statusCb.Text;
            var grade = gradeCb.Text;

            string querrystring = $"update {tableName} set " +
                $"ФИО_Студента = '{student}', Группа = '{group}', Тема_проекта = '{theme}', Статус_приемки = '{status}', " +
                $"Дата_сдачи_проекта = '{date}', Оценка_за_проект = '{grade}' where id = {rowNum}";
            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            if (string.IsNullOrEmpty(student))
            {
                MessageBox.Show("Поле ФИО Студента не содержит символов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTb.Text = "";
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
            else
            {
                MessageBox.Show("Изменеиня сохранены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.openConnection();

                command.ExecuteNonQuery();

                database.closeConnection();

                this.Close();
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            nameTb.Text = "";
            groupTb.Text = "";
            themeTb.Text = "";
            dateTb.Text = "";
            statusCb.Text = "";
            gradeCb.Text = "";
        }
    }
}
