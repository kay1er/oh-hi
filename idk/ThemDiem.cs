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
        public ThemDiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int masv = Convert.ToInt32(comboBox1.Text);
            string malop = comboBox2.Text.Trim();
            double diem = Convert.ToDouble(textBox1.Text);
            string chuthich = textBox2.Text.Trim();

            // Kiểm tra nếu điểm đã tồn tại
            if (score.diemHSexists(masv, malop))
            {
                MessageBox.Show("Điểm của sinh viên này đã tồn tại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Thêm điểm nếu chưa tồn tại
                bool result = score.ThemDiemSo(masv, malop, diem, chuthich);
                if (result)
                {
                    MessageBox.Show("Nhập điểm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nhập điểm không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void ThemDiem_Load(object sender, EventArgs e)
        {
            DataTable maLopTable = monHoc.getMaLop();
            DataTable maSVTable = sinhVien.getMaSV();
            comboBox1.DataSource = maSVTable;
            comboBox1.DisplayMember = "Mã sinh viên";
            comboBox1.ValueMember = "Mã sinh viên";
            comboBox2.DataSource = maLopTable;
            comboBox2.DisplayMember = "Tên lớp";
            comboBox2.ValueMember = "Tên lớp";
        }
    }
}
