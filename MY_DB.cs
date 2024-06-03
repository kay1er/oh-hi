using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace idk
{
    internal class MY_DB
    {
      private  MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_student_db");

        public MySqlConnection GetConnection() 
        {
           return con;
        }
        public void openConnection()//mo ket noi voi sql
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()//dong ket noi voi sql
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
