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
    public partial class ThemKhoaHoc : Form
    {
        public ThemKhoaHoc()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút "Thêm Môn Học"
        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng MonHoc để thao tác với cơ sở dữ liệu
            MonHoc monHoc = new MonHoc();

            // Lấy thông tin từ các ô nhập liệu
            string malop = textBox1.Text;
            string tenlop = textBox2.Text;
            DateTime BatDau = dateTimePicker1.Value;
            DateTime KetThuc = dateTimePicker2.Value;
            TimeSpan startTime = dateTimePicker3.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker4.Value.TimeOfDay;

            // Kết hợp ngày bắt đầu và thời gian bắt đầu
            DateTime start = BatDau.Date.Add(startTime);

            // Kết hợp ngày kết thúc và thời gian kết thúc
            DateTime end = KetThuc.Date.Add(endTime);

            // Gọi hàm thêm môn học và kiểm tra kết quả
            bool result = monHoc.AddMonHoc(malop, tenlop, BatDau, KetThuc, start, end);
            if (result)
            {
                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm khóa học thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                // Hiển thị thông báo thất bại
                MessageBox.Show("Thêm khóa học không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Hủy"
        private void button2_Click(object sender, EventArgs e)
        {
            // Đóng form ThemKhoaHoc
            Close();
        }
    }
}
