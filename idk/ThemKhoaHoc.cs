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
    public partial class ThemKhoaHoc : Form
    {
        public ThemKhoaHoc()
        {
            InitializeComponent();
        }

        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = new MonHoc();
            string malop = textBox1.Text;
            string tenlop = textBox2.Text;
            DateTime BatDau = dateTimePicker1.Value;
            DateTime KetThuc = dateTimePicker2.Value;
            TimeSpan startTime = dateTimePicker3.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker4.Value.TimeOfDay;
            DateTime start = BatDau.Date.Add(startTime);
            DateTime end = KetThuc.Date.Add(endTime);

            bool result = monHoc.AddMonHoc(malop, tenlop, BatDau, KetThuc, start,end);
            if (result )
            {
                MessageBox.Show("Thêm khóa học thành công","Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khóa học không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
