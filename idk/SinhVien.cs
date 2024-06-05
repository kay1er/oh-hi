using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk
{
    internal class SinhVien
    {
        // Tạo một đối tượng MY_DB để kết nối với cơ sở dữ liệu
        MY_DB db = new MY_DB();

        // Phương thức thêm sinh viên vào cơ sở dữ liệu
        public bool AddSV(int masv, string hoten, DateTime ngaysinh, string quequan, string gioitinh, int khoa, string lop, string diachi, int sdt)
        {
            // Tạo câu lệnh SQL để chèn sinh viên mới vào bảng "student"
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`Mã sinh viên`, `Họ tên`, `Ngày sinh`, `Quê quán`, `Giới tính`, `Khóa`, `Ngành`, `Địa chỉ`, `Số điện thoại`) VALUES (@SV,@ht,@birth,@country,@gen,@kho,@class,@add,@phone)", db.GetConnection());
            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@SV", MySqlDbType.Int32).Value = masv;
            command.Parameters.Add("@ht", MySqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@birth", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = quequan;
            command.Parameters.Add("@gen", MySqlDbType.Text).Value = gioitinh;
            command.Parameters.Add("@kho", MySqlDbType.Int32).Value = khoa;
            command.Parameters.Add("@class", MySqlDbType.VarChar).Value = lop;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@phone", MySqlDbType.Int32).Value = sdt;

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

        // Phương thức lấy danh sách sinh viên từ cơ sở dữ liệu
        public DataTable DanhSach(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Phương thức cập nhật thông tin sinh viên
        public bool CapNhat(int masv, string hoten, DateTime ngaysinh, string quequan, string gioitinh, int khoa, string lop, string diachi, int sdt)
        {
            // Tạo câu lệnh SQL để cập nhật thông tin sinh viên
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `Họ tên`=@ht, `Ngày sinh`=@birth, `Quê quán`=@country, `Giới tính`=@gen, `Khóa`=@kho, `Ngành`=@class, `Địa chỉ`=@add, `Số điện thoại`=@phone WHERE `Mã sinh viên`=@SV", db.GetConnection());

            // Gán giá trị cho các tham số của câu lệnh SQL
            command.Parameters.Add("@SV", MySqlDbType.Int32).Value = masv;
            command.Parameters.Add("@ht", MySqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@birth", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = quequan;
            command.Parameters.Add("@gen", MySqlDbType.Text).Value = gioitinh;
            command.Parameters.Add("@kho", MySqlDbType.Int32).Value = khoa;
            command.Parameters.Add("@class", MySqlDbType.VarChar).Value = lop;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@phone", MySqlDbType.Int32).Value = sdt;

            // Mở kết nối cơ sở dữ liệu
            db.openConnection();

            // Thực hiện câu lệnh SQL và kiểm tra kết quả
            bool isUpdated = command.ExecuteNonQuery() == 1;

            // Đóng kết nối cơ sở dữ liệu
            db.closeConnection();

            return isUpdated;
        }

        // Phương thức xóa sinh viên khỏi cơ sở dữ liệu
        public bool XoaSV(string masv)
        {
            // Tạo câu lệnh SQL để xóa sinh viên
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `Mã sinh viên`=@SV", db.GetConnection());
            // Gán giá trị cho tham số của câu lệnh SQL
            command.Parameters.Add("@SV", MySqlDbType.VarChar).Value = masv;

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

        // Phương thức thống kê số lượng sinh viên dựa trên câu lệnh SQL
        public string thongKe(string query)
        {
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            // Mở kết nối cơ sở dữ liệu
            db.openConnection();
            // Thực hiện câu lệnh SQL và lấy kết quả
            string count = command.ExecuteScalar().ToString();
            // Đóng kết nối cơ sở dữ liệu
            db.closeConnection();
            return count;
        }

        // Phương thức thống kê tổng số sinh viên
        public string TongSV()
        {
            return thongKe("SELECT COUNT(*) FROM `student`");
        }

        // Phương thức thống kê tổng số sinh viên nam
        public string TongSVnam()
        {
            return thongKe("SELECT COUNT(*) FROM `student` WHERE `Giới tính` = 'Nam'");
        }

        // Phương thức thống kê tổng số sinh viên nữ
        public string TongSVnu()
        {
            return thongKe("SELECT COUNT(*) FROM `student` WHERE `Giới tính` = 'Nữ'");
        }
        public DataTable getMaSV()
        {
            MySqlCommand command = new MySqlCommand("SELECT `Mã sinh viên` FROM `student`", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
