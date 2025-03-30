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
    public partial class transition : Form
    {
        DataBase database = new DataBase();
        public transition()
        {
            InitializeComponent();
        }

        private void transitButton_Click(object sender, EventArgs e)
        {
            
            var nameTable = tableTb.Text;

            string querrystring = $"select tableName from tableNames where tableName = '{nameTable}'";

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Close();
                Form2 form2 = new Form2();
                form2.Close();
                MessageBox.Show("Успех!", "Переход выполнен", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 frm2 = new Form2();

                frm2.tablename = nameTable;
                frm2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Ошибка", "Неверное имя таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void transition_Load(object sender, EventArgs e)
        {
            string querrystring = $"select tableName from tableNames";

            SqlCommand command = new SqlCommand(querrystring , database.getConnection());

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
