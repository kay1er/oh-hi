using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idk
{
    public partial class DanhSachKhoaHoc : Form
    {
        public DanhSachKhoaHoc()
        {
            InitializeComponent();
        }

        MonHoc monHoc = new MonHoc();

        // Xử lý sự kiện khi nhấn nút "Hiển thị Danh sách"
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo câu lệnh SQL để lấy danh sách môn học từ cơ sở dữ liệu
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course`");

            // Thiết lập thuộc tính của DataGridView để hiển thị danh sách môn học
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = monHoc.DanhSachMonHoc(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        // Xử lý sự kiện khi Form được tải
        private void DanhSach_Load(object sender, EventArgs e)
        {
            // Tạo câu lệnh SQL để lấy danh sách môn học từ cơ sở dữ liệu
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course`");

            // Thiết lập thuộc tính của DataGridView để hiển thị danh sách môn học
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = monHoc.DanhSachMonHoc(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        // Xử lý sự kiện khi người dùng nhấp đúp chuột vào một hàng trong DataGridView
        private void DoubleClick_Click(object sender, EventArgs e)
        {
            // Khởi tạo form ChinhSuaMonHoc
            ChinhSuaMonHoc chinhsua = new ChinhSuaMonHoc();

            // Lấy thông tin từ DataGridView và gán vào các điều khiển trên form ChinhSuaMonHoc
            chinhsua.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            chinhsua.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            chinhsua.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            chinhsua.dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);

            // Xử lý thời gian bắt đầu và kết thúc
            TimeSpan startTime = (TimeSpan)dataGridView1.CurrentRow.Cells[4].Value;
            TimeSpan endTime = (TimeSpan)dataGridView1.CurrentRow.Cells[5].Value;

            // Chuyển đổi TimeSpan thành DateTime để gán vào DateTimePicker
            DateTime today = DateTime.Today;
            chinhsua.dateTimePicker3.Value = today.Add(startTime);
            chinhsua.dateTimePicker4.Value = today.Add(endTime);

            // Hiển thị form ChinhSuaMonHoc
            chinhsua.Show();
        }
    }
}
