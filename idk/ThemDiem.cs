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
    public partial class ThemDiem : Form
    {
        MonHoc monHoc = new MonHoc();
        SinhVien sinhVien = new SinhVien();
        Diem score = new Diem();

        // Hàm khởi tạo của form ThemDiem
        public ThemDiem()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Thêm Điểm
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu và combobox
            int masv = Convert.ToInt32(comboBox1.Text);
            string malop = comboBox2.Text.Trim();
            double diem = Convert.ToDouble(textBox1.Text);
            string chuthich = textBox2.Text.Trim();

            // Kiểm tra nếu điểm đã tồn tại
            if (score.diemHSexists(masv, malop))
            {
                // Hiển thị thông báo nếu điểm đã tồn tại
                MessageBox.Show("Điểm của sinh viên này đã tồn tại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Thêm điểm nếu chưa tồn tại
                bool result = score.ThemDiemSo(masv, malop, diem, chuthich);
                if (result)
                {
                    // Hiển thị thông báo thành công
                    MessageBox.Show("Nhập điểm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Hiển thị thông báo thất bại
                    MessageBox.Show("Nhập điểm không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện khi form ThemDiem được tải
        private void ThemDiem_Load(object sender, EventArgs e)
        {
            // Lấy danh sách mã lớp và mã sinh viên từ cơ sở dữ liệu
            DataTable maLopTable = monHoc.getTenLop();
            DataTable maSVTable = sinhVien.getMaSV();

            // Gán dữ liệu vào combobox1 cho mã sinh viên
            comboBox1.DataSource = maSVTable;
            comboBox1.DisplayMember = "Mã sinh viên";
            comboBox1.ValueMember = "Mã sinh viên";

            // Gán dữ liệu vào combobox2 cho mã lớp
            comboBox2.DataSource = maLopTable;
            comboBox2.DisplayMember = "Tên lớp";
            comboBox2.ValueMember = "Tên lớp";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
