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
        SinhVien sinhvien = new SinhVien();
        private void SinhVienList_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = sinhvien.DanhSach(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            XoaHoacChinhSua xoaSV = new XoaHoacChinhSua();
            xoaSV.maSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            xoaSV.HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            xoaSV.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            xoaSV.QueQuan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Nữ")
            {
                xoaSV.radioButton2.Checked = true;
            }
            xoaSV.KhoaHoc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            xoaSV.Lop.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            xoaSV.DiaChi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            xoaSV.SDT.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            xoaSV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = sinhvien.DanhSach(command);
            dataGridView1.AllowUserToAddRows = false;
        }
        
    }
}
