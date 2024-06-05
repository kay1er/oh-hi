using MySql.Data.MySqlClient; // Thêm thư viện để làm việc với MySQL
using System;
using System.Data; // Thêm thư viện để làm việc với dữ liệu
using System.Windows.Forms;

namespace idk
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        MY_DB db = new MY_DB(); // Tạo một đối tượng MY_DB để kết nối cơ sở dữ liệu

        // Sự kiện khi form TimKiem được tải
        private void TimKiem_Load(object sender, EventArgs e)
        {
            try
            {
                // Tạo câu lệnh SQL để lấy danh sách mã sinh viên từ bảng student
                MySqlCommand command = new MySqlCommand("SELECT `Mã sinh viên` FROM `student`", db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Thêm một dòng mới để hiển thị tất cả các mã sinh viên
                DataRow allRow = table.NewRow();
                allRow["Mã sinh viên"] = "Tất cả"; // Hiển thị "Tất cả" trên ComboBox
                table.Rows.InsertAt(allRow, 0);

                // Đặt nguồn dữ liệu cho ComboBox
                comboBox1.DataSource = table;
                comboBox1.DisplayMember = "Mã sinh viên"; // Hiển thị mã sinh viên trên ComboBox
                comboBox1.ValueMember = "Mã sinh viên"; // Giá trị thực sự của ComboBox là mã sinh viên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message); // Hiển thị thông báo lỗi nếu có lỗi xảy ra
            }
        }

        // Sự kiện khi nhấn nút Tìm Kiếm
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null) // Kiểm tra xem đã chọn giá trị hay chưa
            {
                string selectedMaSV = comboBox1.SelectedValue.ToString(); // Lấy giá trị mã sinh viên đã chọn

                DanhSachDiem parentForm = this.Owner as DanhSachDiem; // Lấy ra form cha của form hiện tại và kiểm tra xem nó có phải là một đối tượng DanhSachDiem không
                if (parentForm != null)
                {
                    parentForm.SetMaSV(selectedMaSV); // Nếu form cha là một đối tượng DanhSachDiem, gọi phương thức SetMaSV từ form cha và truyền mã sinh viên đã chọn cho nó
                }


                this.Close(); // Đóng form hiện tại
            }
            else
            {
                // Xử lý trường hợp không có giá trị được chọn trong comboBox1
                MessageBox.Show("Vui lòng chọn một giá trị trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
