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
    public partial class DanhSachKhoaHoc : Form
    {
        public DanhSachKhoaHoc()
        {
            InitializeComponent();
        }

        MonHoc monHoc = new MonHoc();
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = monHoc.DanhSachMonHoc(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = monHoc.DanhSachMonHoc(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            ChinhSuaMonHoc chinhsua = new ChinhSuaMonHoc();

            // Assuming these are the correct names of your controls on the ChinhSuaMonHoc form
            chinhsua.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            chinhsua.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            chinhsua.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            chinhsua.dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);

            // For time, handle TimeSpan correctly if it exists as a TimeSpan object
            TimeSpan startTime = (TimeSpan)dataGridView1.CurrentRow.Cells[4].Value;
            TimeSpan endTime = (TimeSpan)dataGridView1.CurrentRow.Cells[5].Value;

            // Convert TimeSpan to DateTime for DateTimePickers (assuming today’s date)
            DateTime today = DateTime.Today;
            chinhsua.dateTimePicker3.Value = today.Add(startTime);
            chinhsua.dateTimePicker4.Value = today.Add(endTime);

            chinhsua.Show();
        }



    }
}
