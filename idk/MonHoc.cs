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
        MY_DB db = new MY_DB();
        public bool AddMonHoc(string malop,string tenlop,DateTime BatDau,DateTime KetThuc,DateTime start,DateTime end)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`Mã lớp`, `Tên lớp`, `Ngày bắt đầu`, `Ngày kết thúc`, `Thời gian bắt đầu`, `Thời gian kết thúc`) VALUES (@ma,@ten,@start,@end,@timestart,@timeend)", db.GetConnection());
            command.Parameters.Add("@ma",MySqlDbType.VarChar).Value = malop;
            command.Parameters.Add("@ten",MySqlDbType.VarChar).Value = tenlop;
            command.Parameters.Add("@start",MySqlDbType.Date).Value = BatDau;
            command.Parameters.Add("@end", MySqlDbType.Date).Value = KetThuc;
            command.Parameters.Add("@timestart",MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@timeend", MySqlDbType.DateTime).Value = end;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public DataTable DanhSachMonHoc(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool CapNhat(string malop, string tenlop, DateTime BatDau, DateTime KetThuc, DateTime start, DateTime end)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `Mã lớp`=@ma ,`Tên lớp`=@ten, `Ngày bắt đầu`=@batDau, `Ngày kết thúc`=@ketThuc, `Thời gian bắt đầu`=@timestart, `Thời gian kết thúc`=@timeend WHERE `Mã lớp`=@ma", db.GetConnection());

            command.Parameters.Add("@ma", MySqlDbType.VarChar).Value = malop;
            command.Parameters.Add("@ten", MySqlDbType.VarChar).Value = tenlop;
            command.Parameters.Add("@batDau", MySqlDbType.DateTime).Value = BatDau;
            command.Parameters.Add("@ketThuc", MySqlDbType.DateTime).Value = KetThuc;
            command.Parameters.Add("@timestart", MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@timeend", MySqlDbType.DateTime).Value = end;

            db.openConnection();

            bool isUpdated = command.ExecuteNonQuery() == 1;

            db.closeConnection();

            return isUpdated;
        }
        public bool XoaMonHoc(string malop)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `Mã lớp`=@ma", db.GetConnection());
            command.Parameters.Add("@ma", MySqlDbType.VarChar).Value = malop;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public DataTable getMaLop()
        {
            MySqlCommand command = new MySqlCommand("SELECT `Tên lớp` FROM `course`", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
