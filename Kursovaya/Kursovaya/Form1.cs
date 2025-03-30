using System.Data;
using System.Data.SqlClient;


namespace Kursovaya
{
    public partial class Form1 : Form
    {
        DataBase DataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            var Login = LoginTb.Text;
            var Password = PasswordTb.Text;

            string querrystring = $"select * from Teacher where login = '{Login}' and password = '{Password}'";

            SqlCommand command = new SqlCommand(querrystring, DataBase.GetConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataBase.OpenConnection();

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен успешно!", "Вы вошли в систему", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Journal Transition = new Journal();
                Transition.login = Login;
                Transition.ShowDialog();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Вход не был выполнен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            DataBase.CloseConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
