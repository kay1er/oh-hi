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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        // Hàm xử lý sự kiện khi form ThongKe được tải
        private void ThongKe_Load(object sender, EventArgs e)
        {
            // Tạo một đối tượng SinhVien để thao tác với cơ sở dữ liệu
            SinhVien sinhVien = new SinhVien();

            // Lấy tổng số sinh viên
            double tongSV = Convert.ToDouble(sinhVien.TongSV());

            // Lấy tổng số sinh viên nam
            double tongSVnam = Convert.ToDouble(sinhVien.TongSVnam());

            // Lấy tổng số sinh viên nữ
            double tongSVnu = Convert.ToDouble(sinhVien.TongSVnu());

            // Tính tỉ lệ sinh viên nam và sinh viên nữ
            double TiLeNam = Math.Round((tongSVnam * 100 / tongSV), 2);
            double TiLeNu = Math.Round((tongSVnu * 100 / tongSV), 2);

            // Hiển thị thông tin thống kê lên các nhãn (label)
            label1.Text = "Tổng sinh viên: " + tongSV.ToString();
            label2.Text = "Nam: " + TiLeNam.ToString() + "%";
            label3.Text = "Nữ: " + TiLeNu.ToString() + "%";
        }
    }
}
