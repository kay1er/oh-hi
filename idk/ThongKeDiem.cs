using System;
using System.Data;
using System.Windows.Forms;

namespace idk
{
    public partial class ThongKeDiem : Form
    {
        Diem diem = new Diem(); // Thực thể của lớp Diem để quản lý dữ liệu điểm

        public ThongKeDiem()
        {
            InitializeComponent();
            
        }

        // Sự kiện xảy ra khi form được load
        private void ThongKeDiem_Load(object sender, EventArgs e)
        {
            LoadClassData(); // Load dữ liệu lớp khi form được load
        }

        // Phương thức để load dữ liệu lớp vào DataGridView
        private void LoadClassData()
        {
            try
            {
                DataTable thongTinLop = diem.HienThiThongTinLop(); // Truy xuất thông tin thống kê về các lớp
                dataGridView1.DataSource = thongTinLop; // Đặt nguồn dữ liệu của DataGridView để hiển thị thông tin thống kê
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có ngoại lệ xảy ra khi load dữ liệu
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
