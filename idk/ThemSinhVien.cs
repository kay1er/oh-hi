using System;
using System.Windows.Forms;

namespace idk
{
    public partial class ThemSinhVien : Form
    {
        // Hàm khởi tạo cho form ThemSinhVien
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi nút thêm sinh viên được nhấn
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng SinhVien mới
            SinhVien sinhVien = new SinhVien();

            // Lấy dữ liệu từ các trường nhập liệu
            int masv = Convert.ToInt32(maSV.Text.Trim());
            string hoten = HoTen.Text.Trim();
            DateTime ngaysinh = dateTimePicker1.Value;
            string quequan = QueQuan.Text.Trim();
            string gioitinh = "Nam";
            string lop = Lop.Text.Trim();
            int khoa = Convert.ToInt32(KhoaHoc.Text.Trim());
            string diachi = DiaChi.Text.Trim();
            int sdt = Convert.ToInt32(SDT.Text.Trim());

            // Kiểm tra nếu radioButton2 (giới tính Nữ) được chọn
            if (radioButton2.Checked)
            {
                gioitinh = "Nữ";
            }

            // Kiểm tra tính hợp lệ của form trước khi thêm sinh viên
            if (IsFormValid())
            {
                // Thêm sinh viên vào hệ thống
                bool result = sinhVien.AddSV(masv, hoten, ngaysinh, quequan, gioitinh, khoa, lop, diachi, sdt);
                if (result)
                {
                    // Thông báo thêm sinh viên thành công
                    MessageBox.Show("Thêm sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    // Thông báo thêm sinh viên không thành công
                    MessageBox.Show("Thêm sinh viên không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Thông báo khi các trường dữ liệu còn trống
                MessageBox.Show("Điền đầy đủ các dòng còn trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm kiểm tra tính hợp lệ của form
        bool IsFormValid()
        {
            if ((HoTen.Text.Trim() == "") ||
                (Lop.Text.Trim() == "") ||
                (QueQuan.Text.Trim() == "") ||
                (SDT.Text.Trim() == "") ||
                (KhoaHoc.Text.Trim() == "") ||
                (DiaChi.Text.Trim() == "") ||
                (maSV.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Xử lý sự kiện khi người dùng rời khỏi trường ngày sinh
        private void ns_leave(object sender, EventArgs e)
        {
            DateTime ngaysinh = dateTimePicker1.Value;
            int namsinh = ngaysinh.Year;
            int namHienTai = DateTime.Now.Year;

            // Kiểm tra năm sinh hợp lệ (không lớn hơn 100 tuổi và không nhỏ hơn 10 tuổi)
            if ((namHienTai - namsinh) > 100 || (namHienTai - namsinh) < 10)
            {
                MessageBox.Show("Năm sinh không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nút đóng form được nhấn
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maSV_Leave(object sender, EventArgs e)
        {
            try
            {
                int masv = Convert.ToInt32(maSV.Text.Trim());
            }
            catch (FormatException d)
            {
                MessageBox.Show("Mã sinh viên không họp lệ","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
