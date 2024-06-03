using System;
using System.Data;
using System.Windows.Forms;

namespace idk
{
    public partial class ThongKeDiem : Form
    {
        Diem diem = new Diem();

        public ThongKeDiem()
        {
            InitializeComponent();
            this.Load += new EventHandler(ThongKeDiem_Load); // Attach the load event handler
        }

        private void ThongKeDiem_Load(object sender, EventArgs e)
        {
            LoadClassData();
        }

        private void LoadClassData()
        {
            try
            {
                DataTable thongTinLop = diem.HienThiThongTinLop();
                dataGridView1.DataSource = thongTinLop;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
