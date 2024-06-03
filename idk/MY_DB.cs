using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace idk
{
    // tạo kết nối giữa app và cơ sở dữ liệu
    internal class MY_DB
    {
        //tạo kết nối
      private  MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_student_db");
        //tạo một hàm chức năng để có kết nối tới cơ sở dự liệu
        public MySqlConnection GetConnection() 
        {
           return con;
        }
        public void openConnection()//hàm để mở cổng kết nối với cơ sở dữ liệu
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()//hàm để đóng kết nối với cơ sở dữ liệu
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
