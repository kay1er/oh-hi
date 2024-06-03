using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.VisualBasic.Logging;

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
        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            int masv = Convert.ToInt32(comboBox1.Text);
            string malop = comboBox2.Text.Trim();
            double diem = Convert.ToDouble(textBox2.Text);
            string chuthich = textBox3.Text.Trim();
            bool result = score.CapNhat(masv, malop, diem, chuthich);
            if (result)
            {
                MessageBox.Show("Cập nhập điểm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhập điểm không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChinhSuaDiem_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int masv = Convert.ToInt32(comboBox1.Text);
            string malop = comboBox2.Text.Trim();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.XoaDiem(masv,malop))
                {
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }
    }
}
