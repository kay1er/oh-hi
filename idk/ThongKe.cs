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

        private void ThongKe_Load(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            double tongSV = Convert.ToDouble(sinhVien.TongSV());
            double tongSVnam = Convert.ToDouble(sinhVien.TongSVnam());
            double tongSVnu = Convert.ToDouble(sinhVien.TongSVnu());

            double TiLeNam = Math.Round((tongSVnam * 100 / tongSV), 2);
            double TiLeNu = Math.Round((tongSVnu * 100 / tongSV), 2);

            label1.Text = "Tổng sinh viên: " + tongSV.ToString();
            label2.Text = "Nam: " + TiLeNam.ToString() + "%";
            label3.Text = "Nữ: " + TiLeNu.ToString() + "%";
        }

    }
}
