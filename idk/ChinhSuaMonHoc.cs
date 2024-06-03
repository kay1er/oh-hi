using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace idk
{
    public partial class ChinhSuaMonHoc : Form
    {
        public ChinhSuaMonHoc()
        {
            InitializeComponent();
        }
        MonHoc monHoc = new MonHoc();
        private void button2_Click(object sender, EventArgs e)
        {
            string malop = Convert.ToString(textBox1.Text);
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (monHoc.XoaMonHoc(malop))
                {
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                    dateTimePicker3.Value = DateTime.Now;
                    dateTimePicker4.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            string malop = textBox1.Text.Trim();
            string tenlop = textBox2.Text.Trim();
            DateTime BatDau = dateTimePicker1.Value;
            DateTime KetThuc = dateTimePicker2.Value;
            TimeSpan startTime = dateTimePicker3.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker4.Value.TimeOfDay;
            DateTime start = BatDau.Date.Add(startTime);
            DateTime end = KetThuc.Date.Add(endTime);

            bool result = monHoc.CapNhat(malop, tenlop, BatDau, KetThuc, start, end);
            if (result)
            {
                MessageBox.Show("Cập nhật khóa học thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật khóa học không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
