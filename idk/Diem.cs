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
        public bool ThemDiemSo(int masv,string tenlop,double diem,string chuthich)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`Mã sinh viên`, `Tên lớp`, `Điểm số`, `Chú thích`) VALUES (@msv,@tenlop,@diem,@chuthich)",db.GetConnection());
            command.Parameters.Add("@msv",MySqlDbType.Text).Value = masv;
            command.Parameters.Add("@tenlop", MySqlDbType.Text).Value = tenlop;
            command.Parameters.Add("@diem",MySqlDbType.Double).Value = diem;
            command.Parameters.Add("@chuthich",MySqlDbType.VarChar).Value = chuthich;

            db.openConnection();
            if(command.ExecuteNonQuery() == 1) 
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public DataTable DanhSachDiemSo(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool diemHSexists(int masv, string tenlop)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `Mã sinh viên` =@msv AND `Tên lớp` = @tenlop", db.GetConnection());

            command.Parameters.Add("@msv", MySqlDbType.Text).Value = masv;
            command.Parameters.Add("@tenlop", MySqlDbType.Text).Value = tenlop;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count > 0;

        }
        public bool CapNhat(int masv, string tenlop, double diem, string chuthich)
        {
            // Tạo câu lệnh SQL để cập nhật điểm cho sinh viên tại lớp học
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Điểm số`=@diem, `Chú thích`=@chuthich WHERE `Mã sinh viên`=@msv AND `Tên lớp`=@tenlop", db.GetConnection());

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

        public bool XoaDiem(int masv, string tenlop)
        {
            // Tạo câu lệnh SQL để xóa sinh viên
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `Mã sinh viên`=@msv AND `Tên lớp`=@tenlop", db.GetConnection());
            // Gán giá trị cho tham số của câu lệnh SQL
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

        public DataTable HienThiThongTinLop()
        {
            MySqlCommand command = new MySqlCommand("SELECT `Tên lớp`, COUNT(`Mã sinh viên`) AS `Tổng số sinh viên`, AVG(`Điểm số`) AS `Điểm trung bình` FROM `score` GROUP BY `Tên lớp`", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
