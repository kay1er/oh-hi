using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace idk
{
    public partial class ChinhSuaMonHoc : Form
    {
        // Hàm khởi tạo của form ChinhSuaMonHoc
        public ChinhSuaMonHoc()
        {
            InitializeComponent();
        }

        // Tạo đối tượng MonHoc để thao tác với cơ sở dữ liệu
        MonHoc monHoc = new MonHoc();

        // Sự kiện khi nhấn nút Xóa
        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy mã lớp từ textbox
            string malop = Convert.ToString(textBox1.Text);

            // Hiển thị hộp thoại xác nhận xóa
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thực hiện xóa môn học và kiểm tra kết quả
                if (monHoc.XoaMonHoc(malop))
                {
                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trong các ô nhập liệu
                    textBox1.Text = "";
                    textBox2.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                    dateTimePicker3.Value = DateTime.Now;
                    dateTimePicker4.Value = DateTime.Now;
                }
                else
                {
                    // Hiển thị thông báo xóa không thành công
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện khi nhấn nút Thêm (chưa triển khai)
        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            // Chưa có triển khai cho nút Thêm
        }

        // Sự kiện khi nhấn nút Cập Nhật
        private void CapNhatMonHoc_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string malop = textBox1.Text.Trim();
            string tenlop = textBox2.Text.Trim();
            DateTime BatDau = dateTimePicker1.Value;
            DateTime KetThuc = dateTimePicker2.Value;
            TimeSpan startTime = dateTimePicker3.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker4.Value.TimeOfDay;

            // Kết hợp ngày bắt đầu và thời gian bắt đầu
            DateTime start = BatDau.Date.Add(startTime);

            // Kết hợp ngày kết thúc và thời gian kết thúc
            DateTime end = KetThuc.Date.Add(endTime);

            // Thực hiện cập nhật môn học và kiểm tra kết quả
            bool result = monHoc.CapNhat(malop, tenlop, BatDau, KetThuc, start, end);
            if (result)
            {
                // Hiển thị thông báo cập nhật thành công
                MessageBox.Show("Cập nhật khóa học thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiển thị thông báo cập nhật không thành công
                MessageBox.Show("Cập nhật khóa học không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
