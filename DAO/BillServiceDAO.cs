using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.DAO
{
    public class BillServiceDAO
    {
        public static bool add(BillService billService)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "insert into hoadondichvu values(@MaHD,@MaDichVu,@SoLuong)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@MaHD", billService.MaHD);
                command.Parameters.AddWithValue("@MaDichVu", billService.MaDichVu);
                command.Parameters.AddWithValue("@SoLuong", billService.SoLuong);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }
    }
}
