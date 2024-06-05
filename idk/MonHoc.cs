using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace idk
{
    internal class MonHoc
    {
        // Tạo một đối tượng MY_DB để quản lý kết nối cơ sở dữ liệu
        MY_DB db = new MY_DB();

        // Hàm thêm môn học mới
        public bool AddMonHoc(string malop, string tenlop, DateTime BatDau, DateTime KetThuc, DateTime start, DateTime end)
        {
            // Tạo câu lệnh SQL để thêm môn học
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`Mã lớp`, `Tên lớp`, `Ngày bắt đầu`, `Ngày kết thúc`, `Thời gian bắt đầu`, `Thời gian kết thúc`) VALUES (@ma, @ten, @start, @end, @timestart, @timeend)", db.GetConnection());

            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@ma", MySqlDbType.VarChar).Value = malop;
            command.Parameters.Add("@ten", MySqlDbType.VarChar).Value = tenlop;
            command.Parameters.Add("@start", MySqlDbType.Date).Value = BatDau;
            command.Parameters.Add("@end", MySqlDbType.Date).Value = KetThuc;
            command.Parameters.Add("@timestart", MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@timeend", MySqlDbType.DateTime).Value = end;

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

        // Hàm lấy danh sách môn học theo câu lệnh SQL
        public DataTable DanhSachMonHoc(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Hàm cập nhật thông tin môn học
        public bool CapNhat(string malop, string tenlop, DateTime BatDau, DateTime KetThuc, DateTime start, DateTime end)
        {
            // Tạo câu lệnh SQL để cập nhật thông tin môn học
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `Mã lớp`=@ma, `Tên lớp`=@ten, `Ngày bắt đầu`=@batDau, `Ngày kết thúc`=@ketThuc, `Thời gian bắt đầu`=@timestart, `Thời gian kết thúc`=@timeend WHERE `Mã lớp`=@ma", db.GetConnection());

            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@ma", MySqlDbType.VarChar).Value = malop;
            command.Parameters.Add("@ten", MySqlDbType.VarChar).Value = tenlop;
            command.Parameters.Add("@batDau", MySqlDbType.DateTime).Value = BatDau;
            command.Parameters.Add("@ketThuc", MySqlDbType.DateTime).Value = KetThuc;
            command.Parameters.Add("@timestart", MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@timeend", MySqlDbType.DateTime).Value = end;

            // Mở kết nối cơ sở dữ liệu
            db.openConnection();

            // Thực hiện câu lệnh SQL và kiểm tra kết quả
            bool isUpdated = command.ExecuteNonQuery() == 1;

            // Đóng kết nối cơ sở dữ liệu
            db.closeConnection();

            return isUpdated;
        }

        // Hàm xóa môn học
        public bool XoaMonHoc(string malop)
        {
            // Tạo câu lệnh SQL để xóa môn học
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `Mã lớp`=@ma", db.GetConnection());

            // Gán giá trị cho tham số của câu lệnh SQL
            command.Parameters.Add("@ma", MySqlDbType.VarChar).Value = malop;

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

        // Hàm lấy danh sách tên lớp
        public DataTable getTenLop()
        {
            // Tạo câu lệnh SQL để lấy tên lớp
            MySqlCommand command = new MySqlCommand("SELECT `Tên lớp` FROM `course`", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
