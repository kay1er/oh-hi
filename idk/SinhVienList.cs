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
    public partial class SinhVienList : Form
    {
        public SinhVienList()
        {
            InitializeComponent();
        }

        // Tạo một đối tượng SinhVien để thao tác với cơ sở dữ liệu
        SinhVien sinhvien = new SinhVien();

        // Hàm xử lý sự kiện khi form SinhVienList được tải
        private void SinhVienList_Load(object sender, EventArgs e)
        {
            // Tạo câu lệnh SQL để lấy tất cả sinh viên
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");

            // Thiết lập thuộc tính của dataGridView1 để chỉ đọc và đặt chiều cao hàng
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;

            // Gán nguồn dữ liệu cho dataGridView1 từ hàm DanhSach của đối tượng sinhvien
            dataGridView1.DataSource = sinhvien.DanhSach(command);

            // Không cho phép người dùng thêm hàng mới trong dataGridView1
            dataGridView1.AllowUserToAddRows = false;
        }

        // Hàm xử lý sự kiện khi người dùng nhấp đúp chuột vào một hàng trong dataGridView1
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Tạo một form mới để xóa hoặc chỉnh sửa thông tin sinh viên
            XoaHoacChinhSua xoaSV = new XoaHoacChinhSua();

            // Gán giá trị của các ô trong hàng được chọn cho các điều khiển tương ứng trên form XoaHoacChinhSua
            xoaSV.maSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            xoaSV.HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            xoaSV.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            xoaSV.QueQuan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            // Kiểm tra giới tính và gán giá trị cho radioButton tương ứng
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Nữ")
            {
                xoaSV.radioButton2.Checked = true;
            }

            xoaSV.KhoaHoc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            xoaSV.Lop.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            xoaSV.DiaChi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            xoaSV.SDT.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            // Hiển thị form XoaHoacChinhSua
            xoaSV.Show();
        }

        // Hàm xử lý sự kiện khi người dùng nhấn nút (giả sử là để làm mới danh sách)
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo câu lệnh SQL để lấy tất cả sinh viên
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");

            // Thiết lập thuộc tính của dataGridView1 để chỉ đọc và đặt chiều cao hàng
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;

            // Gán nguồn dữ liệu cho dataGridView1 từ hàm DanhSach của đối tượng sinhvien
            dataGridView1.DataSource = sinhvien.DanhSach(command);

            // Không cho phép người dùng thêm hàng mới trong dataGridView1
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
