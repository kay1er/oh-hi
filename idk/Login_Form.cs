using MySql.Data.MySqlClient; // Thư viện MySqlClient để làm việc với MySQL
using System.Data; // Thư viện System.Data để làm việc với DataTable

namespace idk
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent(); // Khởi tạo các thành phần của form
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Đây là phương thức xử lý sự kiện Load của form.
            // Hiện tại không có gì để thực hiện khi form được load.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của nút button2 (có thể là nút "Close" hoặc "Cancel")
            Close(); // Đóng form hiện tại
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của nút button1 (có thể là nút "Login")

            MY_DB db = new MY_DB(); // Tạo một đối tượng mới của lớp MY_DB để kết nối với cơ sở dữ liệu
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Tạo một MySqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = new DataTable(); // Tạo một DataTable để chứa dữ liệu lấy từ cơ sở dữ liệu

            // Tạo một MySqlCommand để thực hiện câu lệnh SQL
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn AND `password` = @pass", db.GetConnection());

            // Thêm các tham số vào câu lệnh SQL
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox1.Text; // Thêm tham số username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text; // Thêm tham số password

            adapter.SelectCommand = command; // Đặt MySqlCommand làm SelectCommand của adapter

            adapter.Fill(table); // Thực hiện câu lệnh SQL và điền dữ liệu vào DataTable

            // Kiểm tra xem có dòng nào trong DataTable hay không
            if (table.Rows.Count > 0)
            {
                // Nếu có, điều đó có nghĩa là username và password hợp lệ
                this.DialogResult = DialogResult.OK; // Đặt kết quả của form là OK
            }
            else
            {
                // Nếu không, hiển thị thông báo lỗi
                MessageBox.Show("Tai khoan hoac mat khau khong hop le", "Loi dang nhap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
