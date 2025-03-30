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

namespace DiplomProject
{
    public partial class DelProject : Form
    {
        DataBase database = new DataBase();
        public DelProject()
        {
            InitializeComponent();
        }
        public string tablenameDel;

        private void delButton_Click(object sender, EventArgs e)
        {
            var number = numTb.Text;
            Form2 form2 = new Form2();
            

            string querrystring = $"delete from {tablenameDel} where id = '{number}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(querrystring, database.getConnection());

            database.openConnection();
            if (string.IsNullOrEmpty(numTb.Text))
            {
                MessageBox.Show("Ошибка", "Строка имеет неверный формат или число", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numTb.Text = "";
            }
            if(command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Успех!", "Поле успешно удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Ошибка", "Строка имеет неверный формат или число", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numTb.Text = "";
            }
            database.closeConnection();
            
        }
    }
}
