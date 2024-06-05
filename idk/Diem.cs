using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace idk
{
    internal class Diem
    {
        MY_DB db = new MY_DB();

        // Hàm thêm điểm số cho sinh viên
        public bool ThemDiemSo(int masv, string tenlop, double diem, string chuthich)
        {
            // Tạo câu lệnh SQL để thêm điểm số
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`Mã sinh viên`, `Tên lớp`, `Điểm số`, `Chú thích`) VALUES (@msv, @tenlop, @diem, @chuthich)", db.GetConnection());

            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@msv", MySqlDbType.Text).Value = masv;
            command.Parameters.Add("@tenlop", MySqlDbType.Text).Value = tenlop;
            command.Parameters.Add("@diem", MySqlDbType.Double).Value = diem;
            command.Parameters.Add("@chuthich", MySqlDbType.VarChar).Value = chuthich;

            // Mở kết nối cơ sở dữ liệu
            db.openConnection();

            // Thực hiện câu lệnh SQL và kiểm tra kết quả
            if (command.ExecuteNonQuery() == 1)
            {
                // Đóng kết nối cơ sở dữ liệu nếu thành công
                db.closeConnection();
                return true;
            }
            else
            {
                // Đóng kết nối cơ sở dữ liệu nếu thất bại
                db.closeConnection();
                return false;
            }
        }

        // Hàm lấy danh sách điểm số theo câu lệnh SQL
        public DataTable DanhSachDiemSo(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Hàm kiểm tra xem điểm của học sinh có tồn tại không
        public bool diemHSexists(int masv, string tenlop)
        {
            // Tạo câu lệnh SQL để kiểm tra sự tồn tại của điểm
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `Mã sinh viên` = @msv AND `Tên lớp` = @tenlop", db.GetConnection());

            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@msv", MySqlDbType.Text).Value = masv;
            command.Parameters.Add("@tenlop", MySqlDbType.Text).Value = tenlop;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Trả về true nếu có kết quả, ngược lại trả về false
            return table.Rows.Count > 0;
        }

        // Hàm cập nhật điểm số cho sinh viên
        public bool CapNhat(int masv, string tenlop, double diem, string chuthich)
        {
            // Tạo câu lệnh SQL để cập nhật điểm số
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Điểm số` = @diem, `Chú thích` = @chuthich WHERE `Mã sinh viên` = @msv AND `Tên lớp` = @tenlop", db.GetConnection());

            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@msv", MySqlDbType.Int32).Value = masv;
            command.Parameters.Add("@tenlop", MySqlDbType.VarChar).Value = tenlop;
            command.Parameters.Add("@diem", MySqlDbType.Double).Value = diem;
            command.Parameters.Add("@chuthich", MySqlDbType.VarChar).Value = chuthich;

            // Mở kết nối cơ sở dữ liệu
            db.openConnection();

            // Thực hiện câu lệnh SQL và kiểm tra kết quả
            bool isUpdated = command.ExecuteNonQuery() == 1;

            // Đóng kết nối cơ sở dữ liệu
            db.closeConnection();

            return isUpdated;
        }

        // Hàm xóa điểm số của sinh viên
        public bool XoaDiem(int masv, string tenlop)
        {
            // Tạo câu lệnh SQL để xóa điểm số
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `Mã sinh viên` = @msv AND `Tên lớp` = @tenlop", db.GetConnection());

            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@msv", MySqlDbType.Int32).Value = masv;
            command.Parameters.Add("@tenlop", MySqlDbType.VarChar).Value = tenlop;

            // Mở kết nối cơ sở dữ liệu
            db.openConnection();

            // Thực hiện câu lệnh SQL và kiểm tra kết quả
            if (command.ExecuteNonQuery() == 1)
            {
                // Đóng kết nối cơ sở dữ liệu nếu thành công
                db.closeConnection();
                return true;
            }
            else
            {
                // Đóng kết nối cơ sở dữ liệu nếu thất bại
                db.closeConnection();
                return false;
            }
        }

        // Hàm hiển thị thông tin lớp học
        public DataTable HienThiThongTinLop()
        {
            // Tạo câu lệnh SQL để lấy thông tin lớp học
            MySqlCommand command = new MySqlCommand("SELECT `Tên lớp`, COUNT(`Mã sinh viên`) AS `Tổng số sinh viên`, AVG(`Điểm số`) AS `Điểm trung bình` FROM `score` GROUP BY `Tên lớp`", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
