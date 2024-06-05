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
    public partial class XoaHoacChinhSua : Form
    {
        public XoaHoacChinhSua()
        {
            InitializeComponent();
        }
        SinhVien sinhVien = new SinhVien();
        private void Find_Click(object sender, EventArgs e)
        {
            
        }
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
        private void Edit_Click(object sender, EventArgs e)
        {

            SinhVien sinhVien = new SinhVien();
            int masv = Convert.ToInt32(maSV.Text.Trim());
            string hoten = HoTen.Text.Trim();
            DateTime ngaysinh = dateTimePicker1.Value;
            string quequan = QueQuan.Text.Trim();
            string gioitinh = "Nam";
            string lop = Lop.Text.Trim();
            int khoa = Convert.ToInt32(KhoaHoc.Text.Trim());
            string diachi = DiaChi.Text.Trim();
            int sdt = Convert.ToInt32(SDT.Text.Trim());

            if (radioButton2.Checked)
            {
                gioitinh = "Nữ";
            }
            
            int namsinh = ngaysinh.Year;
            int namHienTai = DateTime.Now.Year;

            if ((namHienTai - namsinh) > 100 || (namHienTai - namsinh) < 10)
            {
                MessageBox.Show("Năm sinh không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (IsFormValid())
            {
                bool result = sinhVien.CapNhat(masv, hoten, ngaysinh, quequan, gioitinh, khoa, lop, diachi, sdt);
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không sinh viên không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ các dòng còn trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void Delete_Click(object sender, EventArgs e)
        {
            string masv = Convert.ToString(maSV.Text);
            if(MessageBox.Show("Bạn có muốn xóa không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sinhVien.XoaSV(masv))
                {
                    MessageBox.Show("Xóa thành công","Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maSV.Text = "";
                    HoTen.Text = "";
                    QueQuan.Text = "";
                    KhoaHoc.Text = "";
                    Lop.Text = "";
                    SDT.Text = "";
                    DiaChi.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
