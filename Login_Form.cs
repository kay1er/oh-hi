using MySql.Data.MySqlClient;
using System.Data;
namespace idk
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `uesrs` WHERE `username`= @usn AND `password` = @pass", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tai khoan hoac mat khau khong hop le","Loi dang nhap",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
