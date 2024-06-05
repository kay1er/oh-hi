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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Mở form để thêm sinh viên mới
        private void thêmSinhViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSinhVien addSV = new ThemSinhVien();
            addSV.Show(this);
        }

        // Mở form danh sách sinh viên
        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienList sinhVienList = new SinhVienList();
            sinhVienList.Show(this);
        }

        // Mở form thống kê
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.Show(this);
        }

        // Mở form để thêm khóa học mới
        private void thêmKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemKhoaHoc course = new ThemKhoaHoc();
            course.Show(this);
        }

        // Mở form danh sách khóa học
        private void danhSáchKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhoaHoc list = new DanhSachKhoaHoc();
            list.Show(this);
        }

        // Mở form danh sách điểm
        private void danhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DanhSachDiem listDiem = new DanhSachDiem();
            listDiem.Show(this);
        }

        // Mở form để thêm điểm mới
        private void thêmĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemDiem addDiem = new ThemDiem();
            addDiem.Show(this);
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeDiem thongKeDiem = new ThongKeDiem();
            thongKeDiem.Show(this);
        }

        private void chỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaDiem edit = new ChinhSuaDiem();
            edit.Show(this);
        }
    }
}
