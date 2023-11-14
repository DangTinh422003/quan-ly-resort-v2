using System;
using MySql.Data.MySqlClient;
using quan_ly_resort_v2.common.constants;
using quan_ly_resort_v2.model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.RightsManagement;

namespace quan_ly_resort_v2.DAO
{
    internal class VoucherDAO
    {
        public VoucherDAO() {}

        public static List<Voucher> GetVouchers()
        {
            List<Voucher> vouchers = new List<Voucher>();
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "SELECT * FROM voucher";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Voucher voucher = new Voucher
                    {
                        MaVoucher = reader["MaVoucher"].ToString(),
                        GiamGia = Convert.ToInt32(reader["GiamGia"]),
                        StartDate = Convert.ToDateTime(reader["StartDate"]),
                        EndDate = Convert.ToDateTime(reader["EndDate"]),
                        Count = Convert.ToInt32(reader["Count"])
                };

                    vouchers.Add(voucher);
                }

                conn.Close();

                return vouchers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool addNewVoucher(Voucher maVoucher)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "insert into voucher values(@MaVoucher,@GiamGia,@StartDate,@EndDate,@SoLanDung)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaVoucher", maVoucher.MaVoucher);
                cmd.Parameters.AddWithValue("@GiamGia", maVoucher.GiamGia);
                cmd.Parameters.AddWithValue("@StartDate", maVoucher.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", maVoucher.EndDate);
                cmd.Parameters.AddWithValue("@SoLanDung", maVoucher.Count);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }
        public static bool UpdateVoucher(Voucher voucher)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString());
                conn.Open();

                string updateQuery = "UPDATE voucher SET MaVoucher = @MaVoucher, GiamGia = @GiamGia, StartDate = @StartDate, EndDate = @EndDate, Count = @SoLanDung WHERE MaVoucher = @MaVoucher";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@MaVoucher", voucher.MaVoucher);
                cmd.Parameters.AddWithValue("@GiamGia", voucher.GiamGia);
                cmd.Parameters.AddWithValue("@StartDate", voucher.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", voucher.EndDate);
                cmd.Parameters.AddWithValue("@SoLanDung", voucher.Count);

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool DeleteVoucher(string mavoucher)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(MyConstants.getInstance().getConnectionString());
                conn.Open();

                string deleteQuery = "DELETE FROM voucher WHERE MaVoucher  = @Mavoucher";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@Mavoucher", mavoucher);

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static DataTable FilterByField(string typeValue, string filterValue)
        {
            try
            {
                typeValue = typeValue.Trim();
                filterValue = filterValue.Trim();

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConstants.getInstance().getConnectionString();
                conn.Open();

                string sql = "SELECT * FROM voucher";
                switch (typeValue)
                {
                    case "Mã voucher":
                        sql += " WHERE MaVoucher  LIKE @filterValue";
                        break;
                    default:
                        sql += " WHERE " + typeValue + " like @filterValue";
                        break;
                }

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@filterValue", "%" + filterValue + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                conn.Close();

                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
