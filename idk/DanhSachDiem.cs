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
        private void DanhSachDiem_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = diem.DanhSachDiemSo(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimKiem find = new TimKiem();
            find.Show(this);

        }
        public void SetMaSV(string maSV)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `Mã sinh viên` = @msv", db.GetConnection());
            command.Parameters.Add("@msv", MySqlDbType.VarChar).Value = maSV;
            dataGridView1.DataSource = diem.DanhSachDiemSo(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = diem.DanhSachDiemSo(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            ChinhSuaDiem suaDiem = new ChinhSuaDiem();
            suaDiem.comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            suaDiem.comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            suaDiem.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            suaDiem.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            suaDiem.Show();
        }
    }
}
