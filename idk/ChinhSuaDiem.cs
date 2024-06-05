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
    public partial class ChinhSuaDiem : Form
    {
        public ChinhSuaDiem()
        {
            InitializeComponent();
        }
        MonHoc monHoc = new MonHoc();
        SinhVien sinhVien = new SinhVien();
        Diem score = new Diem();

        // Xử lý sự kiện khi nhấn nút "Thêm Điểm"
        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            
        }

        // Xử lý sự kiện khi Form được tải
        private void ChinhSuaDiem_Load(object sender, EventArgs e)
        {
            // Lấy danh sách Mã Sinh viên và Tên lớp từ cơ sở dữ liệu
            DataTable maLopTable = monHoc.getTenLop();
            DataTable maSVTable = sinhVien.getMaSV();

            // Gán danh sách Mã Sinh viên và Tên lớp cho các ComboBox trên giao diện
            comboBox1.DataSource = maSVTable;
            comboBox1.DisplayMember = "Mã sinh viên";
            comboBox1.ValueMember = "Mã sinh viên";
            comboBox2.DataSource = maLopTable;
            comboBox2.DisplayMember = "Tên lớp";
            comboBox2.ValueMember = "Tên lớp";
        }

        // Xử lý sự kiện khi nhấn nút "Xóa Điểm"
        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy Mã sinh viên và Tên lớp từ các ComboBox trên giao diện
            int masv = Convert.ToInt32(comboBox1.Text);
            string malop = comboBox2.Text.Trim();

            // Kiểm tra xem điểm tồn tại trong danh sách
            if (score.diemHSexists(masv, malop))
            {
                // Hiển thị hộp thoại xác nhận trước khi thực hiện xóa
                if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Gọi phương thức xóa điểm từ đối tượng score
                    if (score.XoaDiem(masv, malop))
                    {
                        // Hiển thị thông báo nếu xóa thành công và đóng Form
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        // Hiển thị thông báo nếu xóa không thành công và đóng Form
                        MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu điểm không tồn tại trong danh sách
                MessageBox.Show("Điểm không tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChinhSuaDiem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên giao diện
            int masv = Convert.ToInt32(comboBox1.Text);
            string malop = comboBox2.Text.Trim();
            double diem = Convert.ToDouble(textBox2.Text);
            string chuthich = textBox3.Text.Trim();

            // Kiểm tra xem điểm đã tồn tại trong danh sách chưa
            if (score.diemHSexists(masv, malop))
            {
                // Nếu không tồn tại, thực hiện thêm điểm
                bool result = score.CapNhat(masv, malop, diem, chuthich);
                if (result)
                {
                    // Hiển thị thông báo nếu sửa điểm thành công
                    MessageBox.Show("Chỉnh sửa điểm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Hiển thị thông báo nếu sửa điểm không thành công
                    MessageBox.Show("Chỉnh sửa điểm không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Hiển thị thông báo nếu điểm không tồn tại trong danh sách
                MessageBox.Show("Điểm của sinh viên không tồn tại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
