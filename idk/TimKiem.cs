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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        private void TimKiem_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT `Mã sinh viên` FROM `student`", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "Mã sinh viên";
            comboBox1.ValueMember = "Mã sinh viên";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                string selectedMaSV = comboBox1.SelectedValue.ToString();

                DanhSachDiem parentForm = this.Owner as DanhSachDiem;
                if (parentForm != null)
                {
                    parentForm.SetMaSV(selectedMaSV);
                }

                this.Close();
            }
            else
            {
                // Xử lý trường hợp không có giá trị được chọn trong comboBox1
                MessageBox.Show("Vui lòng chọn một giá trị trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
