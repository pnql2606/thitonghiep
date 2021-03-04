using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLBD.Class
{
    class Functions
    {
        public static SqlConnection conn; // biến conn để kết nối đến csdl

        public static void Connect()
        {
            conn = new SqlConnection("Data Source=PC-26\\SQLEXPRESS;Initial Catalog=QuanLyBangDia;Integrated Security=True");
            conn.Open();
            if (conn.State == ConnectionState.Open)
                MessageBox.Show("Bạn Đã Kết nối Thành công !", " Wellcome To !");
            else MessageBox.Show("Kết nối không thành công");
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = conn; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        public static DataTable GetDataToTable(string sql)
        {

            //Connect();
            SqlDataAdapter MyData = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
    }
}

