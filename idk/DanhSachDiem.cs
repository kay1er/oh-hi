using MySql.Data.MySqlClient;
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
    public partial class DanhSachDiem : Form
    {
        public DanhSachDiem()
        {
            InitializeComponent();
        }

        Diem diem = new Diem();
        MY_DB db = new MY_DB();

        // Sự kiện khi form DanhSachDiem được tải
        private void DanhSachDiem_Load(object sender, EventArgs e)
        {
            // Tạo câu lệnh SQL để lấy danh sách điểm
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = diem.DanhSachDiemSo(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        // Sự kiện khi nhấn nút Tìm Kiếm
        private void button2_Click(object sender, EventArgs e)
        {
            TimKiem find = new TimKiem();
            find.Show(this);
        }

        // Phương thức để thiết lập mã sinh viên và hiển thị điểm của sinh viên đó
        public void SetMaSV(string maSV)
        {
            // Tạo câu lệnh SQL để tìm kiếm điểm theo mã sinh viên
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `Mã sinh viên` = @msv", db.GetConnection());
            command.Parameters.Add("@msv", MySqlDbType.VarChar).Value = maSV;
            dataGridView1.DataSource = diem.DanhSachDiemSo(command);
        }

        // Sự kiện khi nhấn nút Làm Mới
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo câu lệnh SQL để lấy lại danh sách điểm
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = diem.DanhSachDiemSo(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        // Sự kiện khi người dùng nhấp đúp chuột vào một hàng trong DataGridView
        private void DoubleClick_Click(object sender, EventArgs e)
        {
            // Tạo form chỉnh sửa điểm và gán giá trị từ DataGridView vào các ô nhập liệu
            ChinhSuaDiem suaDiem = new ChinhSuaDiem();
            suaDiem.comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            suaDiem.comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            suaDiem.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            suaDiem.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            suaDiem.Show();
        }
    }
}
